using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Time
    {
        private class Int60
        {
            private int Integer;
            public Int60(int avalue) { Value = avalue; }
            public int Value
            {
                get { return Integer; }
                set { if (value >= 0 && value < 60) Integer = value; }
            }
        }
        private int hour;
        private Int60 min, sec;
        public Time(int aHour, int aMin, int aSec)
        {
            hour = aHour;
            min = new Int60(aMin);
            sec = new Int60(aSec);
        }
        public void OutTime()
        {
            Console.WriteLine("{0}시 {1}분 {2}초", hour, min.Value, sec.Value);
        }
    }

    class _52_InternalType
    {
        static void Main()
        {
            Time Now = new Time(12, 34, 56);
            Now.OutTime();
        }
    }
}

// 내부 타입은 클래스 내에 또 다른 클래스를 선언하여 사용하는 것을 말합니다.
// 다른 클래스에서 사용할 일이 없고 특정 클래스 전용이라면 외부에 클래스를 선언하기
// 보다는 내부에 선언하여 이 클래스에 어느 정도 종속적이라는 의도를 나타내는 것이 편할
// 수도 있습니다.

// 또 멤버를 클래스로 묶어놓았기 때문에 다른 멤버 보다 내부 클래스가 관리하기가 편리합니다.

// 내부 클래스도 private, protected가 아니라면 외부에서도 객체 생성하여 사용할 수도 있습니다.