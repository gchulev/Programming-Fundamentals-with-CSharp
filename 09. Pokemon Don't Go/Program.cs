using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var removedElements = new List<int>();

            while (input.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    removedElements.Add(input[0]);
                    input = ShiftLeft(input);
                }
                else if (index > input.Count - 1)
                {
                    removedElements.Add(input[input.Count - 1]);
                    input = ShiftRight(input);
                }
                else
                {
                    int elmToRemove = input[index];

                    removedElements.Add(elmToRemove);
                    input.RemoveAt(index);

                    input = IncreaseDecreaseElm(elmToRemove, input);
                }
            }

            Console.WriteLine(removedElements.Sum());
        }

        private static List<int> IncreaseDecreaseElm(int removedElm, List<int> inputList)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] <= removedElm)
                {
                    inputList[i] += removedElm;
                }
                else
                {
                    inputList[i] -= removedElm;
                }
            }

            return inputList;
        }

        private static List<int> ShiftLeft(List<int> inputList)
        {
            int elmToRemove = inputList[0];
            int lastElm = inputList[inputList.Count - 1];

            inputList.RemoveAt(0);
            inputList.Insert(0, lastElm);

            var outputList = IncreaseDecreaseElm(elmToRemove, inputList);

            return outputList;
        }

        private static List<int> ShiftRight(List<int> inputList)
        {
            int elmToRemove = inputList[inputList.Count - 1];
            int firstElm = inputList[0];

            inputList.RemoveAt(inputList.Count - 1);
            inputList.Add(firstElm);

            var outputList = IncreaseDecreaseElm(elmToRemove, inputList);

            return outputList;
        }
    }
}
