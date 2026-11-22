using System;

namespace Topic5_StringComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Тема 5. Сравнение строк (Проверка логинов) ===\n");

            string userInputLogin = "Admin";
            string storedLogin = "admin";
            string storedPassword = "qwerty";
            string userInputPassword = "qwerty";

            // 1. Операторы == и !=
            Console.WriteLine("1. Операторы == и !=");
            bool isLoginExact = (userInputLogin == storedLogin);
            bool isPasswordDifferent = (userInputPassword != storedPassword);

            Console.WriteLine($"Логин точно совпадает (учет регистра): {isLoginExact}"); // False, так как 'A' и 'a'
            Console.WriteLine($"Пароль отличается: {isPasswordDifferent}"); // False, они одинаковые
            Console.WriteLine();

            //// 2. Метод Equals
            //Console.WriteLine("2. Метод Equals()");
            //// Проверяем логин без учета регистра
            //bool isLoginEquals = userInputLogin.Equals(storedLogin, StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine($"Логин совпадает (без учета регистра): {isLoginEquals}"); // True
            //Console.WriteLine();

            //// 3. Метод Compare
            //Console.WriteLine("3. Метод Compare()");
            //// Сравниваем, какой логин идет раньше по алфавиту
            //int compareResult = string.Compare(userInputLogin, storedLogin);
            //if (compareResult < 0)
            //    Console.WriteLine($"Строка '{userInputLogin}' идет раньше по алфавиту, чем '{storedLogin}'");
            //else if (compareResult > 0)
            //    Console.WriteLine($"Строка '{userInputLogin}' идет позже по алфавиту, чем '{storedLogin}'");
            //else
            //    Console.WriteLine("Строки идентичны по алфавиту.");
            //Console.WriteLine();

            //// 4. Метод CompareOrdinal
            //Console.WriteLine("4. Метод CompareOrdinal()");
            //// Сравниваем по байтам (кодам Unicode) без учета языка
            //int ordinalResult = string.CompareOrdinal(userInputLogin, storedLogin);
            //Console.WriteLine($"Результат побайтового сравнения: {ordinalResult}");
            //Console.WriteLine();

            //// 5. Метод Contains
            //Console.WriteLine("5. Метод Contains()");
            //// Проверяем, есть ли слово "Admin" в системном сообщении
            //string systemMessage = "Пользователь Admin успешно вошел в систему.";
            //bool hasAdmin = systemMessage.Contains("Admin");
            //Console.WriteLine($"Есть ли слово 'Admin' в сообщении: {hasAdmin}"); // True
            //Console.WriteLine();

            //// 6. Метод IndexOf
            //Console.WriteLine("6. Метод IndexOf()");
            //// Ищем позицию символа в пароле
            //int indexOfW = storedPassword.IndexOf('w');
            //Console.WriteLine($"Буква 'w' в пароле находится на позиции: {indexOfW}"); // 1 (индексы: q=0, w=1)

            Console.WriteLine("\n=== Программа завершена ===");
            Console.ReadLine();
        }
    }
}

//В этой программе я имитирую процесс авторизации пользователя, чтобы показать, как на практике применяются разные способы сравнения строк.

//Операторы == и != (Проверка на точное совпадение)

//Я сравниваю введенный логин "Admin" с сохраненным "admin".

//Оператор == возвращает False, потому что он учитывает регистр букв (заглавная "A" не равна маленькой "a").

//Оператор != для паролей возвращает False, так как они полностью совпадают.

//Метод Equals() (Гибкая проверка)

//Здесь я использую метод Equals с дополнительным параметром StringComparison.OrdinalIgnoreCase.

//Это позволяет программе сравнить логины, игнорируя регистр. Поэтому результат получается True. Это очень полезно для систем авторизации.

//Метод Compare() (Сортировка по алфавиту)

//Этот метод не говорит «да» или «нет». Он возвращает число.

//Он сравнивает строки по алфавиту с учетом языковых настроек компьютера. Если результат меньше нуля, значит первая строка должна стоять раньше в словаре.

//Метод CompareOrdinal() (Побайтовое сравнение)

//Он работает похоже на Compare, но не смотрит на языковые настройки.

//Он сравнивает строки по их числовым кодам в таблице Unicode. Это более быстрый способ, который используется для системных нужд.

//Метод Contains() (Поиск подстроки)

//Я проверяю, есть ли внутри длинного системного сообщения слово "Admin".

//Метод возвращает True, если находит его. Это удобно для фильтрации логов или поиска ключевых слов в тексте.

//Метод IndexOf() (Поиск позиции)

//Я ищу, на каком месте в пароле "qwerty" находится буква 'w'.

//Метод возвращает 1. Это значит, что буква стоит на первом индексе (если считать с нуля: q — это 0, w — это 1).

//Если бы он не нашел букву, то вернул бы -1.