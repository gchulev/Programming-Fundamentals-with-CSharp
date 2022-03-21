using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }
            for (int i = 0; i < wagons.Length; i++)
            {
                Console.Write($"{wagons[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
