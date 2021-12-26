using System;

namespace Homework3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = "Hello";

            string rev = "";

            for (int i = array.Length - 1; i >= 0; i--)
            {
                rev += array[i];
            }

            Console.WriteLine(rev);

            Console.ReadLine();
        }
     
    }
}
