using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            foreach (string secondItem in secondArray)
            {
                foreach (string firstItem in firstArray)
                {
                    if (firstItem == secondItem)
                    {
                        Console.Write($"{firstItem} ");
                    }
                }
            }
        }
    }
}
