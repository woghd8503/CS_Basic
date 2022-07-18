using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _10_While
    { 
        static void Main()
        {
            int i = 1;
            int sum = 0;
            int sum1 = 0;
            while (i <= 100)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine("1부터 99까지의 합 = {0}", sum);

            for(int j =0; j <= 100; j++)
            {
                sum1 = sum1 + j;
            }
            Console.WriteLine("1부터 99까지의 합 = {0}", sum1);
        }
    }
}

// while은 여타 언어와 동일합니다.
// 다만 () 내의 데이터 형태가 형태가 bool이 되어야 합니다.
// while(1) 처럼 사용하는 것은 불가능합니다.