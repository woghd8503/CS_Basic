using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _80_Generic_Stack
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());
        }
    }
}
