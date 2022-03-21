using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            string str1 = input[0];
            string str2 = input[1];
            int totalSum = 0;

            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    totalSum += str1[i] * str2[i];
                }
            }
            else if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    totalSum += str1[i] * str2[i];
                }
                var lastMembers = str1.TakeLast(str1.Length - str2.Length);
                totalSum += lastMembers.Sum(x => x);
            }
            else if (str1.Length < str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    totalSum += str1[i] * str2[i];
                }
                var lastMembers = str2.TakeLast(str2.Length - str1.Length);
                totalSum += lastMembers.Sum(x => x);
            }

            Console.WriteLine(totalSum);
        }
    }
}
