using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    internal class Program
    {
        static void Main()
        {
            List<int> inputList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command.Split()[0] == "Delete")
                {
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] == int.Parse(command.Split()[1]))
                        {
                            inputList.Remove(int.Parse(command.Split()[1]));
                        }
                    }
                }
                else if (command.Split()[0] == "Insert")
                {
                    int item = int.Parse(command.Split()[1]);
                    int possition = int.Parse(command.Split()[2]);
                    inputList.Insert(possition, item);
                }
            }

            Console.WriteLine(string.Join(' ', inputList));
        }
    }
}
