using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _82_Pointer
    {
        static void Main()
        {
            int i = 3, j;
            unsafe
            {
                int* pi;
                pi = &i;
                j = *pi;
            }
            Console.WriteLine("i={0},j={1}", i, j);
        }
    }
}

// C#은 기본적으로 포인터의 접근을 권장하지 않습니다.
// 하지만 Windows API난 DLL과의 연동을 위해서 포인터를 사용해야 할 수도 있습니다.

// 또, C# 언어가 기존의 C, C++을 계승하였고, C, ++로 구현된 많은 강력한 기능을 외면할
// 수 없기에 특정 옵션을 통해서 포인터의 접근을 허용하고 있습니다.

// 포인터를 사용할 수는 없으나 아무래도 에러의 위험이 많기 때문에 주의해서 사용해야 합니다.