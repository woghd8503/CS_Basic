using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _86_Implicit_coercion
    {
        static void Main()
        {
            var x = 10;
            var y = 5;
            var str = "문자열";

            Console.SetCursorPosition(x, y);
            Console.WriteLine(str);
        }
    }
}

// 암묵적 타입은 var 로 사용합니다.
// 이것은 대입될 때 전달되는 값으로 컴파일러가 어떤 자료형인지 판단 하는 것입니다.
// 그렇다고 위에서 사용한 x, y, str이 var 타입이라고 말할 수는 없습니다.

// var는 처음 선언 시 대입되는 값을 통해 컴파일러한테 판단을 맡기는 것이지 컴파일 되고
// 난 후에는 각각 int, int, string으로 형태가 정해지기 때문입니다.