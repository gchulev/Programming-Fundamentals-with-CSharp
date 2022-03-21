using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            MiddleChars(input);
        }
        public static void MiddleChars(string input)
        {
            if (input.Length % 2 == 0)
            {
                int firstIndex = input.Length / 2;
                int secondIndex = (input.Length / 2) - 1;

                Console.WriteLine($"{input[secondIndex]}{input[firstIndex]}");
            }
            else
            {
                int firstIndex = input.Length / 2;

                Console.WriteLine(input[firstIndex]);
            }
        }
    }
}
