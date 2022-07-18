using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    abstract class Animal
    {
        public abstract void Sound();
    }

    class Dog:Animal
    {
        public override void Sound()
        {
            Console.WriteLine("멍멍");
        }
    }
    class Cow:Animal
    {
        public override void Sound()
        {
            Console.WriteLine("음메");
        }
    }
    class Cat:Animal
    {
        public override void Sound()
        {
            Console.WriteLine("야옹");
        }
    }

    class _61_Abstract_Class
    {
        static void Main()
        {
            Animal A;
            A = new Dog(); A.Sound();
            A = new Cow(); A.Sound();
            A = new Cat(); A.Sound();
        }
    }
}

// 위 예제는 동물을 최상위 클래스로 해서 상속을 받아서 Sound() 메서드를 구현할 예제입니다.
// 그런데 최상위 클래스에는 abstract 키워드가 있고 Sound() 메서드의 내용은 구현되어 있지 않습니다.

// 이러한 클래스를 추상 클래스라고 부르고, Sound() 메서드는 추상 메서드라고 부릅니다.

// 이 추상 클래스를 사용하는 경우는 다음과 같습니다.
// Animal 클래스의 경우 소리를 규정할 수가 없습니다.

// 왜냐하면 Animal은 일반 명사이지 특정 개체를 지칭하는 명사는 아니기 때문에
// 일반적인 동물의 성격을 규정지을 수 있을 뿐 상세한 내용은 상속받은 자식 클래스에서 규정지을
// 수 있기 때문입니다.

// 이럴 경우 Animal을 추상 클래스로 만들고, 메서드는 추상 메서드로 만듭니다.
// 실질적인 구현은 어렵지만, 자식 클래스한테 미리 이것을 구현해야 한다는 것을 정해놓는 것과 같습니다.

// 그러면 자식 클래스는 overrride로 메서드를 선언하고 내용을 구현해야 합니다.
// 내용을 구현하지 않는다면 객체를 만들 수가 없습니다.

// 컴파일러가 구현되지 않은 부분 때문에 메모리에 얼만큼의 크기로 올려야 할지를 규정할 수 없기 때문입니다.

// 이러한 또 다른 예로, 라면을 들 수 있습니다.
// 라면은 일반 명사로서, 실제 상품을 규정짓기에는 부적합합니다.

// 라면의 공통적인 기능을 추츨해 라면 클래스를 추상 클래스로 만들고, 멤버를 면, 스프, 양념, 조리법
// 등등을 명칭만 규정 지어놓습니다.

// 그러면 이것을 상속받아서 신라면, 진라면, 짜파게티, 꼬꼬면 등등이 나오게 됩니다.

// 추상 클래스의 abstract 메서드 외에 일반 메서드도 제작할 수 있습니다.
// 추상 클래스는 기능을 구현해놓은 일반 메서드와 추상 메서드가 결합된 클래스라고 보면 되겠습니다.
// 미리 구현해 놓을 것은 미리 구현하고 자식이 구현할 것은 선언만 해놓고 물려주는 방식입니다.

// 1개의 추상메서드만 있어도 객체 생성이 되지 않는 것이 특징이입니다.