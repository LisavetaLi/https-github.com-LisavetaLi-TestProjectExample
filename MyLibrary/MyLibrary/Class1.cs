using System;

namespace MyLibrary
{
    public class MyMethods
    {
        //  2 метода с типом void 
        public void SayHello() // просто выводит текст на экран.
        {
            Console.WriteLine("Привет! Это метод из DLL.");
        }

        public void PrintSum(int a, int b) // принимает два числа и выводит их сумму на экран.
        {
            Console.WriteLine($"Сумма {a} и {b} = {a + b}");
        }

        //  3 метода с возвращаемыми значениями разных типов 
        public int Add(int a, int b) //возвращает целое число (сумму).
        {
            return a + b;
        }

        public double Divide(double a, double b) //возвращает число с запятой (частное).


        {
            return a / b;
        }

        public string GetGreeting(string name) //возвращает текст (строку).
        {
            return $"Привет, {name}!";
        }
    }
}