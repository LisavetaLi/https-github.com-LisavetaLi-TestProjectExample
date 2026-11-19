using System;

namespace Topic5_StringComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("   Тема 5. Сравнение строк ");
            Console.WriteLine();

            string str1 = "Привет";
            string str2 = "привет";
            string str3 = "Привет";
            string str4 = "Мир";

            // 1. Операторы == и !=
            Console.WriteLine("1. Операторы == и !=");
            Console.WriteLine($"str1 == str3: {str1 == str3}"); // True
            Console.WriteLine($"str1 != str2: {str1 != str2}"); // True
            Console.WriteLine($"str1 == str2: {str1 == str2}"); // False (разный регистр)
            Console.WriteLine();

            //// 2. Метод Equals
            //Console.WriteLine("2. Метод Equals()");
            //// Сравнение по значению (с учетом регистра)
            //Console.WriteLine($"str1.Equals(str3): {str1.Equals(str3)}"); // True
            //Console.WriteLine($"str1.Equals(str2): {str1.Equals(str2)}"); // False
            //// Сравнение без учета регистра
            //Console.WriteLine($"str1.Equals(str2, StringComparison.OrdinalIgnoreCase): {str1.Equals(str2, StringComparison.OrdinalIgnoreCase)}"); // True
            //Console.WriteLine();

            //// 3. Метод Compare (с учетом текущей культуры)
            //Console.WriteLine("3. Метод Compare()");
            //int resultCompare = string.Compare(str1, str2);
            //Console.WriteLine($"Compare(str1, str2): {resultCompare}");
            //if (resultCompare < 0)
            //    Console.WriteLine("   str1 стоит перед str2 по алфавиту");
            //else if (resultCompare > 0)
            //    Console.WriteLine("   str1 стоит после str2 по алфавиту");
            //else
            //    Console.WriteLine("   Строки равны");
            //Console.WriteLine();

            //// 4. Метод CompareOrdinal (без учета локали, побайтовое сравнение)
            //Console.WriteLine("4. Метод CompareOrdinal()");
            //int resultOrdinal = string.CompareOrdinal(str1, str4);
            //Console.WriteLine($"CompareOrdinal(str1, str4): {resultOrdinal}");
            //Console.WriteLine("   (Отрицательное число означает, что str1 меньше str4)");
            //Console.WriteLine();

            //// 5. Метод Contains (содержит ли строка подстроку)
            //Console.WriteLine("5. Метод Contains()");
            //Console.WriteLine($"str4.Contains(\"и\"): {str4.Contains("и")}"); // True
            //Console.WriteLine($"str4.Contains(\"Привет\"): {str4.Contains("Привет")}"); // False
            //Console.WriteLine();

            //// 6. Метод IndexOf (поиск индекса подстроки)
            //Console.WriteLine("6. Метод IndexOf()");
            //int index = str4.IndexOf("и");
            //Console.WriteLine($"str4.IndexOf(\"и\"): {index}"); // Индекс символа 'и' в слове "Мир" (0 - М, 1 - и, 2 - р)
            //Console.WriteLine($"str4.IndexOf(\"Привет\"): {str4.IndexOf("Привет")}"); // -1 (не найдено)

            Console.WriteLine();
            Console.WriteLine("   Программа завершена.");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}