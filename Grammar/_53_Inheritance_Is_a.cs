using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Student
    {
        protected string Name;
        protected int Age;
        public Student(string aName, int aAge)
        {
            Name = aName;
            Age = aAge;
        }
        public virtual void Intro()
        {
            Console.WriteLine("이름:" + Name);
            Console.WriteLine("나이:" + Age);
        }
    }
    class MiddleStudent : Student
    {
        protected int StNum;
        public MiddleStudent(string aName, int aAge, int aStNum): base(aName, aAge)
        {
            StNum = aStNum;
        }
        public override void Intro()
        {
            base.Intro();
            Console.WriteLine("학번:" + StNum);
        }
        public void Study()
        {
            Console.WriteLine("나랏 말쌈이 듕귁에 달아...");
        }
    }
    class CSTest
    {
        static void Main()
        {
            MiddleStudent Jang;
            Jang = new MiddleStudent("장길산", 15, 901211);
            Jang.Intro();
            Jang.Study();
        }
    }
}

// 상속은 기존에 만들어진 클래스의 기능을 그대로 물려받음으로써 기존 기능은 수고 없이 재활용하고 추가할
// 기능만 작성하면 되는 것으로 객체지향 프로그래밍의 3대 속성 중에 하나입니다.

// 상속이 있음으로써 객체지향 프레임워크의 개발도 가능하게 되었습니다.
// 프레임워크에는 잘 설계된 객체지향 클래스들이 유기적으로 결합되어있고, 필요한 기본 기능은 
// 이미 프레임워크의 클래스들에 구현되어 있습니다.

// 상속을 받게 되면 별도로 수고를 들이지 않아도 기본 기능 그대로 사용할 수도 있고, 필요하면
// 일부를 수정함으로써 신속한 개발이 가능하게 되었습니다.

// 기본 클래스를 Base Class, Parent Class, Super Class라고 부르고, 상속 받은 클래스를 Derived Class, 
// Child Class, Sub Class라고 부릅니다.