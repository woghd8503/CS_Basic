using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _94_LambadaExpression
    {
        static int Add(int a)
        {
            return a + 1;
        }
        static void Main()
        {
            int k = Add(3);
            Console.WriteLine("k = " + k);
        }
    }
}

// 위의 예제는 우리가 일반적으로 사용하는 메서드의 사용방식입니다.
// C#은 간단한 메서드인 경우 보다 쉬운 방법을 제공하겠습니다.