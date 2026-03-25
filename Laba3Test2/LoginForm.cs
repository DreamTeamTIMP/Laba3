using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3Test2
{
    public partial class LoginForm : Form
    {

        // Явно загруженная сборка 
        private Assembly? _authAssembly;
        private Assembly? _menuAssembly;
        private object? _authManagerInstance;   // экземпляр AuthManager

        public LoginForm()
        {
            InitializeComponent();
            LoadLibrariesExplicitly();
            UpdateStatusBar();
        }
        private void LoadLibrariesExplicitly()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            // Загрузка AuthLibrary
            string authDllPath = Path.Combine(baseDir, "AuthLibrary.dll");
            if (File.Exists(authDllPath))
            {
                _authAssembly = Assembly.LoadFrom(authDllPath);

                // Создаём экземпляр AuthManager: new AuthManager("USERS.txt")
                Type? authManagerType = _authAssembly.GetType("AuthLibrary.AuthManager");
                if (authManagerType != null)
                    _authManagerInstance = Activator.CreateInstance(authManagerType, "USERS.txt");
            }
            else
            {
                MessageBox.Show(
                    $"Библиотека AuthLibrary.dll не найдена.\nПуть: {authDllPath}\n\nАвторизация недоступна.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Загрузка MenuLibrary
            string menuDllPath = Path.Combine(baseDir, "MenuLibrary.dll");
            if (File.Exists(menuDllPath))
            {
                _menuAssembly = Assembly.LoadFrom(menuDllPath);
            }
            else
            {
                MessageBox.Show(
                    $"Библиотека MenuLibrary.dll не найдена.\nПуть: {menuDllPath}\n\nМеню недоступно.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonLogin_Click(object? sender, EventArgs e)
        {
            if (_authManagerInstance == null || _authAssembly == null || _menuAssembly == null)
            {
                MessageBox.Show("Библиотеки не загружены. Авторизация невозможна.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = textBoxUser.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Введите имя пользователя.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUser.Focus();
                return;
            }

            // Явный вызов метода: _authManagerInstance.Authenticate(username, password)
            Type authType = _authManagerInstance.GetType();
            MethodInfo? authenticateMethod = authType.GetMethod("Authenticate",
                new[] { typeof(string), typeof(string) });

            if (authenticateMethod == null)
            {
                MessageBox.Show("Метод Authenticate не найден в AuthLibrary.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object? result = authenticateMethod.Invoke(_authManagerInstance,
                new object[] { username, password });

            if (result == null)
            {
                MessageBox.Show("Неверное имя пользователя или пароль.", "Ошибка авторизации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Clear();
                textBoxPassword.Focus();
                return;
            }

            // Читаем Username и MenuRights из объекта UserInfo через Reflection
            Type userInfoType = result.GetType();

            string? authenticatedUsername = userInfoType
                .GetProperty("Username")?.GetValue(result) as string ?? username;

            object? menuRightsObj = userInfoType
                .GetProperty("MenuRights")?.GetValue(result);

            var menuRights = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            if (menuRightsObj is System.Collections.IDictionary dict)
            {
                foreach (System.Collections.DictionaryEntry kvp in dict)
                    if (kvp.Key is string k && kvp.Value is int v)
                        menuRights[k] = v;
            }

            // Открываем главное окно
            Hide();
            var mainForm = new MainForm(
                authenticatedUsername,
                menuRights,
                _menuAssembly);

            mainForm.FormClosed += (_, __) => Application.Exit();
            mainForm.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Application.Exit();

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e) => UpdateStatusBar();

        private void UpdateStatusBar()
        {
            // Язык
            var culture = InputLanguage.CurrentInputLanguage.Culture;
            toolStripStatusLabelLang.Text = "Язык ввода " +
                (culture.TwoLetterISOLanguageName.Equals("ru", StringComparison.OrdinalIgnoreCase)
                    ? "Русский" : "Английский");

            // CapsLock
            bool caps = Control.IsKeyLocked(Keys.CapsLock);
            toolStripStatusLabelCaps.Text = caps ? "Клавиша CapsLock нажата" : "";

        }

        private void textBoxUser_KeyDown(object sender, KeyEventArgs e) => UpdateStatusBar();
    }
}
