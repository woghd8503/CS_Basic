using System;
using System.Collections.Generic;
using System.Text;


interface ICharacter
{
    void Move();
    void Attack();
    void Die();
}
class Warrior : ICharacter
{
    public void Move()
    { Console.WriteLine("전사 - 거침없이 쿵쿵쿵"); }
    public void Attack()
    { Console.WriteLine("전사 - 대검을 휙"); }
    public void Die()
    { Console.WriteLine("전사 - 으와악"); }
}

class Wizard : ICharacter
{
    public void Move()
    { Console.WriteLine("마법사 - 슈우욱 나른다"); }
    public void Attack()
    { Console.WriteLine("마법사 - 파이어볼"); }
    public void Die()
    { Console.WriteLine("마법사 - 아아악"); }
}

class Kight : ICharacter
{
    public void Move()
    {
        Console.WriteLine("기사 - 말타고 다가닥");
    }
    public void Attack()
    {
        Console.WriteLine("기사 - 창을 쉐엑");
    }
    public void Die()
    {
        Console.WriteLine("기사 - 으윽");
    }
}
class _64_Interface
{
    static void CharacterRun(params ICharacter[] ic)
    {
        for (int i = 0; i < ic.Length; i++)
        {
            ic[i].Attack();
            ic[i].Move();
            ic[i].Die();
        }
    }

    static void Main()
    {
        ICharacter[] arChar =
            { new Warrior(), new Wizard(), new Kight()};

        CharacterRun(ic);
    }
}


// 인터페이스 의미
// 우리는 상속에서 일반 클래스에서 virtual을 이용한 재정의와 abstract를 이용한 
// 추상 클래스를 제작하였습니다.

// 일반 클래스에서의 virtual 메서드는 미리 구현해 놓기는 했지만, 재정의 할 가능성이
// 있는 메서드는 물려받아 재정의 하라는 뜻에서 virtual로 선언하는 것이고, 
// abstract를 선언한 추상 메서드는 아직 구현하기 어려우니 선언만 해놓는다는 뜻입니다.

// 그런데 이러한 클래스 외에 인터페이스가 있습니다.
// 인터페이스는 모든 메서드를 구현하지 않은 상태에서 선언만 하는 것입니다.
// 즉, 기능은 미구현이고, 무엇을 구현해야하는 지는 미리 정의해놓은 것입니다.

// 추상 클래스의 모든 메서드를 추상 메서드로 선언하면 인터페이스와 동일하다고 볼 수 있습니다.

// 구현이 안 되어 있기 때문에 당연히 객체를 만들 수도 없고, 메모리에 올릴 수도 없습니다.

// 그리고 실제 사용하기 위해서는 반드시 상속을 받은 후에 정의를 해야 사용할 수 있습니다.
// 그렇다면 이러한 껍데기에 불과한 인터페이스를 왜 선언하고 사용할까요?

// 미리 답을 말씀드리면, 인터페이스는 약속입니다.
// 그러므로 첫째, 스펙을 작성한 것처럼 무엇을 구현해야 할 지에 대한 요구사항을 적어놓은 것입니다.
// 예를 들어, A회사는 구체적으로 업무를 진행 할 수 있습니다.

// 둘째, A회사는 인터페이스가 있기 때문에 미리 만들어져있다고 가정하고 인터페이스의 메서드를
// 호출하는 코드를 작성할 수 있습니다.

// 나중에 B회사가 클래스를 구현하면 인터페이스 변수에 인터페이스를 상속받은 클래스의 객체를
// 생성해서 전달하게 되면, 미리 작성된 인터페이스의 메서드는 전달된 객체의 메서드의 동작을 하게 됩니다.

// 셋째, 향후 새로운 클래스를 만들더라도 기존 소스에 연동하기 위해서 인터페이스의 상속을 받게 되면,
// 기존 소스의 수정없이 새로운 클래스의 객체를 만들어 전달하면 되므로 유지 보수가 편리합니다.

// 그래서 BCL의 많은 클래스들이 인터페이스를 매개로 하여 구현되어있고, 개발자는 해당 인터페이스를 상속
// 받아 구현하면 BCL에서는 약속에 따라 우리가 만든 메서드를 호출하게 됩니다. 설명은 하였으나
// 직접 소스를 통해서 구체적으로 알아보도록 하겠습니다.

// 또 다른 한가지는 C#에서 클래스는 다중 상속이 이루어지지 않습니다. 하지만 인터페이스는 
// 얼마든지 여러 개를 상속받아서 구현할 수 있습니다.