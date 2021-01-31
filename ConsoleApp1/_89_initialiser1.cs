using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class _89_initialiser1
    {
        static void Main()
        {
            Human Jang = new Human { Name = "강길산", Age = 32 };
            Console.WriteLine("이름 : " + Jang.Name + ", 나이 : " + Jang.Age);
        }
    }
}
