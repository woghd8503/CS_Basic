using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _16_Break
    {
        static void Main()
        {
            int i = 1;
            int sum = 0;
            while (i < 100)
            {
                sum = sum + i;
                if (i >= 50)
                    break;
                i++;
            }
            Console.WriteLine("1부터 {0} 까지의 합 = {1}", i, sum);
        }
    }
}

// break문을 사용해 반복문 중간에 탈출을 할 수 있다. 