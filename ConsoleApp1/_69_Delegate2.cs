using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _69_Delegate2
    {
        public static void SendPacket(int nFile)
        {
            for (int i = 0; i < nFile; i++)
            {
                Console.WriteLine("{0}번째 패킷을 전송중...", i + 1);
                System.Threading.Thread.Sleep(500);
            }
        }
    }

    class CSTest
    {
        static void Main()
        {
            _69_Delegate2.SendPacket(10);
            Console.WriteLine("모든 패킷을 전송했습니다.");
        }
    }
}

// 이 프로그램을 한글과 영문을 지원하는 유연성을 주기 위해 델리게이트를 사용하겠습니다.