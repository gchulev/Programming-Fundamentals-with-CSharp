using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
                string username = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];

                if (cmd == "register")
                {
                    string licensePlate = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2];

                    if (!registeredUsers.ContainsKey(username))
                    {
                        registeredUsers.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registeredUsers[username]}");
                        continue;
                    }
                }
                else if (cmd == "unregister")
                {
                    if (!registeredUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registeredUsers.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var item in registeredUsers)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
