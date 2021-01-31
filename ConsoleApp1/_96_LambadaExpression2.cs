using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    delegate int dele(int a);
    class _96_LambadaExpression2
    {
        static void Main()
        {
            dele d = a => a + 1;
            int k = d(3);
            Console.WriteLine("k = " + k);
        }
    }
}

// a => a + 1; 에서 왼쪽의 a는 메서드에 전달되는 인자입니다.
// 그리고 오른쪽의 a+1은 return 값입니다.
// 그리고 이렇게 정의된 표현식은 메서드가 되어 delegate의 변수에 담겨서 사용되게 됩니다.