using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Archive
    {
        public delegate bool SendProg(int nFile);
        public static bool SendPacket(int nFiles, SendProg Prog)
        {
            for (int i = 0; i < nFiles; i++)
            {
                if (Prog(i) == false)
                {
                    return false;
                }
                System.Threading.Thread.Sleep(500);
            }
            return true;
        }
    }
    class _71_Delegate3
    {
        public static bool Progress(int nFile)
        {
            Console.WriteLine("{0}번째 패킷 전송중...(취소시 Esc).", nFile + 1);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo cki;
                cki = Console.ReadKey(false);
                if (cki.Key == ConsoleKey.Escape)
                {
                    return false;
                }
            }
                return true;
        }
        static void Main()
        {
            if (Archive.SendPacket(10, Progress) == true)
            {
                Console.WriteLine("모든 패킷을 전송했습니다.");
            }
            else
            {
                Console.WriteLine("취소되었습니다.");
            }
        }
    }
}

// 이것은 패킷을 전송중에 언제라도 중단시킬 수 있는 기능을 주기 위해 델리게이트를
// 사용한 예입니다.