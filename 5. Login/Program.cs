using System;
using System.Linq;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            string pass = new string(userName.Reverse().ToArray());
            int badPassCntr = 0;

            for (int i = 1; i <= 4; i++)
            {

                string password = Console.ReadLine();

                if (password == pass)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    if (badPassCntr == 3)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                    Console.WriteLine($"Incorrect password. Try again.");
                    badPassCntr++;
                }
            }
        }
    }
}
