using System;

namespace _01_The_Biscuit_Factory
{
    internal class Program
    {
        static void Main()
        {
            int workerPerDayProduction = int.Parse(Console.ReadLine());
            int worksersCount = int.Parse(Console.ReadLine());
            int competingFactoryBiscuits = int.Parse(Console.ReadLine());

            int totalBiscuitsProd = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    totalBiscuitsProd += (int)Math.Floor((workerPerDayProduction - (workerPerDayProduction * 0.25))) * worksersCount;
                }
                else
                {
                    totalBiscuitsProd += workerPerDayProduction * worksersCount;
                }
            }
            double absoluteDiff = Math.Abs(totalBiscuitsProd - competingFactoryBiscuits);
            //double avgValue = (totalBiscuitsProd + competingFactoryBiscuits) / 2;
            double percentageDiff = (absoluteDiff / competingFactoryBiscuits) * 100;

            if (totalBiscuitsProd > competingFactoryBiscuits)
            {
                Console.WriteLine($"You produce {percentageDiff:f2} percent more biscuits.");
            }
            else if (totalBiscuitsProd < competingFactoryBiscuits)
            {
                Console.WriteLine($"You produce {percentageDiff:f2} percent less biscuits.");
            }
            Console.WriteLine($"You have produced {totalBiscuitsProd} biscuits for the past month.");
        }
    }
}
