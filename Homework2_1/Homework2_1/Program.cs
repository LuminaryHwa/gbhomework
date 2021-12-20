using System;

namespace Homework2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxTemp;

            double minTemp;

            Console.WriteLine($"Максимальная температура за сутки");

            maxTemp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Минимальная температура за сутки");

            minTemp = Convert.ToInt32(Console.ReadLine());

            double srednTemp = minTemp + maxTemp;

            Console.WriteLine("Средняя температура"); 
            
            Console.WriteLine(srednTemp / 2);




        }
    }
}