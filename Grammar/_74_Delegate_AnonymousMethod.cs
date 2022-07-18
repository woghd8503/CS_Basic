using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    delegate int dele(int a, int b);
    class _74_Delegate_AnonymousMethod
    {
        static void Main()
        {
            dele d = delegate (int a, int b)
            { return a + b; };
            int k = d(2, 3);
            Console.WriteLine(k);
        }
    }
}

// 원래 delegate에는 메서드가 전달되어야 합니다.
// 하지만 재사용성의 가능성이 없으며, 단순한 위와 같은 메서드는 굳이 
// 구현하기보다는 위처럼 바로 delegate에 전달합니다.
// 이와 같은 것을 익명메서드라고 합니다.