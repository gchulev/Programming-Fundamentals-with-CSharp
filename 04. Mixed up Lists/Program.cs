using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> List3 = new List<int>();

            int elementsCount = 0;
            int rangeStart = 0;
            int rangeEnd = 0;


            if (list1.Count > list2.Count)
            {
                elementsCount = list2.Count;
                rangeStart = list1.TakeLast(2).ToList()[1] > list1.TakeLast(2).ToList()[0] ? list1.TakeLast(2).ToList()[0] : list1.TakeLast(2).ToList()[1];
                rangeEnd = list1.TakeLast(2).ToList()[1] > list1.TakeLast(2).ToList()[0] ? list1.TakeLast(2).ToList()[1] : list1.TakeLast(2).ToList()[0];
            }
            else
            {
                elementsCount = list1.Count;
                rangeStart = list2.Take(2).ToList()[1] > list2.Take(2).ToList()[0] ? list2.Take(2).ToList()[0] : list2.Take(2).ToList()[1];
                rangeEnd = list2.Take(2).ToList()[1] > list2.Take(2).ToList()[0] ? list2.Take(2).ToList()[1] : list2.Take(2).ToList()[0];
            }

            for (int i = 0; i < elementsCount; i++)
            {
                List3.Add(list1[i]);
                List3.Add(list2[list2.Count - 1 - i]);
            }

            for (int i = 0; i < List3.Count; i++)
            {
                if (!(List3[i] > rangeStart && List3[i] < rangeEnd))
                {
                    List3.Remove(List3[i]);
                    i--;
                }
            }

            List3.Sort();
            Console.WriteLine(string.Join(' ', List3));

        }
    }
}
