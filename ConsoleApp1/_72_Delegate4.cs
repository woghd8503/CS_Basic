using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    delegate void Notice(string info);

    class Customer
    {
        private int id;
        public Customer(int aid)
        {
            id = aid;
        }
        public void SendCust(string info)
        {
            Console.WriteLine("{0}번 고객에게 {1}를 전송한다.", id, info);
        }
    }
    class _72_Delegate4
    {
        static void Main()
        {
            Customer[] arCust = new Customer[10];
            for(int i = 0; i < 10; i++)
            {
                arCust[i] = new Customer(i);
            }
            Notice AlramCust = null;
            AlramCust += arCust[1].SendCust;
            AlramCust += arCust[3].SendCust;
            AlramCust += arCust[5].SendCust;
            AlramCust += arCust[8].SendCust;
            AlramCust("증권 찌라시");
        }
    }
}
// 델리게이트는 이렇게 여러 메서드를 등록해놓은 후 한꺼번에 이벤트를 전송할 수도 있습니다.