using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _45_Const_Member
    {
        class SEASON
        {
            public const string SPRING = "봄";
            public const string SUMMER = "여름";
            public const string FALL = "가을";
            public const string WINTER = "겨울";
        }

        class CSMain
        {
            static void Main(string[] args)
            {
                Console.WriteLine("{0}", SEASON.SPRING);
                Console.WriteLine("{0}", SEASON.SUMMER);
                Console.WriteLine("{0}", SEASON.FALL);
                Console.WriteLine("{0}", SEASON.WINTER);
            }
        }
    }
}

// const 키워드를 붙인 멤버는 상수 멤버가 됩니다.
// 상수 멤버의 특징은 한 번 값이 정해지면 바꿀 수 없다는 것입니다.
// 또 별도로 static을 붙이지 않아도 자동으로 정적 멤버가 됩니다.
// 그러므로 객체를 생성하지 않아도 호출이 가능합니다.