using System;

namespace _01._Black_Flag
{
    internal class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            double plunderPerDay = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double gatheredPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                gatheredPlunder += plunderPerDay;

                if (i % 3 == 0)
                {
                    gatheredPlunder += plunderPerDay * 0.5;
                }
                if (i % 5 == 0)
                {
                    gatheredPlunder -= gatheredPlunder * 0.3;
                }
            }

            double percentageGathered = (gatheredPlunder / expectedPlunder) * 100;

            if (gatheredPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {gatheredPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {percentageGathered:f2}% of the plunder.");
            }
        }
    }
}
