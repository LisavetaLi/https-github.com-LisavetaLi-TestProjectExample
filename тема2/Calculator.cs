using System;

namespace тема2  
{
    public class Calculator

    {
       
       
        public int Add(int a, int b) // возвращает целое число и выполняет сложение
        {
            return a + b;
        }

        
        private double Dev(double a, double b) // возвращает дробное число и выполняет деление 
        {
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
                return 0;
            }
            return a / b;
        }

        
        public void ShowDivision(double a, double b) // публичный метод, который вызывает пиватный метод и выводит результат на экран 
        {
            Console.WriteLine($"Частное: {Dev(a, b)}");
        }
    }
}