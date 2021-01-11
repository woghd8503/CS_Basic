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
