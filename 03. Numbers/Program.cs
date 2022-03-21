using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main()
        {
            List<float> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(float.Parse).ToList();

            float average = numbers.Sum() / numbers.Count;
            numbers = numbers.Where(x => x > average).ToList();

            if (numbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                if (numbers.Count > 5)
                {
                    numbers.Sort();
                    numbers.Reverse();
                    numbers = numbers.Take(5).ToList();
                }
                else
                {
                    numbers.Sort();
                    numbers.Reverse();
                }
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
