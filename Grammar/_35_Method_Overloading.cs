using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _35_Method_Overloading
    {
        public static int Add(int a, int b)
        { return a + b; }
        public static double Add(double a, double b)
        { return a + b; }
        public static string Add(string a, string b)
        { return a + b; }
        static void Main()
        {
            Console.WriteLine("{0} + {1}는 {2}입니다.", 1, 2, Add(1, 2));
            Console.WriteLine("{0} + {1}는 {2}입니다.", 1.2, 3.4, Add(1.2, 3.4));
            string a = "아름다운";
            string b = "우리나라";
            Console.WriteLine("{0} + {1}는 {2}입니다.", a, b, Add(a, b));
        }
    }
}

// 메서드의 오버로딩을 지원하고 있습니다.
// 컴파일러는 절달된 인자를 통해서 알맞은 메서드를 호출합니다.