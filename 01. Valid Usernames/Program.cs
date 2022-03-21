using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (!(input[i].Length >= 3 && input[i].Length <= 16 ))
                {
                    input.Remove(input[i]);
                    i--;
                }
                else if (input[i].Any(x => !char.IsLetterOrDigit(x)) && !(input[i].Contains('-') || input[i].Contains('_')))
                {
                    input.Remove(input[i]);
                    i--;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
