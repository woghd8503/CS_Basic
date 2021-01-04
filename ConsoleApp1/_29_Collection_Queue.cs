using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _29_Collection_Queue
    {
        static void Main()
        {
            Queue qu = new Queue();
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);

            Console.WriteLine(qu.Dequeue());
            Console.WriteLine(qu.Dequeue());
            Console.WriteLine(qu.Dequeue());
        }
    }
}
