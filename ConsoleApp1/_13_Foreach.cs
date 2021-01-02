using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _13_Foreach
    {
        static void Main(string[] args)
        {
            int[] ar = { 33, 22, 11, 99, 88 };
            int Max = 0;
            int Min = 0;

            foreach (int a in ar)
            {
                if (Max < a)
                    Max = a;
            }
            Console.WriteLine("가장 큰 값은 {0}", Max);

            foreach (int b in ar)
            {
                if (Min > b)
                    Min = b;
            }
            Console.WriteLine("가장 작은 값은 {0}", Min);
        }
    }
}

// for문은 가장 많이 사용하는 방식은 처음부터 끝까지 순서대로 호출하는 것입니다.
// foreach문은 처음부터 1개씩 순서대로 호출합니다.