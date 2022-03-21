using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main()
        {
            string[] phrases = { @"Excellent product.", "Such a great product.", "I always use thatproduct.",
                                "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] autors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int n = int.Parse(Console.ReadLine());

            Random rng = new Random();

            for (int i = 0; i < n; i++)
            {
                string message = $"{phrases[rng.Next(phrases.Length)]} {events[rng.Next(events.Length)]} {autors[rng.Next(autors.Length)]} – {cities[rng.Next(cities.Length)]}.";
                Console.WriteLine(message);
            }
        }
    }
}
