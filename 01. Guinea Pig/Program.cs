using System;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main()
        {
            float food = float.Parse(Console.ReadLine()) * 1000;
            float hay = float.Parse(Console.ReadLine()) * 1000;
            float cover = float.Parse(Console.ReadLine()) * 1000;
            float weight = float.Parse(Console.ReadLine()) * 1000;

            bool goToStore = false;

            for (int i = 1; i <= 30; i++)
            {
                food -= 300;

                if (food > 0 && hay > 0 && cover > 0)
                {
                    if (i % 2 == 0)
                    {
                        hay -= food * 0.05f;
                    }
                    if (i % 3 == 0)
                    {
                        cover -= weight / 3;
                    }
                }
                else
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    goToStore = true;
                    break;
                }
            }

            if (!goToStore)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food / 1000:f2}, Hay: {hay / 1000:f2}, Cover: {cover / 1000:f2}.");
            }
        }
    }
}
