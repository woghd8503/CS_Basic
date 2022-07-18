using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _21_String2
    {
        static void Main()
        {
            string str = "알파벳 : ";
            string str1 = "알파벳 : ";
            for (char c = 'a'; c <= 'z'; c++)
            {
                str += c;
            }
            Console.WriteLine(str);

            // z부터 역순으로 a까지 string에 대입 후 출력
            for(char b = 'z'; b >= 'a'; b--)
            {
                str1 += b;
            }
            Console.WriteLine(str1);
        }
    }
}

// string은 사용하기 매우 편리하지만 단점이 있습니다.
// 위처럼 str에 새로운 문자를 추가할 경우 C, C++처럼 배열의 공간에 하나씩
// 집어넣는 것이 아니라, 모든 문장을 완전히 새로운 메모리를 할당하게 됩니다.

// 즉, 최초에는 a를 할당하지만, 2번째는 ab, 3번째는 abc 이렇게 새로운 위치에 기존 문자열은
// 그대로 둔 상태에서 새로운 문자열을 할당하게 됩니다.

// 이런 일이 매우 빈번하게 일어나면 전체를 새로 할당해야 하므로 속도 저하가 일어나게 욉니다.
// 또한 기존에 할당되었던 문자열도 Garbage Collector에 의해서 해제되야 하는 부담도 생기게 됩니다.
// 그래서 이렇게 빈번하게 문자열을 변경하고 할당해야 하는 작업에서 성능을 높이려면 다른 클래스를 사용해야 합니다.