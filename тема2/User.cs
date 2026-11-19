using System;

namespace тема2
{
    public class User
    
    {
        public int Id { get; set; }          // номер пользователя
        public string Name { get; set; }     // имя
        public string Email { get; set; }    // почта
        public int Age { get; set; }         // возраст
        public bool IsActive { get; set; }   // активен ли

        public void PrintInfo() // выводит всю информацию о пользователе 
        {
            Console.WriteLine($"ID: {Id} | Имя: {Name} | Email: {Email} | Возраст: {Age} | Активен: {IsActive}");
        }
    }
}