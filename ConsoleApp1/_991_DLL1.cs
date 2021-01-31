using System;
using CalcLib;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{ 
    class _991_DLL1
    {
        static void Main(string[] args)
        {
            int num1 = 20, num2 = 50;
            int result = 0;
            result = IntCalc.Add(num1, num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
            result = IntCalc.Sub(num1, num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
            result = IntCalc.Mul(num1, num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
            result = IntCalc.Div(num1, num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
        }
    }
}

// using CalcLib; 로 네임스페이스를 사용하겠다고 선언합니다.
// 그리고는 바로 클래스와 메서드를 사용하면 됩니다.