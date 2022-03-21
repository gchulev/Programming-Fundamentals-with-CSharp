using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugIndexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            //creating and populating the field the field with ladybugs
            int[] field = new int[fieldSize];


            foreach (int bugIndex in bugIndexes)
            {
                //checking if the current bug indes is inside the field boundries, if not it is ignored
                if (bugIndex >= 0 && bugIndex < fieldSize)
                {
                    field[bugIndex] = 1;
                }
            }

            while (command != "end")
            {
                int currentBugIndex = int.Parse(command.Split(' ')[0]);
                string direction = command.Split(' ')[1];
                int flightLength = int.Parse(command.Split(' ')[2]);

                //checking if the initial ladybug is outside the field or there is no ladybug in the provided field index
                if (currentBugIndex < 0 || currentBugIndex > field.Length - 1)
                {
                    //Do nothing
                }
                else
                {
                    //checking if there is a ladybug on the chosen possition
                    if (field[currentBugIndex] == 0)
                    {
                        //Do nothing
                    }
                    //there is ladybug in the chosen possition, the checks begin here
                    else
                    {
                        //positive flight direction
                        if (direction == "right" && flightLength > 0)
                        {
                            int landingIndex = currentBugIndex + flightLength;

                            //checking if the bug lands outside the field
                            if (landingIndex > field.Length - 1)
                            {
                                field[currentBugIndex] = 0;
                            }
                            //it lands in the field
                            else
                            {
                                //checking if ladybug can land on that index, if it can't then we loop to check the first possible landing possition or if it flies away from the field
                                if (field[landingIndex] == 1)
                                {
                                    for (int i = landingIndex; i < field.Length; i += flightLength)
                                    {
                                        if (field[i] == 0)
                                        {
                                            //finding the first landing spot and exiting the loop
                                            field[i] = 1;
                                            break;
                                        }
                                    }
                                    //ladybug flies out of this possition so it is empty = 0;
                                    //this line is hit even the first landin spot is hit, meaning we always set the initial possition to 0 since it flew away from it
                                    field[currentBugIndex] = 0;
                                }
                                else
                                {
                                    //ladybug lands  here
                                    field[landingIndex] = 1;
                                    field[currentBugIndex] = 0;
                                }
                            }
                        }
                        //negative flight direction (reverse)(going left)
                        else if (direction == "right" && flightLength < 0)
                        {
                            int landingIndex = currentBugIndex + flightLength;

                            //checking if ladybug lands outside the field
                            if (landingIndex < 0)
                            {
                                //it flies away from the field
                                field[currentBugIndex] = 0;
                            }
                            //lands somewhere in the field
                            else
                            {
                                //landing spot is taken, checkig for first available
                                if (field[landingIndex] == 1)
                                {
                                    for (int i = landingIndex; i >= 0; i -= Math.Abs(flightLength))
                                    {
                                        //if there is a spot to land
                                        if (field[i] == 0)
                                        {
                                            field[i] = 1;
                                            field[currentBugIndex] = 0;
                                            break;
                                        }
                                    }
                                    //flew away from the field
                                    field[currentBugIndex] = 0;
                                }
                                //landing in the field
                                else
                                {
                                    field[landingIndex] = 1;
                                    field[currentBugIndex] = 0;
                                }
                            }
                        }
                        //positive flight direction
                        else if (direction == "left" && flightLength > 0)
                        {
                            int landingIndex = currentBugIndex - flightLength;
                            //landed outside the field
                            if (landingIndex < 0)
                            {
                                field[currentBugIndex] = 0;
                            }
                            //landed inside the field
                            else
                            {
                                //checking if the landing spot is taken
                                if (field[landingIndex] == 1)
                                {
                                    for (int i = landingIndex; i >= 0; i-= flightLength)
                                    {
                                        if (field[i] == 0)
                                        {
                                            field[i] = 1;
                                            field[currentBugIndex] = 0;
                                            break;
                                        }
                                    }
                                    //flew outside the field
                                    field[currentBugIndex] = 0;
                                }
                                //landing in the field
                                else
                                {
                                    field[landingIndex] = 1;
                                    field[currentBugIndex] = 0;
                                }
                            }
                        }
                        //negative flight direction (reverse)
                        else if (direction == "left" && flightLength < 0)
                        {
                            int landingIndex = currentBugIndex + Math.Abs(flightLength);

                            //checking if landed outside the field
                            if (landingIndex > field.Length - 1)
                            {
                                field[currentBugIndex] = 0;
                            }
                            //landed inside the field
                            else
                            {
                                //checking if the landing spot is taken
                                if (field[landingIndex] == 1)
                                {
                                    for (int i = landingIndex; i < field.Length; i+= Math.Abs(flightLength))
                                    {
                                        if (field[i] == 0)
                                        {
                                            field[i] = 1;
                                            field[currentBugIndex] = 0;
                                            break;
                                        }
                                    }
                                    //flew outside the field
                                    field[currentBugIndex] = 0;
                                }
                                //landing in the field (landing spot not taken)
                                else
                                {
                                    field[landingIndex] = 1;
                                    field[currentBugIndex] = 0;
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            foreach (int possition in field)
            {
                Console.Write($"{possition} ");
            }
        }
    }
}
