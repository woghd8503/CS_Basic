using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _84_NullType
    {
        public static void Main()
        {
            int? Age;
            Age = null;
            if(Age.HasValue)
            {
                Console.WriteLine(Age);
            }
            else
            {
                Console.WriteLine("알 수 없는 나이임");
            }
        }
    }
}

// null 가능 타입은 변수에 null을 허용하는 것입니다.
// 보통 C와 같은 프로그래밍 언어에서는 null과 0을 동일한 값으로 다룰 때가 많습니다.

// 하지만 엄밀히 따지면, null은 알 수 없다고 의미이고, 0은 숫자로 0을 의미합니다.
// 데이터베이스에서는 null과 0을 의미합니다.
// 월급을 null로 주면 월급 평균에서 배제시키게 되고, 0이라면 월급이 0이므로 평균을
// 집어 넣게 됩니다.
// 그러므로 결과값이 전혀 다르게 됩니다.
// 이렇게 프로그래밍상에서 null이 필요할 경우 C#에서는 null 가능 타입을 ?로 지정하게 하였습니다.