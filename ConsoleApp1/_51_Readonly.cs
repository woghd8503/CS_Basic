using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _51_Readonly
    {
        static void Main()
        {
            Kingdom Korea;
            Korea = new Kingdom("왕건", 45, 2500);
            Korea.Intro();
            Kingdom Josun;
            Josun = new Kingdom("이성계", 52, 30000);
            Josun.Intro();
        }
    }
    class Human
    {
        private string Name;
        private int Age;
        public Human(string aName, int aAge)
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

    class Kingdom
    {
        readonly private Human King;
        private int Vassal;
        public Kingdom(string aName, int aAge, int aVassal)
        {
            King = new Human(aName, aAge);
            Vassal = aVassal;
        }
        public void Intro()
        {
            Console.WriteLine("왕은?");
            King.Intro();
            Console.WriteLine("신하:{0}명", Vassal);
        }
    }
}

// const는 프로그래밍 시 정해놓은 값을 변경할 수 없습니다.
// 일단 변수는 항상 값이 변합니다.
// 이에 객체를 생성 시에 한번 정하면 이후에는 바뀔 수 없도록 하는 중간 역할을 하는 멤버가 요구되었습니다.

// 이것이 readonly 키워드를 부여한 멤버입니다.
// 이것은 생성자에서 처음 초기화할 수 있고 이후에는 바꿀 수가 없습니다.

// 이렇게 사용하면 const 상수에 비해 객체마다 다른 값을 부여할 수 있는 유연성과 이후로는 바뀔 수
// 없기 때문에 에러를 방지할 수 있는 장점을 가지게 됩니다.