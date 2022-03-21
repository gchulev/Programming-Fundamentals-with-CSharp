using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;

            while ((command = Console.ReadLine()) != "3:1")
            {
                if (command.Contains("merge"))
                {
                    int startIndex = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                    int endIndex = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);

                    if (startIndex >= 0 && startIndex <= input.Count - 1 && endIndex >= 0 && endIndex <= input.Count - 1)
                    {
                        input = MergeByIndexes(startIndex, endIndex, input);
                    }
                    else if (startIndex < 0 && endIndex >= 0 && endIndex <= input.Count - 1)
                    {
                        startIndex = 0;
                        input = MergeByIndexes(startIndex, endIndex, input);
                    }
                    else if (startIndex >= 0 && startIndex <= input.Count - 1 && endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                        input = MergeByIndexes(startIndex, endIndex, input);
                    }
                    else if (startIndex < 0 && endIndex > input.Count - 1)
                    {
                        startIndex = 0;
                        endIndex = input.Count - 1;

                        input = MergeByIndexes(startIndex, endIndex, input);
                    }
                }
                else if (command.Contains("divide"))
                {
                    int index = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                    int partitionsNum = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);

                    if (partitionsNum == 0)
                    {
                        partitionsNum = 1;
                    }

                    input = DivideByIndex(index, partitionsNum, input);
                }
            }

            Console.WriteLine(string.Join(' ', input));
        }

        static List<string> DivideByIndex(int index, int partitionsNum, List<string> inputList)
        {
            string element = inputList[index];
            int elementsLength = element.Length / partitionsNum;
            var dividedList = new List<string>();
            int iterationsCounter = 1;

            for (int i = 0; i < element.Length; i += elementsLength)
            {
                if (iterationsCounter == partitionsNum)
                {
                    dividedList.Add(element.Substring(i));
                    break;
                }
                else
                {
                    if (elementsLength > 0)
                    {
                        dividedList.Add(element.Substring(i, elementsLength));
                    }
                }
                iterationsCounter++;
            }

            inputList.RemoveAt(index);
            inputList.InsertRange(index, dividedList);

            return inputList;
        }

        static List<string> MergeByIndexes(int startIndex, int endIndex, List<string> inputList)
        {
            var tempString = new StringBuilder();
            int indexesCount = (endIndex - startIndex) + 1;

            for (int i = startIndex; i <= endIndex; i++)
            {
                tempString.Append(inputList[i]);
            }

            inputList.RemoveRange(startIndex, indexesCount);
            inputList.Insert(startIndex, tempString.ToString());
            return inputList;
        }
    }
}
