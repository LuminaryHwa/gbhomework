using static System.Console;

namespace Homework3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] array = new string[5, 2]
            {
                {"Женя", "2512362"},
                {"Гена", "2131516"},
                {"Ваня", "2131111"},
                {"Лёша", "6786574"},
                {"Саша", "6543336"},
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int q = 0; q < array.GetLength(1); q++)
                    Write(array[i, q] + " ");
                WriteLine();
            }

            ReadLine();
        }
    }
}