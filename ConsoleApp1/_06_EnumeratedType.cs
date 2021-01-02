using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _06_EnumeratedType
    {
        enum SEASON { Spring, Summer, Fall, Winter}
        static void Main(string[] args)
        {
            SEASON season;
            season = SEASON.Fall;
            Console.WriteLine(season);
            int Value = (int)season;
            Console.WriteLine(Value);
        }
    }
}

// 열거형은 상수를 한꺼번에 많이 사용할 때 사용합니다.
// C# 문법은 보다 엄격해져서 정수형을 변환할 때는 명시적으로 캐스팅이 필요합니다.