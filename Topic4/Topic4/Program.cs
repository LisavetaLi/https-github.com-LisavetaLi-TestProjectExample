using System;

namespace Topic4
{ 

    // Тема 4. Обработка исключений. Типы исключений
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("   Тема 4. Обработка исключений. Типы исключений");
            Console.WriteLine();

            
            // ВАРИАНТ 1: Базовый try-catch (DivideByZeroException)
            
            Console.WriteLine("1. Базовый try-catch (DivideByZeroException):");
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
                Console.WriteLine($"   Результат: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"   Поймано исключение: {ex.Message}");
            }
            Console.WriteLine();

            //// ВАРИАНТ 2: Множественные catch (разные типы исключений)
            
            //Console.WriteLine("2. Множественные catch (IndexOutOfRangeException и Exception):");
            //try
            //{
            //    int[] numbers = { 1, 2, 3 };
            //    Console.WriteLine(numbers[5]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"   Поймано IndexOutOfRangeException: {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"   Поймано другое исключение: {ex.Message}");
            //}
            //Console.WriteLine();

            
            //// ВАРИАНТ 3: Фильтры исключений (when)
            
            //Console.WriteLine("3. Фильтр исключений (when):");
            //try
            //{
            //    string input = "";
            //    int number = int.Parse(input);
            //    Console.WriteLine($"   Число: {number}");
            //}
            //catch (FormatException ex) when (ex.Message.Contains("empty") || ex.Message.Contains("пуст"))
            //{
            //    Console.WriteLine("   Сработал фильтр: строка пустая.");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"   Обычный FormatException: {ex.Message}");
            //}
            //Console.WriteLine();

            
            //// ВАРИАНТ 4: Блок finally (выполняется всегда)
           
            //Console.WriteLine("4. Блок finally (гарантированное выполнение):");
            //try
            //{
            //    Console.WriteLine("   Внутри try: выполняем код...");
            //    throw new InvalidOperationException("Тестовая ошибка");
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine($"   Внутри catch: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("   Внутри finally: ресурсы освобождены.");
            //}
            //Console.WriteLine();

            
            //// ВАРИАНТ 5: Свойства Message и TargetSite
            
            //Console.WriteLine("5. Свойства Message и TargetSite:");
            //try
            //{
            //    object obj = null;
            //    obj.ToString();
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine($"   Message: {ex.Message}");
            //    Console.WriteLine($"   TargetSite: {ex.TargetSite}");
            //}
            //Console.WriteLine();

            
            //// ВАРИАНТ 6: Вложенные try-catch (исключение внутри исключения)
            
            //Console.WriteLine("6. Вложенные try-catch:");
            //try
            //{
            //    try
            //    {
            //        int[] arr = new int[2];
            //        arr[5] = 10; // IndexOutOfRangeException
            //    }
            //    catch (IndexOutOfRangeException ex)
            //    {
            //        Console.WriteLine($"   Внутренний catch: {ex.Message}");
            //        throw new Exception("Ошибка проброшена во внешний блок", ex);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"   Внешний catch: {ex.Message}");
            //    Console.WriteLine($"   Внутреннее исключение: {ex.InnerException?.Message}");
            //}
            //Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("   Программа завершена.");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
