using System;
using System.Collections.Generic;
using System.Text;
using CalcLib;

namespace CalcExe
{
    class IntDoubleCal : IntCalc
    {
        public static double AddD(double a, double b) { return a + b; }
        public static double SubD(double a, double b) { return a - b; }
        public static double MulD(double a, double b) { return a * b; }
        public static double DivD(double a, double b) { return a / b; }

    }
    class _99_DLL_Class_Inheritance
    {
        static void Main(string[] args)
        {
            int num1 = 20, num2 = 50;
            int result = 0;
            result = IntDoubleCal.Add(num1, num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
            result = IntDoubleCal.Sub(num1, num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
            result = IntDoubleCal.Mul(num1, num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
            result = IntDoubleCal.Div(num1, num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            double dnum1 = 20.3, dnum2 = 50.5;
            double dresult = 0;
            dresult = IntDoubleCal.AddD(dnum1, dnum2);
            Console.WriteLine("{0} + {1} = {2}", dnum1, dnum2, result);
            dresult = IntDoubleCal.SubD(dnum1, dnum2);
            Console.WriteLine("{0} - {1} = {2}", dnum1, dnum2, result);
            dresult = IntDoubleCal.MulD(dnum1, dnum2);
            Console.WriteLine("{0} * {1} = {2}", dnum1, dnum2, result);
            dresult = IntDoubleCal.DivD(dnum1, dnum2);
            Console.WriteLine("{0} / {1} = {2}", dnum1, dnum2, result);
        }
    }
}
