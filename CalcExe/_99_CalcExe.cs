using System;
using System.Collections.Generic;
using System.Text;
using CalcLib;

namespace CalcExe
{
    class _99_CalcExe
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


