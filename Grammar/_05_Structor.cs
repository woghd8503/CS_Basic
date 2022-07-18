using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _05_Structor
    {
        static void Main(string[] args)
        {
            // Student b("홍길동", 902521); // Error
            Student b = new Student("홍길동", 902521, 3.4f);
            b.OutInfo();
        }
    }
    struct Student
    {
        public string Name;
        public int StNum;
        public float Score;
        public Student(string aName, int aStNum, float aScore)
        {
            Name = aName;
            StNum = aStNum;
            Score = aScore;
        }
        public void OutInfo()
        {
            Console.WriteLine("{0}, {1}, {2}", Name, StNum, Score);
        }
    }
}

// 구조체 역시 생성자를 비롯한 메서드의 사용이 가능합니다.
// 생성자를 사용할 때는 아래와 같이 사용합니다.
// Student b = new Studnet("홍길동", 902521)

// Student b = new Student("홍길동", 902521);
// 위처럼 사용했다고 해서 힙에 메모리가 할당되는 것은 아닙니다.
// 구조체는 항상 스택에 할당되며 위와 같은 형식은 생성자를 사용하기 위해서 제공되는 형식일 뿐입니다.