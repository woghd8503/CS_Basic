using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _83_Class_pointer
    {
        static void Main()
        {
            int[] ar = { 1, 2, 3, 4, 5 };
            unsafe
            {
                fixed (int* pi = &ar[0])
                {
                    for(int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(pi[i]);
                    }
                }
            }
        }
    }
}

// 구조체와 다르게 클래스는 Heap 메모리에 로딩됩니다. C#은 unsafe만으로 접근을 허용하지 않습니다.
// fixed라는 영역을 추가해서 CLR에게 메모리의 이동을 금지시켜야 합니다.
// CLR은 Garbage Collector에 의한 잦은 메모리 해제로 인한 조각 메모리를 없애기 위해 잦은 메모리 이동을
// 하게 됩니다.
// 하지만 위처럼 fixed는 이 영역에서의 메모리 이동을 막게 됩니다.