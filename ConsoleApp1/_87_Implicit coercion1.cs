using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _87_Implicit_coercion1
    {
        static  void Main()
        {
            int[] ar = { 1, 2, 3, 4, 5 };
            
            foreach(var i in ar)
            {
                Console.WriteLine(i);
            }
        }
    }
}

// var는 처음 선언 시 대입되는 값을 통해 컴파일러한테 판단을 맡기는 것이지 컴파일 되고
// 난 후에는 각각 int, int, string으로 형태가 정해지기 때문입니다.