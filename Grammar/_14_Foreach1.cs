using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _14_Foreach1
    {
        static void Main(string[] args)
        {
            int[,] ar = { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach(int a in ar)
            {
                Console.Write(a);
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}

// 2차원 배열을 1개씩 접근할 때도 foreach 문을 사용하면 편리합니다.
// 이 외에도 인터페이스를 사용하면 foreach 문을 우리가 만든 클래스에서도 사용이 가능합니다. 