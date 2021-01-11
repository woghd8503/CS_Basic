using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Base
    {
        public virtual void Message()
        {
            Console.WriteLine("Base Message");
        }
    }
    class Derived : Base
    {
        public override void Message()
        {
            base.Message();
            {
                Console.WriteLine("Derived Message");
            }
        }
    }
    class _59_Inheritance_virtual_override
    {
        static void Main()
        {
            Base B = new Base();
            Derived D = new Derived();
            B.Message();
            D.Message();
            Base B2 = D;
            B2.Message();
        }
    }
}

// Base 클래스로부터 상속을 받은 Derived 클래스는, Base의 클래스 변수에 Derived의 객체를 담을 수 있습니다.

// 위의 예제에서 Base B2 = D; 가 그것입니다.

// 그렇다면 B2.Message(); 처럼 호출한 메서드는 Base의 것일까요? 아니면 Derrived의 것일까요?

// 우리가 앞의 멤버 숨기기 예제처럼 정의하게 되면 이것은 부모의 Base Message가 호출되게 됩니다.
// 하지만 지금처럼 부모 메서드에는 virtual을 선언하고 자식 메서드는 override를 정의하게 되면, 
// 클래스 변수를 따르지 않고 대입한 객체의 매서드를 호출하게 됩니다.

// 이런 메서드를 "가상 메서드"라고 부릅니다.
// 이런 가상 메서드 문법을 이용해서 파생된 자식 객체들을 일괄적으로
// 부모의 변수에 담아서 관리할 수 있게 됩니다.

// 부모의 변수에 담았더라도 호출 시에는 전달된 객체에 따라 다른 메서드가 호출되므로 관리는
// 편리하고, 동작은 다양하게 이루어지게 됩니다.