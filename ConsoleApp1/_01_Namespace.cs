using System;

namespace A
{
    class MyClass { int i; }
}
namespace B
{
    class MyClass { double d; }
}
namespace _3_Namespace
{
    class _01_Namespace
    {
        static void Main(string[] args)
        {
            A.MyClass objA = new A.MyClass();
            B.MyClass objB = new B.MyClass();
            Console.WriteLine(objA.ToString());
            Console.WriteLine(objB.ToString());
        }
    }
}

// 네임스페이스는 서로 다른 회사 혹은 팀, 개발자들이 개발 후에 합치는 과정에서 동일한 명치의 클래스가 존재할 때 구별을 
// 해야 하기 때문에 어는 한쪽이 기존 개발한 클래스의 이름을 변경해야 하는 불편한 점을 개선하기 위해 나온 문법입니다.

// 우리가 학교에 다녔을 때 1반과 2반에 김철수라는 동일한 이름을 가진 학생이 있다고 가정하겠습니다.
// 이 학생들을 선생님이 지칭할 때 이렇게 부릅니다.

// 1반 김철수 또는 2반 김철수, 김철수라는 이름만 가지고는 구별할 수 가 없기 때문에 상위 분류에 해당하는 반이 먼저 들어가는 것입니다.

// 네임스페이스도 이와 같습니다.

// MyClass라는 이름이 2개가 있기 때문에 namespace A, namespace B 이렇게 구분지어 놓으면 확실하게 구분을 할 수가 있습니다.

// 호출할 때도  A.MyClass, B.MyClass 처럼 호출하면 되겠습니다.