using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main()
        {
            List<string> sequence = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            int movesCntr = 0;

            while (command != "end")
            {
                if (sequence.Count > 0)
                {
                    movesCntr++;

                    int indexOne = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray()[0]);
                    int indexTwo = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray()[1]);

                    if (indexOne == indexTwo || indexOne < 0 || indexOne > sequence.Count - 1 || indexTwo < 0 || indexTwo > sequence.Count - 1)
                    {
                        int indexToAdd = sequence.Count / 2;

                        sequence.Insert(indexToAdd, $"-{movesCntr}a");
                        sequence.Insert(indexToAdd, $"-{movesCntr}a");

                        Console.WriteLine("Invalid input! Adding additional elements to the board");
                    }
                    else
                    {
                        if (sequence[indexOne] == sequence[indexTwo])
                        {
                            string matchingElement = sequence[indexOne];

                            if (indexOne < indexTwo)
                            {
                                sequence.RemoveAt(indexOne);
                                sequence.RemoveAt(indexTwo - 1);
                            }
                            else
                            {
                                sequence.RemoveAt(indexTwo);
                                sequence.RemoveAt(indexOne - 1);
                            }

                            Console.WriteLine($"Congrats! You have found matching elements - {matchingElement}!");
                        }
                        else 
                        {
                            Console.WriteLine("Try again!");
                        }
                    }
                }

                command = Console.ReadLine();
            }

            if (sequence.Count > 0)
            {
                Console.WriteLine($"Sorry you lose :(\n{string.Join(' ', sequence)}");
            }
            else
            {
                Console.WriteLine($"You have won in {movesCntr} turns!");
            }
        }
    }
}
