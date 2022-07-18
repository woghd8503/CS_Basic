using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _47_Constructor1
    {
        static void Main()
        {
            Student Kim = new Student("김가기", 25);
            Kim.Intro();
            Student Choi = new Student("최승우");
            Choi.Intro();
        }
    }

    class Student
    {
        private string Name;
        private int Age;
        public Student(string aName, int aAge): this(aName)
        {
            Age = aAge;
        }
        public Student(string aName)
        {
            Name = aName;
            Age = 1;
        }
        public void Intro()
        {
            Console.WriteLine("이름:" + Name);
            Console.WriteLine("나이:" + Age);

        }
    }
}

// 위의 예제는 생성자가 2개 있습니다.
// public Student(string aName, int aAge) : this(aName)
// 여기서 : this (aName) 는 다른 생성자를 호출하여 초기화하는 것입니다.

// Main에서 Student kim = new Student("김가기", 25); 코딩하면 매개변수가 일치하는 아래의
// 생성자가 호출되게 됩니다.
// public Student(string aName, int Age) : this(aName)
// { Name = aName; Age = 1; }
// 이 생성자의 호출이 완료된 후에 Age = aAge; 로 진행되게 됩니다.