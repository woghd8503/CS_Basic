using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _88_initialiser
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class CSTest
    {
        static void Main()
        {
            _88_initialiser Jang = new _88_initialiser();
            Jang.Name = "장길산";
            Jang.Age = 32;
            Console.WriteLine("이름 : " + Jang.Name + ", 나이 : " + Jang.Age);
        }
    }
}

// 일반적으로 생성자를 통해 멤버의 초기화를 하게 됩니다.
// 생성자를 사용하지 않으면 public인 경우, 위처럼 값을 부여할 수도 있습니다.
// 이런 방법 외에 초기자라는 것을 C#은 제공하고 있습니다.