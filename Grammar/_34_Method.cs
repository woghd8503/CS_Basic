using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _34_Method
    {
        static public int TotalSum(int from, int to)
        {
            int sum = 0;
            for (int i = from; i <= to; i++)
            {
                sum += i;
            }
            return sum;

        }
        static void Main()
        {
            Console.WriteLine("1 ~ 100의 합계 = {0}", TotalSum(1, 100));
        }
    }
}

// C#에서는 함수를 메서드라고 호칭합니다.
// 메서드 앞에 static 키워드를 붙여주면 객체를 생성할 필요가 없는 메서드이며 Main과 TotalSum은 모두
// _34_Method 클래스의 소속이므로 Main에서 바로 TotalSum을 호출합니다.

// 만약 다른 클래스에서 TotalSum을 호출하려면, _34_Method.TotalSum으로 호출해야 합니다.