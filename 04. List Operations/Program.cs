using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main()
        {
            List<int> inputList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command.Contains("Add"))
                {
                    int numberToAdd = int.Parse(command.Split()[1]);
                    inputList.Add(numberToAdd);
                }
                else if (command.Contains("Insert"))
                {
                    int numberToInsert = int.Parse(command.Split()[1]);
                    int indexToInsert = int.Parse(command.Split()[2]);

                    if (indexToInsert >= 0 && indexToInsert < inputList.Count)
                    {
                        inputList.Insert(indexToInsert, numberToInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command.Contains("Remove"))
                {
                    int indexToRemove = int.Parse(command.Split()[1]);

                    if (indexToRemove >= 0 && indexToRemove < inputList.Count)
                    {
                        inputList.RemoveAt(indexToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command.Contains("Shift"))
                {
                    if (command.Contains("left"))
                    {
                        int count = int.Parse(command.Split()[2]);

                        for (int i = 0; i < count; i++)
                        {
                            inputList.Add(inputList[0]);
                            inputList.Remove(inputList[0]);
                        }
                    }
                    else
                    {
                        int count = int.Parse(command.Split()[2]);

                        for (int i = 0; i < count; i++)
                        {
                            inputList.Insert(0, inputList[^1]);
                            inputList.RemoveAt(inputList.Count - 1);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ', inputList));
        }
    }
}
