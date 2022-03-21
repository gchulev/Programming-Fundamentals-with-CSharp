using System;
using System.Linq;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main()
        {
            string test = "@mix#tix3dj#poOl##loOp#wl@@bong&song%4very$long@thong#Part##traP##@@leveL@@Level@##car#rac##tu@pack@@ckap@#rr#sAw##wAs#r#@w1r";

            var result = test.Split(new char[] { '#', '@' },StringSplitOptions.RemoveEmptyEntries);

        }
    }
}
