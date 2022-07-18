using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    delegate int IntCalc(int a, int b);
    class _70_Delegate2
    {
        public delegate void SendProg(int nFile);
        public static void SendPacket(int nFile, SendProg Prog)
        {
            for (int i = 0; i < nFile; i++)
            {
                Prog(i);
                System.Threading.Thread.Sleep(500);
            }
        }
    }

    class CSTest
    {
        public static void Progress(int nFile)
        {
            Console.WriteLine("{0}번째 패킷을 전송중...", nFile + 1);
        }
        public static void EngProgress(int nFile)
        {
            Console.WriteLine("Now Sending {0} Packet.Wait please", nFile + 1);
        }
        static void Main()
        {
            _70_Delegate2.SendPacket(10, EngProgress);
            Console.WriteLine("모든 패킷을 전송했습니다.");
        }
    }
}
