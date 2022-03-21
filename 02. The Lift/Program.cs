using System;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main()
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int wagonCapacity = 4;

            for (int i = 0; i < wagons.Length; i++)
            {
                int currentCapacity = wagonCapacity - wagons[i];
                if (peopleWaiting >= currentCapacity)
                {
                    wagons[i] += currentCapacity;
                    peopleWaiting -= currentCapacity;

                }
                else
                {
                    wagons[i] += peopleWaiting;
                    peopleWaiting -= peopleWaiting;
                }
            }

            if (peopleWaiting == 0 && wagons.Sum() == wagons.Length * wagonCapacity)
            {
                Console.WriteLine(string.Join(' ', wagons));
            }
            else if (peopleWaiting == 0 && wagons.Sum() < wagons.Length * wagonCapacity)
            {
                Console.WriteLine($"The lift has empty spots!\n{string.Join(' ', wagons)}");
            }
            else if (peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!\n{string.Join(' ', wagons)}");
            }
        }
    }
}
