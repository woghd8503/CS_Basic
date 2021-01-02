using System;
using System.Collections.Generic;
using System.Text;
using A;
//using B;

namespace A
{
    class MyClass { int i; }
}

namespace B
{
    class MyClass { int d; }
}

namespace _3_Namespace
{
    class _2_Using
    {
        static void Main(string[] args)
        {
            MyClass objA = new MyClass();
            B.MyClass objB = new B.MyClass();
            Console.WriteLine(objA.ToString());
            Console.WriteLine(objB.ToString());
        }
    }
}

// 네임스페이스 앞에 using을 붙여서 소스의 시작 위치에 선언하면 컴파일러는 해당 네임스페이스를 통해 클래스를
// 호출하는 것을 직접 클래스를 호출 가능하게 처리합니다.

// 이것은 "이 네임스페이스 아래의 함수나 클래스는 자주 사용하므로 이 클래스를 그냥 쓰더라도 알아서 이 네임스페이스
// 아래 있을 것으로 알아라"하는 통보입니다.

// 그러나 위의 A와 B처럼 2개의 네임스페이스가 동일한 이름의 클래스를 사용하려고 하면 위처럼 1개만 생략가능하고
// 나머지는네임스페이스를 통해 호출해야 컴파일해야 2개 클래스 모두 사용할 수 있습니다.