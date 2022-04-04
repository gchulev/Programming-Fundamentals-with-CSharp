using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main()
        {
            int[] key = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            while (input != "find")
            {
                int iteration = 1;
                int keyIndex = -1;
                for (int i = 0; i < input.Length; i++)
                {
                    if (i >= iteration * key.Length)
                    {
                        keyIndex = i - iteration * key.Length;
                        iteration++;
                    }
                    else
                    {
                        keyIndex++;
                    }
                    sb.Append((char)(input[i] - key[keyIndex]));
                }
                var test = sb.ToString().Split('&');
                var test2 = sb.ToString().Split(new char[] { '<', '>' });
                string treasureType = string.Join(string.Empty, sb.ToString().Split('&')[1]);
                string coordinates = string.Join(string.Empty, sb.ToString().Split(new char[] { '<', '>' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                Console.WriteLine($"Found {treasureType} at {coordinates}");
                sb.Clear();
                input = Console.ReadLine();
            }
        }
    }
}
