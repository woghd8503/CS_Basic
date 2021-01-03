using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _19_String
    {
        static void Main()
        {
            string str1;
            str1 = "문자열";
            Console.WriteLine(str1);
            string str2 = "C# String";
            Console.WriteLine(str2);
            string str3;
            str3 = str1 + str2;
            Console.WriteLine(str3);
        }
    }
}

// C#에서 문자열은 string 클래스를 사용합니다.
// 연산자 오버로딩도 되어 있으므로 매우 직관적으로 편리하게 사용할 수 있습니다.