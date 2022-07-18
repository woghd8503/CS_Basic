using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CS_Bitcamp
{
    class _31_Collection_Stopwatch
    {
        static void Main()
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            for(int i = 0; i < 100000; i++)
            {
                Console.Write(i + ",");
            }
            st.Stop();
            Console.WriteLine("\n총 경과시간 = {0}", st.Elapsed);
        }
    }
}

//  Collection_Stopwatch compile 시간측정 