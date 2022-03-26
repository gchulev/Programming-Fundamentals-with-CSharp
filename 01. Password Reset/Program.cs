using System;
using System.Text;
using System.Linq;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder inputString = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "Done")
            {
                if (command.Contains("TakeOdd"))
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < inputString.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sb.Append(inputString[i]);
                        }
                    }

                    inputString = sb;
                    Console.WriteLine(inputString);
                }
                else if (command.Contains("Cut"))
                {
                    int index = int.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                    int length = int.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);
                    inputString.Remove(index, length);
                    Console.WriteLine(inputString);
                }
                else if (command.Contains("Substitute"))
                {
                    string substringToReplace = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1];
                    string replacement = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2];

                    if (inputString.ToString().Contains(substringToReplace))
                    {
                        inputString.Replace(substringToReplace, replacement);
                        Console.WriteLine(inputString);
                    }
                    else
                    {
                        Console.WriteLine($"Nothing to replace!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {inputString}");
        }
    }
}
