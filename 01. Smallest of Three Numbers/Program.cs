using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int param1 = int.Parse(Console.ReadLine());
            int param2 = int.Parse(Console.ReadLine());
            int param3 = int.Parse(Console.ReadLine());

            PrintSmallestNum(param1, param2, param3);
        }

        public static void PrintSmallestNum(int? numOne, int? numTwo, int? numTree)
        {
            int? smallestNumt = null;
            if (numOne <= numTwo && numOne <= numTree)
            {
                smallestNumt = numOne;
            }
            else if (numTwo <= numOne && numTwo <= numTree)
            {
                smallestNumt = numTwo;
            }
            else if (numTree <= numOne && numTree <= numTwo)
            {
                smallestNumt = numTree;
            }

            Console.WriteLine(smallestNumt);
        }
    }
}
