using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //  ВАРИАНТ 1: Parse 
        // Разбирает строку в DateTime, подбирая формат из набора допустимых
        // для текущей культуры системы
        // Если ни один формат не подошёл — выбрасывает FormatException,
        // поэтому вызов обёрнут в try/catch.
        Console.WriteLine("=== Parse ===");
        try
        {
            DateTime d1 = DateTime.Parse("20.07.2015 18:30:25");
            Console.WriteLine($"Parse: {d1}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }


        //  ВАРИАНТ 2: ParseExact 
        // Разбирает строку строго по заданному шаблону "yyyy-MM-dd HH:mm:ss".
        // При несовпадении с шаблоном также выбрасывает FormatException.
        // InvariantCulture исключает зависимость от региональных настроек.
        Console.WriteLine("\n=== ParseExact ===");
        try
        {
            DateTime d2 = DateTime.ParseExact(
                "2022-01-06 14:45:20",
                "yyyy-MM-dd HH:mm:ss",
                CultureInfo.InvariantCulture);
            Console.WriteLine($"ParseExact: {d2}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }


        //  ВАРИАНТ 3: TryParse 
        // Аналог Parse, но не выбрасывает исключение:
        // возвращает bool — true при успехе, false при неудаче.
        // Результат передаётся через out-параметр. Применяется для проверки
        // пользовательского ввода, где данные могут быть некорректными.
        Console.WriteLine("\n=== TryParse ===");
        string[] inputs = { "06.01.2022", "не дата", "31.12.2023" };

        foreach (var input in inputs)
        {
            if (DateTime.TryParse(input, out DateTime result))
                Console.WriteLine($"TryParse('{input}') -> успех: {result:d}");
            else
                Console.WriteLine($"TryParse('{input}') -> не удалось разобрать");
        }


        //  ВАРИАНТ 4: TryParseExact 
        // Аналог ParseExact, но не выбрасывает исключение:
        // возвращает bool и результат через out-параметр.
        // Сочетает строгий контроль формата с безопасной обработкой ошибок.
        Console.WriteLine("\n=== TryParseExact ===");
        string[] dateInputs = { "17.07.2015", "2015/07/17", "17-07-2015" };
        string format = "dd.MM.yyyy";

        foreach (var input in dateInputs)
        {
            if (DateTime.TryParseExact(input, format,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out DateTime result))
                Console.WriteLine($"TryParseExact('{input}') -> успех: {result:yyyy-MM-dd}");
            else
                Console.WriteLine($"TryParseExact('{input}') -> формат не совпал");
        }


        //  БОНУС: DateOnly и TimeOnly 
        // DateOnly хранит только дату, TimeOnly — только время (.NET 6+).
        // Поддерживают те же методы разбора: Parse, ParseExact,
        // TryParse, TryParseExact — принцип работы идентичен DateTime.
        Console.WriteLine("\n=== DateOnly / TimeOnly ===");

        if (DateOnly.TryParseExact("06.01.2022", "dd.MM.yyyy", out DateOnly d))
            Console.WriteLine($"DateOnly.TryParseExact -> {d}");

        if (TimeOnly.TryParse("06:33:22", out TimeOnly t))
            Console.WriteLine($"TimeOnly.TryParse -> {t}");

        TimeOnly parsedTime = TimeOnly.ParseExact("14:23:30", "HH:mm:ss");
        Console.WriteLine($"TimeOnly.ParseExact -> {parsedTime}");
    }
}