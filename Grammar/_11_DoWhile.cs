using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _11_doWhile
    {
        static void Main()
        {
            string snum;
            int num;
            string pnum;
            int Pnum;
            do
            {
                Console.Write(
                    "숫자를 입력하세요(끝낼 때는 0) ");
                snum = Console.ReadLine();
                num = Convert.ToInt32(snum);
                Console.WriteLine(
                    "입력한 값은 {0}입니다.", num);
            } while (num != 0);

            do
            {
                Console.WriteLine("핸드폰 번호를 입력하세요 (끝내고 싶으면 7을 입력)");
                pnum = Console.ReadLine();
                Pnum = Convert.ToInt32(pnum);
                Console.WriteLine("입력하신 핸드폰 번호는 {0}", Pnum);
            } while (Pnum != 7);
        }
    }
}

// do 실행을 먼저하고 while 반복문 조건은 나중에 적는다.