using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VowelCount(input);
        }
        public static void VowelCount(string input)
        {
            string vowels = "a, e, i, o, u, A, E, I, O, U";

            int vowelCounter = 0;

            foreach (char item in input)
            {
                if (vowels.Contains(item))
                {
                    vowelCounter++;
                }
            }
            Console.WriteLine(vowelCounter);
        }
    }
}
