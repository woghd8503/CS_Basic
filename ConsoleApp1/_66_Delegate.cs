using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    delegate void dele(string s);
    class _66_Delegate
    {
        public static void m1(string s)
        { Console.WriteLine(s); }
        public void m2(string s)
        { Console.WriteLine(s); }
        static void Main()
        {
            dele d = m1;
            d("정적 메서드");
            _66_Delegate CS = new _66_Delegate();
            d = CS.m2;
            d("인스턴스 메서드");

            d = Outer.m3;
            d("외부 정적 메서드");
            Outer O = new Outer();
            d = O.m4;
            d("외부 인스턴스 메서드");
        }
    }
    class Outer
    {
        public static void m3(string s)
        { Console.WriteLine(s); }
        public void m4(string s)
        { Console.WriteLine(s); }
    }
}

// 델리게이트는 기본적인 용법이 C에서의 함수 포인터와 동일합니다.
// 함수 포인터는 함수를 지칭하여 함수의 매개변수를 통해서 리턴값과 매개변수는 동일하지만
// 기능은 다른 여러 함수를 전달할 수 있게 됨으로써 프로그램의 유연성을 높여줍니다.

// 또 함수 포인터는 포인터이므로 배열로 만들 수도 있어서 여러 함수를 일괄적으로 
// 저장하고 일괄적으로 동작시킬 수도 있어서 유용합니다.

// 델리게이트는 함수 포인터와 기본 용법이 동일하면서, 추가적으로 더 편리하게 사용할 수 있는
// 문법들을 가지고 있습니다.

// 예를 들어, 함수 포인터는 전역 함수만을 가리킬 수 있고, 객체의 멤버 함수는 별도의 함수 포인터를
// 선언해야 하지만 델리게이트는 정적 메서드나 멤버 메서드를 모두 대입만 하면 사용할 수 있습니다.

// 또 델리게이트는 여러 메서드를 1개의 델리게이트에 등록할 수 있으므로 등록된 델리게이트만 호출하여도
// 여러 개의 메서드를 동시에 호출할 수 있다는 장점이 있습니다.

// 