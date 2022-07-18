using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _36_Defualt_Parameters
    {
        public static void PrintMessage(string m = "thank You", int n = 1)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(m);
            }
        }

        static void Main()
        {
            PrintMessage("Hello", 2);
            PrintMessage("Good Morning", 3);
            PrintMessage("Print Only once");
            PrintMessage();
        }
    }
}

// .NET 4.0 이전에는 디폴트 매개변수가 지원되지 않다가 4.0 부터 지원 되기 시작했습니다.