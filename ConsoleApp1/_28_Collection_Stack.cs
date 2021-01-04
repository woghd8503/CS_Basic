using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _28_Collection_Stack
    {
        static void Main()
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);

            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
        }
    }
}
