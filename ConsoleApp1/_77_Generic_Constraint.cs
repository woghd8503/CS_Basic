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