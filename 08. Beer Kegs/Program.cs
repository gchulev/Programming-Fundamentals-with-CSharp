using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegNum = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double highestVolume = 0;

            for (int i = 0; i < kegNum; i++)
            {
                string kegModel = Console.ReadLine();
                float KegRadius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(KegRadius, 2) * height;

                if (highestVolume <= volume)
                {
                    highestVolume = volume;
                    biggestKeg = kegModel;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
