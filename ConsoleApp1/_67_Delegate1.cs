using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _67_Delegate1
    {
        public static int Add(int a, int b)
        { return a + b; }
        public static int Sub(int a, int b)
        { return a - b; }
        public static int Mul(int a, int b)
        { return a * b; }
        public static int Div(int a, int b)
        { return a * b; }
        static void Main()
        {
            int num1, num2;
            int o;
            Console.WriteLine("Input Num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Number (1:+, 2:-, 3:*, 4:/)");
            o = Convert.ToInt32(Console.ReadLine());
            switch(o)
            {
                case 1:
                    Console.WriteLine("Result => {0}", Add(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("Result => {0}", Sub(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("Result => {0}", Mul(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("Result => {0}", Div(num1, num2));
                    break;
            }
        }
    }
}

// 이 예제는 2개의 값을 입력받고 선택한 번호에 따라 사칙연산을 한 후 표시하는 예제입니다.

// 그런데 사칙연산하는 메서드의 형태가 동일합니다.
// 이럴 때는 switch ~ case 문 대시 델리게이트 배열을 이용해서 사용할 수 있습니다.
// 다음은 델리게이트 배열을 이용해서 동일하게 처리한 예제입니다.