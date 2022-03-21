using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = SumOfTwo(firstNum, secondNum);
            Substract(thirdNum, sum);

        }
        public static int SumOfTwo(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        public static void Substract(int num, int sum)
        {
            Console.WriteLine(sum - num);
        }
    }
}
