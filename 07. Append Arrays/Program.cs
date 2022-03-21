using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main()
        {
            List<string> inputList = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries)
                                                       .Select(x => x.Trim())
                                                       .ToList();
            var outputList = new List<string>();
            inputList = inputList.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

            for (int i = inputList.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < inputList[i].Split().Length; j++)
                {
                    outputList.Add(inputList[i].Split(' ')[j]);
                }
            }
            outputList = outputList.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            Console.WriteLine(string.Join(' ', outputList));
        }
    }
}
