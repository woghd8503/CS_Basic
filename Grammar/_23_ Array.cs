using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _23__Array
    {
        static void Main()
        {
            int[] ar;
            ar = new int[5];
            for(int a = 0; a < 5; a++)
            {
                ar[a] = a * 2;
            }
            for(int b = 0; b < 5; b++)
            {
                Console.WriteLine(ar[b]);
            }
        }
    }
}

// C#의 배열은 System.Array 클래스를 상속받게 됩니다.
// 그러므로 클래스라고 할 수 있습니다.
// 사용법은 C, C++과 유사하지만 클래스이기 때문에 메서드를 가지고 있습니다.
// 그래서 보다 편리하게 사용할 수 있습니다.