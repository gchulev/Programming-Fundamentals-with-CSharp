using System;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var bombAndPower = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int sum = 0;

            while (nums.Contains(bombAndPower[0]))
            {
                int bombNum = bombAndPower[0];
                int bombPower = bombAndPower[1];
                int bombIndex = nums.IndexOf(bombNum);

                int startDetonationIdx = bombIndex - bombPower;

                if (startDetonationIdx < 0)
                {
                    startDetonationIdx = 0;
                }
                //detonating left side
                for (int i = startDetonationIdx; i < bombIndex; i++)
                {
                    nums.RemoveAt(i--);
                    bombIndex--;
                }
                //detonating right side
                startDetonationIdx = nums.IndexOf(bombNum);
                int endDetonationIdx = startDetonationIdx + bombPower;

                if (endDetonationIdx > nums.Count - 1)
                {
                    endDetonationIdx = nums.Count - 1;
                }

                for (int i = startDetonationIdx; i <= endDetonationIdx; i++)
                {
                    nums.RemoveAt(i--);
                    endDetonationIdx--;
                }
                sum = nums.Sum();
            }

            Console.WriteLine(sum);
        }
    }
}
