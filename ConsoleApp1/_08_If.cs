using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _08_If
    {
        static void Main(string[] args)
        {
            Console.WriteLine("원하시는 숫자를 입력하세요: ");

            string j = Console.ReadLine();
            int i = Convert.ToInt32(j);

            if (i % 2 == 0)
                Console.WriteLine("i는 짝수 입니다.");
            else
                Console.WriteLine("i는 홀수 입니다.");
        }
    }
}

// if문의 용법은 동일하지만 C#의 문법이 보다 엄격해져서 ()이 반드시 bool형이 되야 합니다.
// C,C++은 0은 False, 1은 True로 인식되지만 C#은 에러가 발생됩니다.
// 혹시 모를 실수를 예방하기 위함입니다.