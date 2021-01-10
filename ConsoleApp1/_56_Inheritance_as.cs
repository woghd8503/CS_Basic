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
    class _56_Inheritance_as
    {
        static void Eat(Animal A)
        {
            Cat C = A as Cat;
            Dog D = A as Dog;
            if(C != null || D != null)
            {
                Console.WriteLine("고기도 먹고, 국에 밥도" + "말아 먹음");
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

            for(int i = 0; i <= 5; i++)
            {
                Eat(ani[i]);
            }
        }
    }
}

// as는 해당 클래스이거나 파생 클래스일 경우 직접 변환된 객체를 담게 됩니다.
// 만약 관련이 없는 클래스라면 null을 담게 담게 됩니다.