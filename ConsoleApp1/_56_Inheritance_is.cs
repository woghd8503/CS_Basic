using System;
using System.Collections.Generic;
using System.Text;

namespace _56_Inheritance_is
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

    class CSTest
    {
        static void Eat(Animal A)
        {
            if (A is Cat || A is Dog)
            {
                Console.WriteLine("고기도 먹고, 국에 밥도 " + "말아 먹음");
            }
            else
            {
                Console.WriteLine("고기만 먹음");
            }
        }
        static void Main()
        {
            Animal[] ani = new Animal[10];
            ani[0] = new Cat();
            ani[1] = new Tiger();
            ani[2] = new Lion();
            ani[3] = new Dog();
            ani[4] = new Wolf();
            ani[5] = new Jindo();
            for (int i = 0; i <= 5; i++)
            {
                Eat(ani[i]);
            }
        }
    }
}

// is는 해당 클래스이가너 해당 클래스의 파생 클래스라면 true, 아니면 false를 리턴합니다.
// 이 문법을 통해서 전달 받은 객체의 종류를 확인 할 수 있습니다.