using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Character
    {
        public virtual void Move()
        {
            Console.WriteLine("이동한다");
        }
        public virtual void Attack()
        {
            Console.WriteLine("공격한다");
        }
        public virtual void Die()
        {
            Console.WriteLine("죽는다");
        }
    }

    class Warrior : Character
    {
        public override void Move()
        {
            Console.WriteLine("전사 - 거침없이 쿵쿵쿵");
        }
        public override void Attack()
        {
            Console.WriteLine("전사 - 대검을 휙");
        }
        public override void Die()
        {
            Console.WriteLine("전사 - 으와악");
        }
    }

    class Wizard : Character
    {
        public override void Move()
        {
            Console.WriteLine("마법사 - 슈우욱 나른다");
        }
        public override void Attack()
        {
            Console.WriteLine("마법사 - 파이어볼");
        }
        public override void Die()
        {
            Console.WriteLine("마법사 - 아아악");
        }
    }

    class Kinght : Character
    {
        public override void Move()
        {
            Console.WriteLine("기사 - 말타고 다가닥");
        }
        public override void Attack()
        {
            Console.WriteLine("기사 - 창을 쉐엑");
        }
        public override void Die()
        {
            Console.WriteLine("기사 - 으윽");
        }
    }
    class _60_Polymorphism
    {
        static void Main()
        {
            Character[] arChar =
                { new Warrior(), new Wizard(), new Kinght() };
            for(int i = 0; i < arChar.Length; i++)
            {
                arChar[i].Move();
            }
            for(int i = 0; i < arChar.Length; i++)
            {
                arChar[i].Attack();
            }
            for(int i = 0; i < arChar.Length; i++)
            {
                arChar[i].Die();
            }
        }
    }
}

// virtual과 override를 사용해서 메서드를 만들면 부모 클래스 변수에 자식 객체를 담아서 부모 클래스 변수로
// 호출한다고 해도, 대입된 자식 객체의 메서드가 호출됩니다.

// 그러므로 관리는 부모 클래스 변수 배열로 일괄적으로 할 수 있지만 동작은 각 객체별로
// 이루어지기 때문에 매우 편리한 프로그램을 만들 수 있습니다.