using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            var name = Console.ReadLine();

            Console.WriteLine($" Привет, {name}! Сегодня [{DateTime.Now}]");
        }

    }
}