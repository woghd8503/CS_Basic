using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    struct Student
    {
        public string Name;
        public int StNum;
    }
    class _04_Stucture
    {
        static void Main(string[] args)
        {
            Student b;
            b.Name = "홍길동";
            b.StNum = 902252;
            Console.WriteLine("{0}, {1}", b.Name, b.StNum);
        }
    }
}

// C#에서의 구조체는 상속이 되지 않습니다.
// C#에서 상속이 필요하면 class를 사용하면 됩니다.
// 구조체는 데이터의 집합 용도로만 사용합니다.
