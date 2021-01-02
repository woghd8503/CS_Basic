using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _12_for
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 9; i++)
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(
                        "{0} * {1} = {2}", i, j, i * j);
                }
            Console.WriteLine();

            for (int k = 9; k >= 2; k--)
            {
                for (int l = 2; l <= 9; l++)
                {
                    Console.WriteLine("{0} * {1} = {2}", k, l, k * l);
                }
                Console.WriteLine();
            }
        }
    }
}
