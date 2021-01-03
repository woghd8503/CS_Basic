using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _24_Array1
    {
        static void Main()
        {
            int[] arScore = { 89, 58, 92, 77, 66, 80 };
            Console.Write("정렬전 => ");
            for(int i = 0; i < arScore.Length; i++)
            {
                Console.Write(arScore[i]);
                Console.Write(' ');
            }
            Array.Sort(arScore);
            Array.Reverse(arScore);
            Console.WriteLine();
            Console.Write("정렬후 => ");
            for(int i = 0; i < arScore.Length; i++)
            {
                Console.Write(arScore[i]);
                Console.Write(' ');
            }
        }
    }
}

// Array.Sort()는 정렬, Array.Reverse()는 배열순서가 뒤집어짐.