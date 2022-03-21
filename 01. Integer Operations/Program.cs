using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());

            int result1 = one + two;
            int result2 = result1 / three;
            int result3 = result2 * four;

            Console.WriteLine(result3);
        }
    }
}
