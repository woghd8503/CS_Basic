using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Time
    {
        private int hour, min, sec;
        public Time(int h, int m, int s)
        { hour = h; min = m; sec = s; }
        public int Hour
        {
            get { return hour; }
            set { if (value < 24) hour = value; }
        }
        public int Min
        {
            get { return min; }
            set { if (value < 60) min = value; }
        }
        public int Sec
        {
            get { return sec; }
            set { if (value < 60) min = value; }
        }
        public void OutTime()
        {
            Console.WriteLine("현재 시간은 {0}시 {1}분 {2}초이다.", Hour, Min, Sec);
        }
    }
    class _38_Property1
    {
        static void Main()
        {
            Time Now;
            Now = new Time(12, 30, 45);
            Now.OutTime();
            Now.Hour = 55;
            Now.OutTime();
        }
    }
}

// 프로퍼티의 모양을 보심면 get, set이 있다는 것을 알 수 있습니다.
// 이것이 이전 예제의 함수에 대응되는 문법입니다.

// Set { if (value < 24) hour = value; } 처럼 value 는 Main에서 Now.Hour = 55; 할 때 대입 연산자를
// 통해서 전달되는 값입니다.

// Main에서 값을 대입할 때 Now.Hour = 55; 처럼 처리하고 있는 부분은 독성에 있어서 이전 함수를 사용하던 
// 방식과 다르게 한 눈에도 값을 설정하려고 하는 의도를 알 수가 있습니다.

// 마치 내부에 프로퍼티가 있지 않고 변수에 직접 값을 넣는 것과 동일하게 보입니다.

// 프로퍼티는 컴파일 될 때 내부적으로 메서드로 생성이 됩니다.
// 하지만 우리가 코딩 시 사용할 때는 변수처럼 사용합니다.
// 프로퍼티는 유지보수의 장점과 가독성을 모두 얻고자 하는 문법이라 하겠습니다.