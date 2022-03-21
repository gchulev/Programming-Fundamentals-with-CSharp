using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int elevatorTrips;

            if (people <= elevatorCapacity)
            {
                elevatorTrips = 1;
            }
            else
            {
                if (people % elevatorCapacity == 0)
                {
                    elevatorTrips = people / elevatorCapacity;
                }
                else
                {
                    elevatorTrips = (people / elevatorCapacity) + 1;
                }
            }

            Console.WriteLine(elevatorTrips);
        }
    }
}
