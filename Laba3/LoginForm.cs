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
using AuthLibrary;
namespace Laba3
{
    public partial class LoginForm : Form
    {
        private readonly AuthManager _authManager;

        public LoginForm()
        {
            _authManager = new AuthManager("USERS.txt");
            InitializeComponent();

            // Версия из параметров сборки
            string version = Assembly
                .GetExecutingAssembly()
                .GetName()
                .Version?.ToString() ?? "1.0.0.0";
            labelVersion.Text = "Версия " + version;

            UpdateStatusBar();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Введите имя пользователя.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUser.Focus();
                return;
            }

            var user = _authManager.Authenticate(username, password);
            if (user == null)
            {
                MessageBox.Show("Неверное имя пользователя или пароль.", "Ошибка авторизации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Clear();
                textBoxPassword.Focus();
                return;
            }

            // Авторизация успешна — открываем главное окно
            Hide();
            var mainForm = new MainForm(user);
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
