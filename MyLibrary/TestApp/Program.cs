using System;
using MyLibrary; 

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethods m = new MyMethods();

            m.SayHello();
            m.PrintSum(10, 5);
            Console.WriteLine($"Add: {m.Add(10, 5)}");
            Console.WriteLine($"Divide: {m.Divide(10, 4)}");
            Console.WriteLine(m.GetGreeting("Иван"));

            Console.ReadLine();
        }
    }
}