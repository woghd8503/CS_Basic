using System;
using System.Collections; // 추가해야 됨
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _26_Collection_ArrayList
    {
        static void Main()
        {
            ArrayList ar = new ArrayList(10);
            ar.Add(1);
            ar.Add(2.34);
            ar.Add("string");
            ar.Add(new DateTime(2021, 1, 4));
            ar.Insert(1, 1234);

            foreach(object o in ar)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine("개수 : " + ar.Count);
            Console.WriteLine("용량 : " + ar.Capacity);
        }
    }
}
