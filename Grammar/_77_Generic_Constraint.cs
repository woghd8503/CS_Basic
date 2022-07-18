using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Wrapper<T> where T : struct
    {
        T Value;
        public Wrapper() { Value = default(T); }
        public Wrapper(T aValue) { Value = aValue; }
        public T Data
        {
            get { return Value; }
            set { Value = value; }
        }
        public void OutValue()
        {
            Console.WriteLine(Value);
        }
    }
    class _77_Generic_Constraint
    {
        static void Main()
        {
            Wrapper<int> gi = new Wrapper<int>(1234);
            gi.OutValue();
            // Wrapper<string> gs =
            //                  new Wrapper<string>("문자열");
            // gs.OutValue();
        }
    }
}

// Generic는 인자로 제약조건을 걸 수 있습니다.
// 위는 인자로 구조체로만 제약을 했으모로 클래스인 string을 전달될 수 없습니다.

// where T : struct = T는 값 형식이어야 합니다.
// where T : class  = T는 참조 형식이어야 합니다.
// where T : new() = T는 반드리 매개 변수가 없는 생성자가 있어야 합니다.
// where T : 기반_클래스_이름 = T는 명시한 기반 클래스의 파생 클래스여야 합니다.
// where T : 인터페이스_이름 = T는 명시한 인터페이스를 반드시 구현해야 합니다. 인터페이스_이름에는 여러 개의
//                              인터페이스를 명시할 수도 있습니다.
// where T : U = T는 또 다른 형식 매개 변수U로부터 상속받은 클래스여야 합니다.