using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<char, int> output = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!output.ContainsKey(input[i]))
                {
                    if (!char.IsWhiteSpace(input[i]))
                    {
                        int currentElementCount = input.Count(x => x == input[i]);
                        output.Add(input[i], currentElementCount);
                    }
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
