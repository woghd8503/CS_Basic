using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    delegate int dele(int a);
    class _95_LambadaExpression1
    {
        static void Main()
        {
            dele d = delegate (int a) { return a + 1; };
            int k = d(3);
            Console.WriteLine("k = " + k);
        }
    }
}

// 바로 익명 메서드라고 하는 방법입니다.
// 하지만 보다 축약시킬 수 있는 방법을 원했습니다.
// 이것은 메서드를 수식으로 표현하는 방식으로 람다식이라 불리우고 있습니다.