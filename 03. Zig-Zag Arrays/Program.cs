using System;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (i % 2 == 0)
                {
                    firstArr[i] = int.Parse(input[0]);
                    secondArr[i] = int.Parse(input[1]);
                }
                else
                {
                    firstArr[i] = int.Parse(input[1]);
                    secondArr[i] = int.Parse(input[0]);
                }
            }

            foreach (int item in firstArr)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            foreach (int item in secondArr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
