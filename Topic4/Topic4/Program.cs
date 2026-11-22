using System;
using System.IO;

namespace Topic4_UniqueExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Тема 4. Обработка исключений (Уникальные примеры) ===\n");

            // 1. Базовый try-catch (Проверка возраста)
            Console.WriteLine("1. Проверка возраста (ArgumentOutOfRangeException):");
            try
            {
                int age = -5; // Некорректный возраст
                if (age < 0 || age > 150)
                    throw new ArgumentOutOfRangeException(nameof(age), "Возраст не может быть отрицательным или больше 150.");

                Console.WriteLine("Доступ разрешен.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine();

            //// 2. Множественные catch (Ввод пароля и конвертация)
            //Console.WriteLine("2. Ввод пароля (FormatException и NullReferenceException):");
            //try
            //{
            //    Console.Write("Введите код доступа (число): ");
            //    string input = null; // Имитация отсутствия ввода

            //    int code = int.Parse(input); // Вызовет исключение

            //    string password = null;
            //    Console.WriteLine(password.Length); // Вызовет NullReferenceException
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Ошибка формата: Вы ввели не число. ({ex.Message})");
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine($"Ошибка ссылки: Данные не были введены. ({ex.Message})");
            //}
            //Console.WriteLine();

            //// 3. Фильтры исключений (when) - Работа с банком
            //Console.WriteLine("3. Банковский перевод (Фильтр when для OverflowException):");
            //try
            //{
            //    int balance = int.MaxValue; // Максимальное значение int
            //    int transfer = 100;         // Попытка перевести еще 100

            //    checked // Включаем проверку переполнения
            //    {
            //        balance += transfer;
            //    }
            //}
            //catch (OverflowException ex) when (ex.Message.Contains("overflow") || ex.Message.Contains("переполнение"))
            //{
            //    Console.WriteLine("Сработал фильтр: Счет переполнен! Перевод отменен.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Другая ошибка: {ex.Message}");
            //}
            //Console.WriteLine();

            //// 4. Блок finally (Чтение файла)
            //Console.WriteLine("4. Чтение файла (FileNotFoundException и finally):");
            //try
            //{
            //    Console.WriteLine("Попытка открыть файл 'config.txt'...");
            //    string content = File.ReadAllText("config.txt"); // Файла нет, будет ошибка
            //    Console.WriteLine(content);
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine($"Файл не найден: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Блок finally: Закрываем все соединения и освобождаем память.");
            //}
            //Console.WriteLine();

            //// 5. Свойства Message и TargetSite
            //Console.WriteLine("5. Свойства исключения (TargetSite):");
            //try
            //{
            //    var data = new int[] { 1, 2, 3 };
            //    var item = data[10]; // IndexOutOfRangeException
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Текст ошибки (Message): {ex.Message}");
            //    Console.WriteLine($"Где произошло (TargetSite): {ex.TargetSite?.Name}");
            //}
            //Console.WriteLine();

            //// 6. Вложенные try-catch (Обработка данных из базы)
            //Console.WriteLine("6. Вложенные try-catch (InnerException):");
            //try
            //{
            //    try
            //    {
            //        Console.WriteLine("Загрузка данных из базы...");
            //        throw new InvalidOperationException("База данных недоступна.");
            //    }
            //    catch (InvalidOperationException innerEx)
            //    {
            //        Console.WriteLine($"Внутренняя ошибка: {innerEx.Message}");
            //        // Пробрасываем наверх с контекстом
            //        throw new ApplicationException("Не удалось выполнить операцию.", innerEx);
            //    }
            //}
            //catch (ApplicationException outerEx)
            //{
            //    Console.WriteLine($"Внешняя ошибка: {outerEx.Message}");
            //    Console.WriteLine($"Причина (InnerException): {outerEx.InnerException?.Message}");
            //}

            Console.WriteLine("\n=== Программа завершена ===");
            Console.ReadLine();
        }
    }
}

//Первый пример(Проверка возраста).

//Здесь я использую обычный блок try-catch.

//Программа проверяет возраст человека. Если он меньше 0 или больше 150, я специально вызываю ошибку ArgumentOutOfRangeException через команду throw.

//Блок catch ловит эту ошибку и выводит понятное сообщение, что возраст введен неверно.

//Второй пример (Ввод пароля и конвертация).

//Здесь я показываю использование нескольких блоков catch подряд.

//Сначала программа пытается превратить пустую строку (null) в число. Это вызывает ошибку формата FormatException.

//Так как у нас есть несколько блоков catch, программа ищет подходящий. Срабатывает первый, и мы выводим сообщение, что введено не число.

//Третий пример (Банковский перевод и переполнение).

//Здесь я использую фильтр when.

//Я имитирую ситуацию, когда на счете лежит максимально возможное число, и мы пытаемся добавить к нему еще денег. Это вызывает ошибку переполнения OverflowException.

//Фильтр when проверяет текст ошибки. Если в нем есть слово "overflow" (переполнение), срабатывает блок catch и переводит деньги обратно, выводя сообщение, что счет переполнен.

//Четвертый пример (Чтение файла).

//Здесь главную роль играет блок finally.

//Программа пытается открыть файл config.txt, которого не существует. Возникает ошибка FileNotFoundException, и блок catch ее ловит.

//Но самое главное — после этого всегда срабатывает блок finally. В реальной жизни там пишут код, который закрывает файлы или соединения с базой данных, чтобы ничего не зависло.

//Пятый пример (Свойства ошибки).

//Здесь я показываю, как достать полезную информацию из самой ошибки.

//Программа пытается взять 10-й элемент из массива, где всего 3 элемента. Возникает ошибка IndexOutOfRangeException.

//Внутри catch я вывожу свойство Message (это текст ошибки) и свойство TargetSite (это имя метода, где произошел сбой).

//Шестой пример (Вложенные блоки и InnerException).

//Здесь один try-catch находится внутри другого.

//Внутренний блок имитирует ошибку подключения к базе данных. Он ее ловит, пишет сообщение, а затем с помощью throw создает новую, более общую ошибку, но прикрепляет старую к ней как InnerException (внутренняя ошибка).

//Внешний catch ловит эту новую ошибку и выводит как общее сообщение, так и причину — то есть текст внутренней ошибки. Это нужно, чтобы при сбое не потерять информацию о том, с чего все началось.

