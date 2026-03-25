using AuthLibrary;
using MenuLibrary;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
    public partial class MainForm : Form
    {
        private readonly UserInfo _user;
        private readonly MenuManager _menuManager;

        
        public MainForm(UserInfo user)
        {
            _user = user;
            _menuManager = new MenuManager("menu.txt");
            InitializeComponent();
            BuildMenu();
        }

        /// <summary>
        /// Строит меню из MenuManager с учётом прав пользователя.
        /// </summary>
        private void BuildMenu()
        {
            menuStrip.Items.Clear();

            var strip = _menuManager.BuildMenuStrip(_user.MenuRights, MenuItemClicked);

            var itemsToMove = strip.Items.Cast<ToolStripItem>().ToList();
            foreach (var item in itemsToMove)
            {
                strip.Items.Remove(item);
                menuStrip.Items.Add(item);
            }
        }
        /// <summary>
        /// Обработчик нажатия на пункт меню.
        /// Отображает имя выбранного пункта.
        /// </summary>
        private void MenuItemClicked(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                string methodName = item.Tag?.ToString() ?? string.Empty;
                string title = item.Text;

                // Вывод выбранного пункта (имитация вызова метода по имени)
                labelStatus.Text = $"Вызван метод: {methodName}  [пункт: {title}]";
                labelStatusBar.Text = $"Пользователь: {_user.Username}  |  Последнее действие: {title}";
            }
        }


    }
}
