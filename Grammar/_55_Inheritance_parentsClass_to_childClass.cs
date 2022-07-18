using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Animal { }
    class Feline : Animal { }
    class Canine : Animal { }
    class Cat : Feline { }
    class Tiger : Feline { }
    class Lion : Feline { }
    class Dog : Canine { }
    class Wolf : Canine { }
    class Jindo : Dog { }
    class _55_Inheritance_parentsClass_to_childClass
    {
        static void Main()
        {
            Animal[] ani = new Animal[100];
            ani[0] = new Feline();
            ani[1] = new Canine();
            ani[2] = new Cat();
            ani[3] = new Tiger();
            ani[4] = new Lion();
            ani[5] = new Dog();
            ani[6] = new Wolf();
            ani[7] = new Jindo();
        }
    }
}

// 부모 클래스로부터 상속받은 자식 클래스는 모두 부모 클래스의 변수에 담을 수 있습니다.

// 위는 최상위 클래스인 Animal의 변수에 파생된 모든 클래스 객체를 담는 예제입니다.