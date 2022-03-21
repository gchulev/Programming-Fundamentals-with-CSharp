using System;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('\\').ToArray();
            string fileName = input[input.Length - 1].Split('.')[0];
            string fileExtension = input[input.Length - 1].Split('.')[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
