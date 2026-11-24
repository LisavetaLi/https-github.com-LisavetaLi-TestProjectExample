using System;
using System.Linq;



class Program
{
    
    // ЗАДАНИЕ 1. Методы для работы с массивами
    // Сортировка по возрастанию.
    // OrderBy(x => x) сортирует элементы от меньшего к большему.
    // ToArray() превращает результат обратно в массив.
    // Исходный массив НЕ меняется — возвращается новый.
    static int[] SortAscending(int[] arr)
    {
        return arr.OrderBy(x => x).ToArray();
    }

    // Сортировка по убыванию.
    // OrderByDescending делает то же, но от большего к меньшему.
    static int[] SortDescending(int[] arr)
    {
        return arr.OrderByDescending(x => x).ToArray();
    }

    // Объединение двух массивов в один.
    // Concat склеивает две последовательности: сначала все элементы a,
    // затем все элементы b. ToArray() собирает это в новый массив.
    static int[] MergeArrays(int[] a, int[] b)
    {
        return a.Concat(b).ToArray();
    }

    
    // ЗАДАНИЕ 2. Абсолютная разность с 123
   
    // Считаем |n - 123|. Если n > 123 — умножаем результат на 3.
    // Math.Abs убирает знак (делает число неотрицательным).
    // Тернарный оператор ? : заменяет короткий if/else.
    static int DifferenceWith123(int n)
    {
        int diff = Math.Abs(n - 123);
        return n > 123 ? diff * 3 : diff;
    }

    static void Main()
    {
        // Чтобы русские буквы в консоли отображались корректно
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        
        // ЗАДАНИЕ 1 — демонстрация
        
        Console.WriteLine(" ЗАДАНИЕ 1: Массивы ");

        int[] first = { 12, 4, 8, 1, 15 };
        int[] second = { 7, 3, 10 };

        // string.Join(", ", массив) выводит элементы через запятую
        Console.WriteLine("Первый массив:  " + string.Join(", ", first));
        Console.WriteLine("Второй массив:  " + string.Join(", ", second));
        Console.WriteLine("По возрастанию: " + string.Join(", ", SortAscending(first)));
        Console.WriteLine("По убыванию:    " + string.Join(", ", SortDescending(first)));
        Console.WriteLine("Объединение:    " + string.Join(", ", MergeArrays(first, second)));

        
        // ЗАДАНИЕ 2 — ввод числа и расчёт
        // 
        Console.WriteLine("\n ЗАДАНИЕ 2: Разность с 123 ");

        Console.Write("Введите целое число n: ");
        string? input = Console.ReadLine();

        // TryParse: безопасно проверяем, что введено именно целое число.
        // Если да — true и значение в n; если нет — false, программа не падает.
        if (!int.TryParse(input, out int n))
        {
            Console.WriteLine("Ошибка: нужно ввести целое число.");
        }
        else
        {
            int result = DifferenceWith123(n);
            Console.WriteLine($"n = {n}, результат = {result}");
        }

        // Проверка на нескольких значениях — чтобы было видно работу условия.
        // n < 123 — разность без утроения; n > 123 — с утроением.
        Console.WriteLine("\nПроверка:");
        foreach (int test in new[] { 50, 100, 123, 150, 200 })
            Console.WriteLine($"  n = {test,4} -> {DifferenceWith123(test)}");
    }
}