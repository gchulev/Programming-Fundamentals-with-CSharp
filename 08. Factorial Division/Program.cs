using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numOne = float.Parse(Console.ReadLine());
            float numTwo = float.Parse(Console.ReadLine());

            DivideFactorialSums(numOne, numTwo);
        }
        public static void DivideFactorialSums(float numOne, float numTwo)
        {
            float firstResult = 1;
            float secondResult = 1;

            for (int i = 1; i <= numOne; i++)
            {
                firstResult *= i;
            }
            for (int i = 1; i <= numTwo; i++)
            {
                secondResult *= i;
            }

            Console.WriteLine($"{firstResult / secondResult:f2}");
        }
    }
}
