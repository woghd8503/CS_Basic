using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _27_Collection_HashTable
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("boy", "소년");
            ht.Add("girl", "소녀");
            ht["school"] = "학교";
            Console.WriteLine(ht["boy"]);
            Console.WriteLine(ht["girl"]);
        }
    }
}