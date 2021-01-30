using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class WrapperInt
    {
        int Value;
        public WrapperInt() { Value = 0; }
        public WrapperInt(int aValue) { Value = aValue; }
        public int Data
        {
            get { return Value; }
            set { Value = value; }
        }
        public void OutValue()
        {
            Console.WriteLine(Value);
        }
    }

    class WrapperString
    {
        string Value;
        public WrapperString() { Value = null; }
        public WrapperString(string aValue) { Value = aValue; }
        public string Data
        {
            get { return Value; }
            set { Value = value; }
        }
        public void OutValue()
        {
            Console.WriteLine(Value);
        }
    }
    class _75_Generic
    {
        static void Main()
        {
            WrapperInt gi = new WrapperInt(1234);
            gi.OutValue();
            WrapperString gs = new WrapperString("문자열");
            gs.OutValue();
        }

    }

}

// 국내에서는 제너릭 프로그래밍이라는 말을 일반화 프로그래밍이라는 말로 번역하기도 합니다.
// 하지만 어떤 사람은 이런 말보다는 총괄적인 프로그래밍이라는 말이 더 어울린다고 얘기하기도 합니다.

// 하지만 어떤 사람은 이런 말보다는 총괄적인 프로그래밍이라는 말이 더 어울린다고 얘기하기도 합니다.
// 제너릭은 C++의 템플릿 프로그래밍과 동일한 문법입니다.

// 논리가 동일하되 자료형이 다른 경우 우리는 제너릭의 대표 이름으로 코드를 만들면 컴파일시 전달되는
// 자료형으로 코드가 알아서 생성되게 됩니다.

// 특히 자료구조와 같은 여러 자료형이 전달되지만 논리는 동일한 구현일 경우 제너릭 프로그래밍이 매우
// 유용합니다.