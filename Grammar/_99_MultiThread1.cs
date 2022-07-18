using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Cs_Bitcamp
{
    class _99_MultiThread1
    {
        static void ThreadProc(object count)
        {
            for(int i = 0; i < (int)count; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            Console.WriteLine("작업 스레드 종료");
        }
        static void Main()
        {
            Thread T = new Thread(new ParameterizedThreadStart(ThreadProc));
            T.Start(5);
            for(; ; )
            {
                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.A)
                {
                    Console.Beep();
                }
                if(cki.Key == ConsoleKey.B)
                {
                    break;
                }
            }
            Console.WriteLine("주 스레드 종료");
        }
    }
}

// 스레드의 기타 기능
// Thread.Abort();는 동작중인 스레드 강제 종료합니다.
// Thread.Join()은 스레드가 종료될 때까지 대기하는 역할을 합니다.
// Thread.IsBackground = true이면 배경 스레드가 되어 주 스레드가 종료되면 함께 종료되고,
// false면 전경 스레드가 되어 주 스레드의 종료와 별개로 실행을 진행하게 됩니다.
// Thread.IsAlive는 스레드가 살아있는지, 종료되었는지를 확인할 수 있습니다.
// Thread.Priorit는 스레드의 우선순위를 지정할 수 있습니다.

// 스레드의 동기화
// 스레드를 동기화하기 위해서는 lock(변수) {}를 이용해서 하게 됩니다.
// 변수를 동시에 접근할 수 없으며 중괄호 영역을 1개의 스레드만 접근 하게 됩니다.
// 또 다른 방법으로 Monitor를 이용한 방법과 Mutex를 이용한 방법이 있습니다.
