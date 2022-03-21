using System;

namespace _6._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                int currentNumFactorial = 1;

                for (int j = 1; j <= int.Parse(num[i].ToString()); j++)
                {
                    currentNumFactorial *= j;
                }
                sum += currentNumFactorial;
            }

            if (sum == int.Parse(num))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
