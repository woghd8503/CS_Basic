using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Student
    {
        static int StNum;
        private string Name;
        private int Age;
        static Student()
        {
            StNum = 0;
        }
        public static void StNumInfo()
        {
            Console.WriteLine("학생 수: {0}", StNum);
        }
        public Student(string aName, int aAge)
        {
            Name = aName;
            Age = aAge;
            StNum++;
        }
        public void Intro()
        {
            Console.WriteLine("이름: {0}", Name);
            Console.WriteLine("나이: {0}", Age);
        }
    }
    class _49_Static_member_variable
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("홍길동", 25);
            Student st2 = new Student("임꺽정", 25);
            Student st3 = new Student("장길산", 25);
            st1.Intro();
            st2.Intro();
            st3.Intro();
            Student.StNumInfo();
        }
    }
}

// 멤버 필드/메서드에 static 키워드를 부여한 것을 정적  멤버라고 합니다.
// 이 정적 멤버는 객체의 소속이 아니라 클래스의 소속입니다.
// C#은 정적 멤버는 명확히 Student.StNumInfo(); 처럼 호출하도록 했습니다.
// 일반 멤버는 객체를 통해서 접근하도록 했습니다.
// 코드를 읽을 때 명확히 구분하도록 한 것입니다.

// 정적 멤버는 객체가 생기기 전에 클래스 사용만으로도 메모리에 올라가게 됩니다.
// 그러므로 정적 멤버는 일반 생성자보다도 시간상으로 선행된다 하겠습니다.
// 그래서 정적 멤버를 초기화할 때는 정적 생성자를 만들어서 초기화하기도 합니다.

// 일반 메서드에서 정적 멤버를 호출하는 것은 가능합니다.
// 그러나 반대로 정적 메서드에서 일반 멤버를 호출하는 것은 불가능합니다.
// 이것은 시간적으로 메모리에 먼저 올라가는 시점을 생각해보면 매우 당연한 일입니다.

// 일반  메서드에서 정적 멤버를 호출할 수 잇는 것은 일반 멤버의 생성시에 
// 정적 멤버는 항상 메모리에 존재하기 때문입니다.

// 반대로 정적 메서드에서 일반 멤버를 호출할 수 없는 것은 정적 메서드가 메모리에
// 올라와있다고 해서 일반 멤버가 메모리에 올라와있다는 보장은 없기 때문입니다.

// 정적 멤버는 클래스 이름만으로도 사용가능하지만, 일반 멤버는 객체가 만들어지기
// 전에는 사용이 불가능합니다.