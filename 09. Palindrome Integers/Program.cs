using System;
using System.Linq;
using System.Text;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                var comparer = new StringBuilder();

                foreach (char item in command.Reverse())
                {
                    comparer.Append(item);
                }

                if (comparer.ToString() == command)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }

                command = Console.ReadLine();
            }
        }
    }
}
