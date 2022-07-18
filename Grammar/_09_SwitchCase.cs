using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _09_switchCase
    {
        static void Main()
        {
            Console.Write("원하시는 숫자를 입력하세요 :");
            string j = Console.ReadLine();
            int i = Convert.ToInt32(j);


            Console.WriteLine(i);
            switch (i)
            {
                case 1:
                    Console.WriteLine("하나");
                    break;
                case 2:
                    Console.WriteLine("둘");
                    break;
                case 3:
                    Console.WriteLine("셋");
                    break;
                default:
                    Console.WriteLine("그 외의 숫자");
                    break;
            }

            // String version
            Console.WriteLine();
            Console.WriteLine("한글로 숫자를 입력하세요:");
            string k = Console.ReadLine();

            switch (k)
            {
                case "하나":
                    Console.WriteLine("하나");
                    break;
                case "둘":
                    Console.WriteLine("둘");
                    break;
                case "셋":
                    Console.WriteLine("셋");
                    break;
                default:
                    Console.WriteLine("그 외의 숫자");
                    break;
            }
        }
    }
}
// 일반적인 switch ~ case의 용법입니다.
// C#은 문법을 강화해서 break;를 생략하는 실수를 예방하기 위해서 Error 처리를 합니다.
// C#에서는 문자열도 switch  ~ case에서 사용가능합니다.
