using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _46_Constructor
    {
        static void Main()
        {
            Student kim;
            kim = new Student("김가기", 25);
            kim.Intro();
        }
    }

    class Student
    {
        private string Name;
        private int Age;
        public Student(string aName, int aAge)
        {
            Name = aName;
            Age = aAge;
        }
        public void Intro()
        {
            Console.WriteLine("이름:" + Name);
            Console.WriteLine("나이:" + Age);
        }
    }
}

// 생성자는 객체가 처음 만들어질 때 호출되는 메서드입니다.
// 클래스의 이름과 동일하며 생성자를 따로 만들지 않으면 Default 생성자가 내부적으로 만들어지게 됩니다.
// 사람도 아침에 기상을 할 때 기지개를 펴고, 세수와 양치질등을 하며 하루 일과 준비를 하곤 합니다.

// 이처럼 객체가 사전에 준비해야 할 작업이 있다면 이 메서드를 이용해서 하면 되겠습니다.

// 컴퓨터로 따지면 부팅되는 과정에 해당하는 부분이라 보겠습니다.

// 생성자로 메서드이므로 여러 개의 생성자를 가질 수 있습니다.
// 즉, 생성자 오버로딩이 가능합니다.