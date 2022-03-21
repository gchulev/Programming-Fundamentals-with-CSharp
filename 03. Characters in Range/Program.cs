using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main()
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());

            PrintCharsInRange(one, two);
        }
        public static void PrintCharsInRange(char charOne, char charTwo)
        {
            char start;
            char end;

            if (charOne < charTwo)
            {
                start = charOne;
                end = charTwo;
            }
            else
            {
                start=charTwo;
                end=charOne;
            }
            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
