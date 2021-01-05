using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Time
    {
        private int hour, min, sec;
        public Time(int h, int m, int s) // 대문자로 시작하는 건 property
        { SetHour(h); SetMin(h); SetSec(s); }
        public int GetHour() { return hour; }
        public void SetHour(int aHour)
        { if (aHour < 24) hour = aHour; }
        public int GetMin() { return min; }
        public void SetMin(int aMin)
        { if (aMin < 60) min = aMin; }
        public int GetSec() { return sec; }
        public void SetSec(int aSec)
        { if (aSec < 60) sec = aSec; }
        public void OutTime()
        {
            Console.WriteLine("현재 시간은 {0}시 {1}분 {2}초이다.", hour, min, sec);
        }
    }
    class _37_Property
{
        static void Main()
        {
            Time Now;
            Now = new Time(12, 30, 45);
            Now.OutTime();
            Now.SetHour(55);
            Now.OutTime();
        }
    }
}

// 우리는 C++와 같은 객체지향 언어를 공부하면서 변수를 직접 외부에서 접근하게 하지 않고 함수를 통해서 접근하게
// 하는 것이 필요하다는 것을 공부했습니다.

// 변수를 직접 접근하게 허용하다 보면 이곳 저곳에서 변수의 값을 변경시킬 수 있는데 이런 과정에서 에러가 발생하면
// 찾는데 시간이 소요가 됩니다.

// 또 특정 변수는 값을 넣을 때 제약조건을 넣어서 값이 들어가지 못하도록 해야 에러가 발생하지 않습니다.
// 그래서 이런 작업을 아래처럼 하게 되면 전달되는 값에 의한 오류를 어느 정도 차단할 수 있게 됩니다.
// public void SetHour(int aHour)
// {if (aHour < 24) hour = aHour;}

// 그런데 MFC 라이브러리를 사용해서 프로그래밍을 하다보면, 변수에 값을 변경하는 작업과 동작에 관계된 작업을 모두
// 함수 처리하고 있습니다.

// 그러다보니 가독성이 있어서 값과 동작의 구분이 한눈에 보여지지 않습니다.
// 그래서 C#에서는 새로이 프로퍼티라는 문법으로 가독성을 높이려는 시도를 했습니다.
// 위의 예제를 수정하겠습니다.