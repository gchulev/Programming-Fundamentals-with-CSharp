using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] currentCar = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string carMake = currentCar[0];
                int mileage = int.Parse(currentCar[1]);
                int fuel = int.Parse(currentCar[2]);

                cars.Add(new Car(carMake, mileage, fuel));
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                if (command.Contains("Drive"))
                {
                    string car = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[1];
                    int distance = int.Parse(command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[2]);
                    int fuel = int.Parse(command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[3]);

                    Car currentCar = cars.Find(x => x.CarMake == car);
                    if (currentCar.Carfuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        currentCar.Carfuel -= fuel;
                        currentCar.Mileage += distance;

                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if (currentCar.Mileage >= 100000)
                    {
                        cars.Remove(currentCar);
                        Console.WriteLine($"Time to sell the {currentCar.CarMake}!");
                    }
                }
                else if (command.Contains("Refuel"))
                {
                    string car = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[1];
                    int fuel = int.Parse(command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[2]);
                    Car currentCar = cars.Find(x => x.CarMake == car);
                    int fueledLiters = 0;

                    if (currentCar.Carfuel + fuel > 75)
                    {
                        fueledLiters = 75 - currentCar.Carfuel;
                        currentCar.Carfuel = 75;
                    }
                    else
                    {
                        fueledLiters = fuel;
                        currentCar.Carfuel += fuel;
                    }
                    Console.WriteLine($"{car} refueled with {fueledLiters} liters");
                }
                else if (command.Contains("Revert"))
                {
                    string car = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[1];
                    int kilometers = int.Parse(command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[2]);
                    Car currentCar = cars.Find(x => x.CarMake == car);

                    currentCar.Mileage -= kilometers;

                    if (currentCar.Mileage < 10000)
                    {
                        currentCar.Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }

                command = Console.ReadLine();
            }
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.CarMake} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Carfuel} lt.");
            }
        }
    }
    //The class is not in separate file due to the judge system of SoftUni....
    internal class Car
    {
        public Car(string carMake, int mileage, int currentFuel)
        {
            CarMake = carMake;
            Mileage = mileage;
            Carfuel = currentFuel;
        }
        public string CarMake { get; set; }
        public int Mileage { get; set; }
        public int Carfuel { get; set; }
    }
}
