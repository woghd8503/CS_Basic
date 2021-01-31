using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Human
    {
        public Human(string aName, int aAge)
        {
            Name = aName;
            Age = aAge;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class _90_AnonymousType
    {
        static void Main()
        {
                Human Lee = new Human("이순신", 32);
                Console.WriteLine("이름 : " + Lee.Name + ", 나이 : " + Lee.Age);
        }
    }
}

// 위와 같은 간단한 클래스를 정의하기 위해서 여러 번 코딩을 해야 합니다.
// 프로그래머의 속성상 위의 코드를 줄이기 위한 시도를 하게 되는데, 재사용성이 없는 클래스의 경우는 위처럼
// 정의하기 보다는 익명 타입으로 만들 수도 있습니다.