using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(' ');
            int[] nums = inputArr.Select(int.Parse).ToArray();

            string output = string.Empty;

            for (int i = 0; i < nums.Length; i++)
            {
                int? topNumber = null;

                if (i == nums.Length - 1)
                {
                    output += $"{nums[i]} ";
                }

                for (int c = i + 1; c < nums.Length; c++)
                {
                    if (nums[i] > nums[c])
                    {
                        topNumber = nums[i];
                    }
                    else
                    {
                        topNumber = null;
                        break;
                    }
                }

                if (topNumber != null)
                {
                    output += $"{topNumber} ";
                }
            }

            Console.WriteLine(output);
        }
    }
}
