using System;
using LibraryLib;

namespace LikhanovaТест
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            LibraryFunctions lib = new LibraryFunctions();

            // 1. Название библиотеки
            Console.WriteLine("Название: " + lib.GetLibraryName());

            // 2. Главный библиотекарь
            Console.WriteLine("Главный библиотекарь: " + lib.GetChiefLibrarian());

            // 3. Смена главного библиотекаря
            Console.WriteLine("Смена на 'Петров П.С.': " + lib.SetChiefLibrarian("Петров П.С."));
            Console.WriteLine("Смена на 'Неизвестный': " + lib.SetChiefLibrarian("Неизвестный"));
            Console.WriteLine("Текущий главный библиотекарь: " + lib.GetChiefLibrarian());

            // 4. Код книги
            Console.WriteLine("Код книги: " + lib.GenerateBookCode("FIC", 100));

            // 5. Список сотрудников
            Console.WriteLine("Сотрудники:");
            foreach (var s in lib.GetStaff()) Console.WriteLine("  " + s);

            // 6. Добавление сотрудника
            lib.AddStaff("Новиков А.А.");
            Console.WriteLine("После добавления:");
            foreach (var s in lib.GetStaff()) Console.WriteLine("  " + s);
        }
    }
}