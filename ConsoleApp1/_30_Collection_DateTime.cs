using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _30_Collection_DateTime
    {
        static void Main()
        {
            DateTime A = new DateTime(2020, 1, 4);
            DateTime B = new DateTime(2016, 05, 31);
            TimeSpan C = A - B; // 2개간의 시간을 측정
            Console.WriteLine(C);

            A = new DateTime(2020, 1, 4);
            C = new TimeSpan(100, 0, 0, 0); // 100일 후
            B = A + C;
            Console.WriteLine(B);
        }
    }
}

// Collection_DateTime 날짜계산