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
        public sealed override void Message()
        {
            Console.WriteLine("Derived Message");
        }
    }
    class Third : Derived
    {
        public new void Message()
        {
            Console.WriteLine("Third Message");
        }
    }
    class _62_Sealed_Method
    {
        static void Main()
        {
            Base B = new Base();
            Derived D = new Derived();
            Third T = new Third();
            B.Message();
            D.Message();
            T.Message();
        }
    }
}

// 봉인 메서드는 메서드 앞에 sealed 키워드를 붙여주게 되면 더 이상 virtual 메서드를 
// 재정의하게 허용하지 않겠다는 의미입니다.

// 이렇게 되면 이것을 상속받는 클래스는 override 할 수도 없고, 새로이 메서드를 정의하게 되면,
// 아무리 부모 클래스 변수에 자식 객체를 전달해서 호출하고자 하여도 가능하지 않게 됩니다.

// 프레임워크에서는 virtual 메서드를 이용해서 이미 만들어진 프레임워크에 우리가 만든 기능을 추가합니다.
// 그러나 프레임워크에서 sealed를 해버리면 해당 메서드는 더 이상 재정의가 불가능하므로 기존 
// 프레임워크에 우리의 기능을 결합시키는게 불가능하게 됩니다.

// 이런 sealed는 이미 만들어진 라이브러리, 클래스의 변경을 막기 위한 문법입니다.
