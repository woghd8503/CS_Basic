using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
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
    class MiddleStudent
    {
        public Student S;
        protected int StNum;
        public MiddleStudent(string aName, int aAge, int aStNum)
        {
            StNum = aStNum;
            S = new Student(aName, aAge);
        }
        public void Intro()
        {
            S.Intro();
            Console.WriteLine("학번:" + StNum);
        }
        public void Study()
        {
            Console.WriteLine("나랏 말쌈이 듕귁에 달아...");
        }
    }
    class _54_Inheritance_has_a
    {
        static void Main()
        {
            MiddleStudent Hong;
            Hong = new MiddleStudent("홍길동", 21, 852311);
            Hong.Intro();
            Hong.Study();
        }
    }
}

// 상속은 부모 클래스의 기능을 손쉽게 물려 받을 수 있다는 장점이 있지만, 설계가 잘 되지 않아서 부모 클래스가 불필요한 기능을 많이 가지고
// 있다면, 물려받는 자식 클래스 또한 불필요한 기능을 많이 가지게 됩니다.

// 이런 모습은 프로그래밍 할 때 클래스의 정체성과 혼란을 가중시키는 역할을 합니다.
// 또 메모리에 불필요한 기능까지 로딩되기 때문에 성능의 저하도 일어나게 됩니다.

// 그러므로 상속을 할 때에는 객체간의 관계에 대한 이해와 그에 따른 설계가 전제되어야 한다고 하겠습니다.
// 그래서 특정 개발자들은 상속이 프레임워크를 만들 때 주로 사용하는 방법이고, 일반적인 기능 위주의 프로그램을 할 때는 포함관계를 추천합니다.

// 그렇다고 상속을 일반적인 프로그래밍에서 사용하지 않는 것은 아닙니다.
// 상속관계에 있는 클래스들은 부모 클래스로 대표하여 일관되게 관리 할 수 있다는 장점이 있으므로 잘 사용하면 효율적인 프로그래밍을 할 수 있게 됩니다.

// 포함은 클래스들간에 상속을 맺지 않고, 기능이 필요하다면 그러한 기능을 클래스로 만들어 놓고, 필요한 때마다 클래스의 멤버로 포함시켜서 
// 사용하는 방법입니다.

// 클래스의 관계가 2단계 밖에 되지 않으므로 잘못된 상속 관계에 복잡하게 얽힐 염려가 없습니다.
// 또 기능이 불필요하면 멤버 변수가 제거하면 되므로 편리합니다.

// 즉, 기본 클래스를 만들 때, 여기에 전화, 음악, 인터넷, 이미지, 동영상, 문자 전송 클래스, 이동 용이함 클래스를 멤버로 포함하면 휴대폰
// 이라고 하는 제품이 탄생하게 됩니다.

// 자연계의 사물 중에 사자는 고양이과이다를 is a 관계라고 하고 이것은 상속에 적합합니다.
// 경찰은 총을 가지고 있다 를 has a 관계라고 하며 이것은 포함관계에 적합하다고 볼 수 있습니다.