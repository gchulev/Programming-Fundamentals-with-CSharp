using System;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().ToString().Split(' ');
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string firstItem = inputArr[0];

                for (int j = 0; j < inputArr.Length; j++)
                {
                    if (j < inputArr.Length - 1)
                    {
                        inputArr[j] = inputArr[j + 1];
                    }
                }

                inputArr[inputArr.Length - 1] = firstItem;
            }

            Console.WriteLine(string.Join(" ", inputArr));
        }
    }
}
