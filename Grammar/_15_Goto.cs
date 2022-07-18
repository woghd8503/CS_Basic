using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _15_Goto
    {
        static void Main()
        {
            int i = 1;
            int sum = 0;

        start:
            sum = sum + i;
            i++;
            if (i <= 100)
                goto start;
            Console.WriteLine("1~100까지의 합계 = {0}", sum);
        }
    }
}

// 반복문이 없었던 시설 사용했지만 계속사용할시 스파게티처럼 꼬일 수가 있다.