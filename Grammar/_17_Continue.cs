using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _17_Continue
    {
        static void Main()
        {
            int i = 0;
            int sum = 0;
            while (i < 100)
            {
                i++;
                if (i % 2 == 0)
                    continue;
                sum = sum + 1;
            }
            Console.WriteLine("1 ~ 100중에 홀수들의 합 = {0}", sum);
        }
    }
}

//  continue 반복문 안에서 특정한 값을 걸러낼 때 사용 