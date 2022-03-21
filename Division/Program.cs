using System;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int divisibleBy = 0;

            if (num % 2 == 0 || num % 3 == 0 || num % 6 == 0 || num % 7 == 0 || num % 10 == 0)
            {
                if (num % 2 == 0)
                {
                    divisibleBy = 2;
                }
                if (num % 3 == 0)
                {
                    divisibleBy = 3;
                }
                if (num % 6 == 0)
                {
                    divisibleBy = 6;
                }
                if (num % 7 == 0)
                {
                    divisibleBy = 7;
                }
                if (num % 10 == 0)
                {
                    divisibleBy = 10;
                }
                if (num % 2 == 0 && num % 3 == 0 && num % 6 == 0)
                {
                    divisibleBy = 6;
                }
                if (num % 2 == 0 && num % 10 == 0)
                {
                    divisibleBy = 10;
                }
                Console.WriteLine($"The number is divisible by {divisibleBy}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
