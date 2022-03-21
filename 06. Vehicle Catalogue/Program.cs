using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main()
        {
            List<Vehicles> vehicles = new List<Vehicles>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = $"{char.ToUpper(input[0][0])}{input[0].Substring(1)}";
                string model = $"{char.ToUpper(input[1][0])}{input[1].Substring(1)}";
                string colour = input[2];
                double horsePower = double.Parse(input[3]);

                vehicles.Add(new Vehicles { Type = type, Model = model, Colour = colour, HorsePower = horsePower });

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "Close the Catalogue")
            {

                foreach (Vehicles vehicle in vehicles.Where(q => q.Model == command).ToList())
                {
                    Console.WriteLine($"Type: {vehicle.Type}{Environment.NewLine}" +
                                      $"Model: {vehicle.Model}{Environment.NewLine}" +
                                      $"Color: {vehicle.Colour}{Environment.NewLine}" +
                                      $"Horsepower: {vehicle.HorsePower}");
                }

                command = Console.ReadLine();
            }

            int carsCount = vehicles.Where(x => x.Type == "Car").Count();
            double allCarsHP = 0;
            double avgHPofCars = 0;

            if (carsCount > 0)
            {
                allCarsHP = vehicles.Where(q => q.Type == "Car").Sum(x => x.HorsePower);
                avgHPofCars = allCarsHP / carsCount;
            }

            int trucksCount = vehicles.Where(x => x.Type == "Truck").Count();
            double allTrucksHP = 0;
            double avgHPofTrucks = 0;

            if (trucksCount > 0)
            {
                allTrucksHP = vehicles.Where(q => q.Type == "Truck").Sum(x => x.HorsePower);
                avgHPofTrucks = allTrucksHP / trucksCount;

            }

            Console.WriteLine($"Cars have average horsepower of: {avgHPofCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgHPofTrucks:f2}.");
        }
    }
    public class Vehicles
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public double HorsePower { get; set; }
    }
}
