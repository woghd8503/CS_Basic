using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Base
    {
        public void Message()
        {
            Console.WriteLine("Base Message");
        }
    }
    class Derived : Base
    {
        new public void Message()
        {
            Console.WriteLine("Derived Message");
        }
    }
    class _57_Inheritance_hide_member
    {
        static void Main()
        {
            Base B = new Base();
            Derived D = new Derived();
            B.Message();
            D.Message();
            B = D;
            B.Message();
        }
    }
}
// Base 클래스의 멤버 메서드로 Message() 가 있습니다.
// 그런데 이 Base 클래스를 상속받는 Derived 클래스도 멤버 메서드로
// Message()메서드를 정의하고 있습니다.
// 상속을 받았기 때문에 이미 Message() 메서드는 포함되어 있을 것입니다.

// 그런데 이렇게 하면 어떻게 될까요?
// 이것은 부모가 물려준 Message()를 숨기고 내가 만든 것을 사용하겠다는 것입니다.

// 즉, 부모 클래스가 물려준 것은 그것이고, 내가 사용할 기능을 다르기 때문에 새로 만든 것입니다.
// 실행은 정상적으로 되는데 출력 창에는 warning 표시가 됩니다.
// 그러므로 보다 명시적으로 하기 위해서는 new를 붙여주는 warningr가 사라지게 됩니다.

// 만약 Derived의 메서드에서 Base의 Message()를 사용하고 싶으로 base.Message()를 호출하면 되겠습니다.