using System;

namespace _01._Experience_Gaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededExp = double.Parse(Console.ReadLine());
            int battlesCount = int.Parse(Console.ReadLine());
            double totalExpGained = 0;

            for (int i = 1; i <= battlesCount; i++)
            {
                double expGainedPerBattle = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    totalExpGained += expGainedPerBattle + expGainedPerBattle * 0.15;
                }
                else if (i % 5 == 0)
                {
                    totalExpGained += expGainedPerBattle - expGainedPerBattle * 0.10;
                }
                else if (i % 15 == 0)
                {
                    totalExpGained += expGainedPerBattle + expGainedPerBattle * 0.05;
                }
                else
                {
                    totalExpGained += expGainedPerBattle;
                }

                if (totalExpGained >= neededExp)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }
            }

            Console.WriteLine($"Player was not able to collect the needed experience, {neededExp - totalExpGained:f2} more needed.");
        }
    }
}
