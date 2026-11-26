using System;
using System.Collections.Generic;

namespace LibraryLib
{
    // Класс с функциями для Городской библиотеки г. Чита
    public class LibraryFunctions
    {
        // Название библиотеки
        private string libraryName = "Городская библиотека г. Чита";

        // Главный библиотекарь
        private string chiefLibrarian = "Иванова Мария Петровна";

        // Список сотрудников библиотеки
        private List<string> staff = new List<string>
        {
            "Петров П.С.",
            "Сидорова А.В.",
            "Козлов И.Д.",
            "Иванова М.П."
        };

        // 1. Возвращает ФИО главного библиотекаря
        public string GetChiefLibrarian()
        {
            return chiefLibrarian;
        }

        // 2. Возвращает название библиотеки
        public string GetLibraryName()
        {
            return libraryName;
        }

        // 3. Меняет главного библиотекаря, только если ФИО есть в списке сотрудников
        public bool SetChiefLibrarian(string fullname)
        {
            if (staff.Contains(fullname))
            {
                chiefLibrarian = fullname;
                return true;
            }
            return false;
        }

        // 4. Формирует код книги вида CAT_number
        public string GenerateBookCode(string category, int number)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, number + 1);
            return $"{category}_{randomNumber}";
        }

        // 5. Возвращает список сотрудников
        public List<string> GetStaff()
        {
            return staff;
        }

        // 6. Добавляет нового сотрудника
        public void AddStaff(string fullname)
        {
            staff.Add(fullname);
        }
    }
}