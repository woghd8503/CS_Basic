using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _44_Class
    {
        static void Main()
        {
            Student Kim;
            Kim = new Student();
            Kim.Name = "김길동";
            Kim.Age = 25;
            Kim.Intro();
        }
    }

    class Student
    {
        public string Name;
        public int Age;
        public void Intro()
        {
            Console.WriteLine("이름:" + Name);
            Console.WriteLine("나이:" + Age);
        }
    }
}

// C#에서의 클래스는 C++과 몇 가지 차이점이 있습니다.
// C++의 일반적으로 클래스의 선언부와 구현부를 별도로 나누는 경우가 많은데
// C#은 클래스의 선언부와 구현부를 별도로 나누지 않습니다. 
// 또 각 필드(변수), 메서드(함수)에 접근 제한자를 붙여줍니다.
// 접근 제한자를 붙이지 않으면 C++과 동일하게 private의 권한으로 설정됩니다.

// 클래스를 사용하는 방법은 Student kim; 처럼 객체를 생성해서 사용하면 되겠습니다.