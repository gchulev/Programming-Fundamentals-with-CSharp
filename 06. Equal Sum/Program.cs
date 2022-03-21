using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int leftSum = 0;
            int rightSum = 0;
            string output = string.Empty;
            bool elementFound = false;

            for (int i = 0; i < input.Length; i++)
            {
                //calculating left sum
                for (int left = 0; left < i; left++)
                {
                    leftSum += int.Parse(input[left].ToString());
                }
                //calculating right sum
                for (int right = input.Length - 1; right > i; right--)
                {
                    rightSum += int.Parse(input[right].ToString());
                }

                if (leftSum == rightSum)
                {
                    output += i.ToString();
                    elementFound = true;
                }

                leftSum = 0;
                rightSum = 0;
            }

            if (elementFound)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}

