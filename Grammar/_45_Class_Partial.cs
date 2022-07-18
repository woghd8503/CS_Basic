using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _45_Class_Partial
    {
        static void Main()
        {
            Student Kim;
            Kim = new Student();
            Kim.Name = "홍길동";
            Kim.Age = 25;
            Kim.Intro();
        }
    }
    partial class Student
    {
        public int Age;
        public string Name;
    }
    partial class Student
    {
        public void Intro()
        {
            Console.WriteLine("이름:" + Name);
            Console.WriteLine("나이:" + Age);
        }
    }
}

// 위의 예제를 보면 partial class Student 가 2군데 존재하는 것이 보입니다.
// 이것은 class Student를 2군데에서 나눠서 구현하는 것입니다.
// 이 2군데에 나눠진 부분들은 컴파일시 1개의 클래스로 합쳐집니다.
// 이 문법은 필요에 의해서 의미적으로나 편의상 나눠서 보는 것이 더 좋겠다는 판단이 들 때
// 1개의 클래스를 여러 개로 나눠서 코딩하는 것입니다.
// 위에서는 필드와 메서드로 각각 나눠서 코딩을 하였습니다.