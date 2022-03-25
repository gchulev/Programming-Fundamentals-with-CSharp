using System;
using System.Linq;
using System.Text;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder message = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                if (command.Contains("Move"))
                {
                    int numberOfElementsToMove = int.Parse(command.Split('|', StringSplitOptions.RemoveEmptyEntries)[1]);
                    string elementsToMove = string.Join("", message.ToString().Take(numberOfElementsToMove));

                    message.Remove(0, numberOfElementsToMove);
                    message.Append(elementsToMove);
                }
                else if (command.Contains("Insert"))
                {
                    int indexToInsertBefore = int.Parse(command.Split('|', StringSplitOptions.RemoveEmptyEntries)[1]);
                    string value = command.Split('|', StringSplitOptions.RemoveEmptyEntries)[2];

                    message.Insert(indexToInsertBefore, value);
                }
                else if (command.Contains("ChangeAll"))
                {
                    string substring = command.Split('|', StringSplitOptions.RemoveEmptyEntries)[1];
                    string replacement = command.Split('|', StringSplitOptions.RemoveEmptyEntries)[2];

                    message.Replace(substring, replacement);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
