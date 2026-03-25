using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MenuLibrary
{
    /// <summary>
    /// Представляет один пункт меню.
    /// </summary>
    public class MenuItem
    {
        /// <summary>Уровень иерархии (0 - главное меню, 1+ - подменю)</summary>
        public int Level { get; set; }

        /// <summary>Название пункта меню</summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>Имя метода-обработчика (пустое, если есть подменю)</summary>
        public string MethodName { get; set; } = string.Empty;

        /// <summary>Дочерние пункты</summary>
        public List<MenuItem> Children { get; set; } = new List<MenuItem>();
    }

    /// <summary>
    /// Класс для построения меню из внешнего файла.
    /// Файл menu.txt: строки вида "Уровень Название [ИмяМетода]"
    /// </summary>
    public class MenuManager
    {
        private readonly List<MenuItem> _rootItems = new List<MenuItem>();
        private readonly string _menuFilePath;

        /// <summary>
        /// Конструктор: читает файл меню и строит дерево пунктов.
        /// </summary>
        /// <param name="menuFilePath">Путь к файлу меню (по умолчанию menu.txt)</param>
        public MenuManager(string menuFilePath = "menu.txt")
        {
            _menuFilePath = menuFilePath;
            LoadMenuFromFile();
        }

        /// <summary>
        /// Читает файл меню и строит дерево пунктов.
        /// Формат строки: "Уровень Название [ИмяМетода]"
        /// </summary>
        private void LoadMenuFromFile()
        {
            _rootItems.Clear();

            if (!File.Exists(_menuFilePath))
                throw new FileNotFoundException($"Файл меню не найден: {_menuFilePath}");

            var allItems = new List<MenuItem>();

            foreach (var line in File.ReadLines(_menuFilePath))
            {
                var trimmed = line.Trim();
                if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith("//"))
                    continue;

                // Парсинг: "Уровень Название [ИмяМетода]"
                var parts = trimmed.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length < 2) continue;

                if (!int.TryParse(parts[0], out int level)) continue;

                string title = parts[1];
                string methodName = parts.Length >= 3 ? parts[2] : string.Empty;

                allItems.Add(new MenuItem
                {
                    Level = level,
                    Title = title,
                    MethodName = methodName
                });
            }

            // Строим дерево
            BuildTree(allItems);
        }

        /// <summary>
        /// Строит иерархию из плоского списка пунктов.
        /// </summary>
        private void BuildTree(List<MenuItem> flat)
        {
            _rootItems.Clear();

            // Стек для отслеживания текущих родителей на каждом уровне
            var stack = new Stack<MenuItem>();

            foreach (var item in flat)
            {
                // Убираем из стека элементы того же или более глубокого уровня
                while (stack.Count > 0 && stack.Peek().Level >= item.Level)
                    stack.Pop();

                if (stack.Count == 0)
                {
                    _rootItems.Add(item);
                }
                else
                {
                    stack.Peek().Children.Add(item);
                }

                stack.Push(item);
            }
        }

        /// <summary>
        /// Строит MenuStrip для главного окна с учётом прав пользователя.
        /// </summary>
        /// <param name="userRights">Словарь: название пункта -> статус (0=виден+доступен, 1=виден+недоступен, 2=скрыт)</param>
        /// <param name="clickHandler">Обработчик нажатия на пункт меню (имя метода передаётся через Tag)</param>
        /// <returns>Сформированный MenuStrip</returns>
        public MenuStrip BuildMenuStrip(
            Dictionary<string, int> userRights,
            EventHandler clickHandler)
        {
            var menuStrip = new MenuStrip();
            menuStrip.BackColor = System.Drawing.SystemColors.Control;

            foreach (var root in _rootItems)
            {
                var tsItem = BuildToolStripItem(root, userRights, clickHandler);
                if (tsItem != null)
                    menuStrip.Items.Add(tsItem);
            }

            return menuStrip;
        }

        /// <summary>
        /// Рекурсивно строит ToolStripMenuItem для пункта меню.
        /// </summary>
        private ToolStripMenuItem? BuildToolStripItem(
            MenuItem item,
            Dictionary<string, int> userRights,
            EventHandler clickHandler)
        {
            int status = userRights.TryGetValue(item.Title, out int s) ? s : 0;

            // Статус 2 - не отображать
            if (status == 2)
                return null;

            var tsItem = new ToolStripMenuItem(item.Title);
            tsItem.Tag = item.MethodName;
            tsItem.Enabled = (status == 0);

            // Добавляем дочерние пункты
            foreach (var child in item.Children)
            {
                var childItem = BuildToolStripItem(child, userRights, clickHandler);
                if (childItem != null)
                    tsItem.DropDownItems.Add(childItem);
            }

            // Обработчик только для листовых пунктов с именем метода
            if (!string.IsNullOrEmpty(item.MethodName) && item.Children.Count == 0)
            {
                tsItem.Click += clickHandler;
            }

            return tsItem;
        }

        /// <summary>
        /// Возвращает список корневых пунктов меню.
        /// </summary>
        public IReadOnlyList<MenuItem> GetRootItems() => _rootItems.AsReadOnly();

        /// <summary>
        /// Перезагружает меню из файла.
        /// </summary>
        public void Reload() => LoadMenuFromFile();
    }
}
