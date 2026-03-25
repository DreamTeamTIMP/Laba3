
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Laba3Test2
{
    public partial class MainForm : Form
    {
        private readonly string _username;
        private readonly Dictionary<string, int> _menuRights;
        private readonly Assembly _menuAssembly;


        public MainForm(string username, Dictionary<string, int> menuRights, Assembly menuAssembly)
        {
            _username = username;
            _menuRights = menuRights;
            _menuAssembly = menuAssembly;

            InitializeComponent();
            BuildMenuViaReflection();

        }

        /// <summary>
        /// Строит меню через явный вызов методов MenuManager через Reflection.
        /// Последовательность:
        ///   1. GetType("MenuLibrary.MenuManager")
        ///   2. CreateInstance(menuFilePath)
        ///   3. GetMethod("BuildMenuStrip")
        ///   4. Invoke → получаем MenuStrip
        /// </summary>
        private void BuildMenuViaReflection()
        {
            menuStrip.Items.Clear();

            Type? managerType = _menuAssembly.GetType("MenuLibrary.MenuManager");
            if (managerType == null)
            {
                MessageBox.Show("Класс MenuManager не найден в MenuLibrary.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создаём MenuManager("menu.txt")
            object? manager = Activator.CreateInstance(managerType, "menu.txt");
            if (manager == null) return;

            // Получаем метод BuildMenuStrip
            MethodInfo? buildMethod = managerType.GetMethod("BuildMenuStrip",
                new[] { typeof(Dictionary<string, int>), typeof(EventHandler) });

            if (buildMethod == null)
            {
                MessageBox.Show("Метод BuildMenuStrip не найден в MenuManager.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Вызываем метод
            EventHandler handler = MenuItemClicked;
            object? result = buildMethod.Invoke(manager, new object[] { _menuRights, handler });

            if (result is MenuStrip strip)
            {
                // Переносим пункты
                var items = new List<ToolStripItem>();
                foreach (ToolStripItem item in strip.Items)
                    items.Add(item);

                foreach (var item in items)
                {
                    strip.Items.Remove(item);
                    menuStrip.Items.Add(item);
                }
            }
        }

        private void MenuItemClicked(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                string methodName = item.Tag?.ToString() ?? string.Empty;
                labelStatus.Text = $"Вызван метод: {methodName}  [пункт: {item.Text}]";
                labelStatusBar.Text = $"Пользователь: {_username}  |  Последнее действие: {item.Text}";
            }
        }
        

    }
}
