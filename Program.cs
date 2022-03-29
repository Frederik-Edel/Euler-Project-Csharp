using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace src
{
    class Program
    {

        static void Main()
        {
            for (long i = 2; i < 1000001; i++)
            {
                collatz(i);
                if (chainLen > chainMax)
                {
                    chainMax = chainLen;
                    chainMaxPos = i;
                }
                chainLen = 0;
            }
            Console.Write(chainMax + ", " + chainMaxPos);
        }
        static long chainLen = 0, chainMax = 1, chainMaxPos = 0;
        static long collatz(long i)
        {
            if (i == 1)
                return 1;
            chainLen++;
            if (i % 2 == 0)
                return collatz(i / 2);
            if (i % 2 != 0)
                return collatz(3 * i + 1);
            return 1;
        }
    }
}