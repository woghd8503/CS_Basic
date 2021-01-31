using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace CS_Bitcamp
{
    class _98_LINQ1
    {
        static void Main()
        {
            var Files = from f in
                            Directory.GetFiles("c:\\")
                        select f;
            foreach(var f in Files)
            {
                Console.WriteLine("Name : " + f);
            }
        }
    }
}
// 이번에는 클래스로부터 데이터를 가져오고 있습니다.
// c드라이브의 파일들을 모두 가져오고 있습니다.
