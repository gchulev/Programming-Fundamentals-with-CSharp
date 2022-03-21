using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Take_Skip_Rope
{
    internal class Program
    {
        static void Main()
        {
            List<char> inputList = Console.ReadLine().ToList();

            List<int> numbersList = inputList.Where(x => char.IsDigit(x)).Select(x => x.ToString()).ToList().ConvertAll(int.Parse);
            List<string> nonNumbersList = inputList.Where(x => !char.IsDigit(x)).Select(c => c.ToString()).ToList();

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }

            List<string> result = new List<string>();
            int cursorPossition = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                int takeCount = takeList[i];
                int skipCount = skipList[i];

                if (takeCount > nonNumbersList.Count - cursorPossition)
                {
                    takeCount = nonNumbersList.Count - cursorPossition;
                }

                var rangeToAdd = nonNumbersList.GetRange(cursorPossition, takeCount);
                result.AddRange(rangeToAdd);

                cursorPossition += takeCount + skipCount;
            }

            Console.WriteLine(string.Join("", result.Select(x => x.ToString())));
        }
    }
}
