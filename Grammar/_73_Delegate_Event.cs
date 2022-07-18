using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    delegate void Notice();
    class Message
    {
        public void SendComplete()
        {
            Console.WriteLine("모두 전송했습니다");
        }
    }

    class Sender
    {
        public event Notice OnComplete;
        public void Send()
        {
            for(int i = 0; i < 100; i += 10)
            {
                Console.WriteLine(i + "% 전송중");
                System.Threading.Thread.Sleep(200);
            }
            if (OnComplete != null) OnComplete();
        }
    }

    class _73_Delegate_Event
    {
        static void Main()
        {
            Message M = new Message();
            Sender S = new Sender();
            S.OnComplete += M.SendComplete;
            S.Send();
        }
    }
}

// 위 예제를 보면 delegate를 이용해서 event를 정의하는 것을 볼 수 있습니다.
// 그런데 이 소스에서 event라는 키워드를 제거해도 동일하게 동작하는 것을 볼 수 있습니다.
// 그렇다면 event는 왜 넣었을 까요?

// 결론을 얘기하자만 event는 delegate의 종류지만 delegate에 또 다른 특징을 부여하기 위한 문법입니다.
// delegate에 event를 부여하게 되고, 외부에는 event 변수인 OnComplete만 노출하여 사용하게 하면
// 이 OnComplete로는 접근할 수 있는 정보가 제한되게 됩니다. 메서드의 목록을 본다든가 하는 정보의
// 접근을 막을 수 있고, event를 프로그래밍 하는 사람은 불필요한 것을 신경쓰지 않고 등록만을 신경쓸
// 수 있습니다.

// 또, event는 자동으로 동기화 코드를 부여하게 되므로 멀티스레드에 안전하다는 특징도 가지고 있습니다.