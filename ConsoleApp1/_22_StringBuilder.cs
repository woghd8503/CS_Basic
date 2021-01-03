using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _22_StringBuilder
    {
        static void Main()
        {
            StringBuilder str =
                new StringBuilder("알파벳 : ", 40);
            for (char c = 'a'; c <= 'z'; c++)
            {
                str.Append(c);
            }
            str[10] = '_';
            Console.WriteLine(str);
        }
    }
}

// 빈번한 문자열의 연산을 하려면 StringBuilder를 사용해야 합니다.

// 이 클래스는 내부에 배열을 가지고 있어서, 전체를 새로 할당하지 않고 추가만 문자만 배열에 넣습니다.
// 그러므로 속도의 저하가 일어나지 않습니다.
// 초기에 40이라고 크기를 정해놓았지만 알아서 크기가 커지기 때문에 40문자 이상도 저장할 수 있습니다.