using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] intArray = input.Select(int.Parse).ToArray();
            string longestSequence = string.Empty;
            string currentSequence = string.Empty;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (i == intArray.Length - 1)
                {
                    if (longestSequence.Length < currentSequence.Length)
                    {
                        longestSequence = currentSequence;
                    }
                    break;
                }
                else
                {
                    if (intArray[i] == intArray[i + 1] && currentSequence == string.Empty)
                    {
                        currentSequence = $"{intArray[i]} {intArray[i + 1]} ";
                    }
                    else if (intArray[i] == intArray[i + 1] && currentSequence != string.Empty)
                    {
                        currentSequence += $"{intArray[i]} ";
                    }
                    else if (intArray[i] != intArray[i + 1])
                    {
                        if (longestSequence.Length < currentSequence.Length)
                        {
                            longestSequence = currentSequence;
                            currentSequence = string.Empty;
                        }
                        else
                        {
                            currentSequence = string.Empty;
                        }
                    }
                }
            }

            Console.WriteLine(longestSequence);
        }
    }
}
