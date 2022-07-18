using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _78_GenericList
    {
        static void Main()
        {
        List<int> list = new List<int>();
        for(int i = 0; i < 5; i++)
            list.Add(i);

            foreach(int element in list)
            Console.Write("{0}", element);
            Console.WriteLine();
            list.RemoveAt(2);
        }
    }
}
