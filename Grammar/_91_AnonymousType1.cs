using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _91_AnonymousType1
    {
        static void Main()
        {
            var Lee = new { Name = "이순신", Age = 32 };
            Console.WriteLine("이름 : " + Lee.Name + ", 나이 : " + Lee.Age);
        }
    }
}

// 이처럼 즉석에서 클래스를 초기자를 이용해서 구성하며, new를 통해 생성한 후 var로 받아주게
// 되면 우리가 따로 클래스를 구성하지는 않았지만 내부적으로 클래스로 생성되는 익명 타입 클래스가 
// 생기게 됩니다.