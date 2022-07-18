using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class DB
    {
        private string DBId;
        public DB(string dbId)
        {
            DBId = dbId;
            Console.WriteLine("{0} ID로  DB를 연결한다.", dbId);
        }
        ~DB()
        {
            DBId = null;
            Console.WriteLine("DB 연결을 해제한다.");
        }
    }

    class _48_Destructor
    {
        static void Main()
        {
            DB S = new DB("SDB");
            Console.WriteLine("DB 입출력...");
        }
    }
}

// C++은 명시적으로 소멸자의 호출시점을 알 수가 있습니다.
// 하지만 C#은 객체의 소멸을 CLR내의 Garbage Collector가 담당하고
// 있습니다. 그러므로 값 타입이 지역 변수로 할당한 것을 제외하고는 
// 객체의 메모리 해제 시점을 정확이 알 수 없습니다.

// 그래서 소멸자에 특별히 코딩하는 경우가 많지는 않습니다.
// 위처럼 직접적인 메모리 해제보다는 소멸시에 마무리 해야 할 
// 작업들의 정리 정도를 구현합니다.
// 그런데 프로그래머가 즉시 리소를 해제하고 싶을 때는 소멸자가 호출되도록
// 요청할 수 있으나 추천하는 방법은 아닙니다.

// 일반적으로 BCL라이브러리에 구현된 클래스들은 IDisposable 인터페이스를
// 상속받어서 이 인터페이스에서 제공되는 Dispose메서드에 리소스를 해제하도록
// 구현되어 있습니다. 그래서 우리는 일반적으로 C#에서 제공받는 클래스 객체를
// 사용할 때 메모리를 해제하고 싶으면 객체의 Dispose 메서드를 호출하면 되겠습니다.