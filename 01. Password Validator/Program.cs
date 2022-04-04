using System;
using System.Linq;

namespace _01._Password_Validator
{
    internal class Program
    {
        static void Main()
        {
            string rawPassword = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Complete")
            {

                if (command.Contains("Make Upper"))
                {
                    int index = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);
                    string letterToReplace = rawPassword[index].ToString().ToUpper();
                    if (index >= 0 && index < rawPassword.Length)
                    {
                        rawPassword = rawPassword.Remove(index, 1);
                        rawPassword = rawPassword.Insert(index, letterToReplace);
                        Console.WriteLine(rawPassword);
                    }
                }
                else if (command.Contains("Make Lower"))
                {
                    int index = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);
                    if (index >= 0 && index < rawPassword.Length)
                    {
                        string letterToReplace = rawPassword[index].ToString().ToLower();
                        rawPassword = rawPassword.Remove(index, 1);
                        rawPassword = rawPassword.Insert(index, letterToReplace);
                        Console.WriteLine(rawPassword);
                    }
                }
                else if (command.Contains("Insert"))
                {
                    int index = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                    string character = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2];

                    if (index >= 0 && index < rawPassword.Length)
                    {
                        rawPassword = rawPassword.Insert(index, character);
                        Console.WriteLine(rawPassword);
                    }
                }
                else if (command.Contains("Replace"))
                {
                    char givenChar = char.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                    int value = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);

                    if (rawPassword.Contains(givenChar))
                    {
                        char newSymbol = (char)(givenChar + value);
                        rawPassword = rawPassword.Replace(givenChar, newSymbol);
                        Console.WriteLine(rawPassword);
                    }
                }
                else if (command.Contains("Validation"))
                {
                    if (rawPassword.Length < 8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long!");
                    }
                    if (!rawPassword.All(x => char.IsLetterOrDigit(x) || x == '_'))
                    {
                        Console.WriteLine("Password must consist only of letters, digits and _!");
                    }
                    if (!rawPassword.Any(x => char.IsUpper(x)))
                    {
                        Console.WriteLine("Password must consist at least one uppercase letter!");
                    }
                    if (!rawPassword.Any(x => char.IsLower(x)))
                    {
                        Console.WriteLine("Password must consist at least one lowercase letter!");
                    }
                     if (!rawPassword.Any(x => char.IsDigit(x)))
                    {
                        Console.WriteLine("Password must consist at least one digit!");
                    }
                }

                command = Console.ReadLine();
            }

        }
    }
}
