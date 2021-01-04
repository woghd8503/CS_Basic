using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CS_Bitcamp
{
    class _32_Collection_Random
    {
        static void Main()
        {
            Random R = new Random();
            for(int i = 0; i < 1000; i++)
            {
                Console.CursorLeft = R.Next(80);
                Console.CursorTop = R.Next(24);
                Console.Write('*');
                Thread.Sleep(10);
            }
        }
    }
}

// Collection_Random 난수로 여러군데 * 출력