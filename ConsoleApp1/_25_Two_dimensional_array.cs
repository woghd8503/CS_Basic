using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _25_Two_dimensional_array
    {
        static void Main()
        {
            int[,] ar2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(ar2[i, j]);
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            foreach (int n in ar2)
            {
                Console.Write(n);
                Console.Write(", ");
            }
            Console.WriteLine();

            // 2차배열 가변적 배열 구현
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2, 3, 4 };
            arr[1] = new int[] { 5, 6 };
            arr[2] = new int[] { 7, 8, 9, 10, 11, 12 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                    Console.Write(", ");
                }
            }
        }
    }
}

// 위의 예제에서 첫번째 선언한 2차원 배열은 가로와 세로가 정해져있는 사각형 형태의 배열입니다.
// 그리고 아래의 2차원 배열은 행마다 가변적인 배열을 구현한 것입니다.
// C에서는 2차원 포인터를 선언한 후 포인터 배열을 동적할당하고 다시 포인터 배열마다 가변적으로 동적할당하여
// 동일하게 구현할 수 있습니다.
// C#은 보다 쉽게 가변 배열을 구현하고 있습니다.
