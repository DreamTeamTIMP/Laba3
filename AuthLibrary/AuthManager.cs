using System;
using System.Collections.Generic;
using System.IO;

namespace AuthLibrary
{
    /// <summary>
    /// Данные авторизованного пользователя.
    /// </summary>
    public class UserInfo
    {
        /// <summary>Имя пользователя</summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>Права доступа к пунктам меню: название -> статус (0/1/2)</summary>
        public Dictionary<string, int> MenuRights { get; set; } = [];
    }

    /// <summary>
    /// Класс авторизации пользователей.
    /// Читает файл USERS.txt следующей структуры:
    ///
    /// #ИмяПользователя Пароль
    /// НазваниеПункта СтатусПункта
    /// ...
    ///
    /// Статусы: 0=виден+доступен, 1=виден+недоступен, 2=скрыт.
    /// Отсутствующий пункт имеет статус 0 по умолчанию.
    /// </summary>
    public class AuthManager
    {
        private readonly Dictionary<string, (string password, Dictionary<string, int> rights)> _users
            = new Dictionary<string, (string, Dictionary<string, int>)>(StringComparer.OrdinalIgnoreCase);

        private readonly string _usersFilePath;

        /// <summary>
        /// Конструктор: загружает файл пользователей.
        /// </summary>
        /// <param name="usersFilePath">Путь к файлу USERS.txt</param>
        public AuthManager(string usersFilePath = "USERS.txt")
        {
            _usersFilePath = usersFilePath;
            LoadUsers();
        }

        /// <summary>
        /// Загружает и разбирает файл пользователей.
        /// </summary>
        private void LoadUsers()
        {
            _users.Clear();

            if (!File.Exists(_usersFilePath))
                throw new FileNotFoundException($"Файл пользователей не найден: {_usersFilePath}");

            string? currentUser = null;
            string? currentPassword = null;
            var currentRights = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (var line in File.ReadLines(_usersFilePath))
            {
                var trimmed = line.Trim();
                if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith("//"))
                    continue;

                if (trimmed.StartsWith("#"))
                {
                    // Сохраняем предыдущего пользователя
                    if (currentUser != null)
                        _users[currentUser] = (currentPassword ?? string.Empty, currentRights);

                    // Начало нового пользователя: #Имя Пароль
                    var parts = trimmed.Substring(1).Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    currentUser = parts.Length >= 1 ? parts[0] : null;
                    currentPassword = parts.Length >= 2 ? parts[1] : string.Empty;
                    currentRights = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                }
                else if (currentUser != null)
                {
                    // Строка прав: "НазваниеПункта СтатусПункта"
                    var parts = trimmed.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 2 && int.TryParse(parts[parts.Length - 1], out int status))
                    {
                        // Название может содержать пробелы — берём всё кроме последнего токена
                        string menuItem = string.Join(" ", parts, 0, parts.Length - 1);
                        currentRights[menuItem] = status;
                    }
                }
            }

            // Сохраняем последнего пользователя
            if (currentUser != null)
                _users[currentUser] = (currentPassword ?? string.Empty, currentRights);
        }

        /// <summary>
        /// Проверяет имя и пароль пользователя.
        /// </summary>
        /// <param name="username">Имя пользователя</param>
        /// <param name="password">Пароль</param>
        /// <returns>UserInfo при успехе, null при неверных данных</returns>
        public UserInfo? Authenticate(string username, string password)
        {
            if (_users.TryGetValue(username, out var entry))
            {
                if (entry.password == password)
                {
                    return new UserInfo
                    {
                        Username = username,
                        MenuRights = new Dictionary<string, int>(entry.rights, StringComparer.OrdinalIgnoreCase)
                    };
                }
            }
            return null;
        }

        /// <summary>
        /// Проверяет, существует ли пользователь.
        /// </summary>
        public bool UserExists(string username) => _users.ContainsKey(username);

        /// <summary>
        /// Перезагружает файл пользователей.
        /// </summary>
        public void Reload() => LoadUsers();
    }
}
