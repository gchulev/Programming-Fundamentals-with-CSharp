using System;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main()
        {
            string rawKey = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                if (command.Contains("Contains"))
                {
                    string substring = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries)[1];
                    if (rawKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (command.Contains("Flip"))
                {
                    string subcommand = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries)[1];
                    int startIndex = int.Parse(command.Split(">>>", StringSplitOptions.RemoveEmptyEntries)[2]);
                    int endIndex = int.Parse(command.Split(">>>", StringSplitOptions.RemoveEmptyEntries)[3]);

                    if (subcommand == "Upper")
                    {
                        string substring = rawKey.Substring(startIndex, endIndex - startIndex);
                        string newSubstring = substring.ToUpper();
                        rawKey = rawKey.Remove(startIndex, endIndex - startIndex);
                        rawKey = rawKey.Insert(startIndex, newSubstring);
                        Console.WriteLine(rawKey);
                    }
                    else if (subcommand == "Lower")
                    {
                        string substring = rawKey.Substring(startIndex, endIndex - startIndex);
                        string newSubstring = substring.ToLower();
                        rawKey = rawKey.Remove(startIndex, endIndex - startIndex);
                        rawKey = rawKey.Insert(startIndex, newSubstring);
                        Console.WriteLine(rawKey);
                    }
                }
                else if (command.Contains("Slice"))
                {
                    int startIndex = int.Parse(command.Split(">>>", StringSplitOptions.RemoveEmptyEntries)[1]);
                    int endIndex = int.Parse(command.Split(">>>", StringSplitOptions.RemoveEmptyEntries)[2]);

                    rawKey = rawKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(rawKey);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
