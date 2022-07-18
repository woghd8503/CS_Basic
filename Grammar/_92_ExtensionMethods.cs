using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    public class Integer
    {
        public int a;
        public Integer(int aa) { a = aa; }
        public int Add(int b) { return a + b; }
        public int Mul(int b) { return a * b; }
        class _92_ExtensionMethods
        {
            static int Sub(Integer I, int b) { return I.a - b; }
            static int Div(Integer I, int b) { return I.a / b; }
            static void Main()
            {
                Integer Num = new Integer(10);
                Console.WriteLine("덧셈 : " + Num.Add(5));
                Console.WriteLine("곱셈 : " + Num.Mul(5));
                Console.WriteLine("뺄셈 : " + Sub(Num, 5));
                Console.WriteLine("나눗셈 : " + Div(Num, 5));
            }
        }
    }
}

// 이미 배포한 라이브러리내의 클래스의 메서드를 추가하는 방법은 새로운 라이버리를 배포하는 방법입니다.
// 하지만 이렇게 하기에는 많은 절차와 노력이 요구됩니다.
// C#에서는 보다 쉽게 클래스에 메서드를 추가하는 방법을 제공합니다.