using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main()
        {
            List<int> inputList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                //swap the two elements
                if (command.Contains("swap"))
                {
                    string[] splitCommand = command.Split(' ').ToArray();
                    int firstIndex = int.Parse(splitCommand[1]);
                    int secondIndex = int.Parse(splitCommand[2]);

                    int firstElement = inputList[firstIndex];
                    int secondElement = inputList[secondIndex];

                    if (firstIndex < secondIndex)
                    {
                        inputList.RemoveAt(firstIndex);
                        inputList.Insert(firstIndex, secondElement);

                        inputList.RemoveAt(secondIndex);
                        inputList.Insert(secondIndex, firstElement);
                    }
                    else if (secondIndex < firstIndex)
                    {
                        inputList.RemoveAt(secondIndex);
                        inputList.Insert(secondIndex, firstElement);

                        inputList.RemoveAt(firstIndex);
                        inputList.Insert(firstIndex, secondElement);
                    }
                }
                //multiply
                else if (command.Contains("multiply"))
                {
                    string[] splitCommand = command.Split().ToArray();
                    int firstIndex = int.Parse(splitCommand[1]);
                    int secondIndex = int.Parse(splitCommand[2]);

                    int firstElement = inputList[firstIndex];
                    int secondElement = inputList[secondIndex];
                    int multiplication = firstElement * secondElement;

                    inputList.RemoveAt(firstIndex);
                    inputList.Insert(firstIndex, multiplication);
                }
                else if (command.Contains("decrease"))
                {
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        inputList[i]--;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", inputList));
        }
    }
}
