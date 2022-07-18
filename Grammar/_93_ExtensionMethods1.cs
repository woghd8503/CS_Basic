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
    }

    public static class IntegerExt
    {
        public static int Sub(this Integer I, int b)
        {
            return I.a - b;
        }
        public static int Div(this Integer I, int b)
        {
            return I.a / b;
        }
    }
    class _93_ExtensionMethods1
    {
        static void Main()
        {
            Integer Num = new Integer(10);
            Console.WriteLine("덧셈 : " + Num.Add(5));
            Console.WriteLine("곱셈 : " + Num.Mul(5));
            Console.WriteLine("뺄셈 : " + Num.Sub(5));
            Console.WriteLine("나눗셈 : " + Num.Div(5));
        }
    }
}

// 엄밀히 따지면 클래스내에 메서드를 추가하는 것은 아니고, 사용을 객체를 통해서
// 멤버 메서드와 동일하게 사용하게 함으로써 마치 클래스의 멤버가 추가된 것처럼 보이는 문법입니다.

// 라이브러리를 배포하는 방법말고는 별도의 메서드를 포함시켜서 사용해야 하는데, 아무래도 사용할 때 
// 동일하게 보이지 않습니다.

// 그러나 위처럼 static 클래스와 static 메서드를 선언하고, this Integer I 처럼 첫번째 인자와 this라는
// 키워드와 클래스의 변수를 선언하게 되면 마치 객체를 통해서 메서드를 호출하는 것처럼 사용할 수 있습니다.
// 이렇게 해서 자연스러운 기능의 추가와 가독성을 향상시킬 수 있게됩니다.
