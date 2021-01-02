using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _03_Boxing_Unboxing
    {
        static void Main(string[] args)
        {
            int i = 1234;
            object box = i;
            Console.WriteLine(box);
            int j = (int)box;
            Console.WriteLine(j);

            double d = 3.14;
            object box1 = d;
            Console.WriteLine(box1);
            double d1 = (double)box1;
            Console.WriteLine(d1);
        }
    }
}

// 위에서 int인 1234는 object의 상속을 받았으므로 변환이 가능하지만,
// 내부적으로는 값 타입과 참조 타입이라는 차이가 있으므로 object에 담을 때 1234의 값은 힙에 옮겨지고 이것을
// 가리키는 Hash Value가 box에 담기게 됩니다.

// 이것을 Boxing이라고 합니다. 즉, 상자에 포장해서 옮기는 것과 유사하다는 의미입니다.

// 다시 object 형식을 int 형식으로 담을 때는 힙 메모리에 존재하는 것을 스택으로 옮겨야 합니다.

// 이것이 상자에 포장되어 있던 것을 풀러서 둔다는 것과 유사하다는 의미로 Unboxing이라고 합니다.

// object는 모든 데이터 형식을 받을 수 있어서 편리하지만, 특히 값 타입과의 대입 연산은 Boxing/Unboxing이
// 일어나므로 성능 저하가 발생된다고 하겠습니다.

// 그래서 컬렉션은 일반 컬렉션보다는 제너릭 컬렉션을 보다 권장하고 있습니다.