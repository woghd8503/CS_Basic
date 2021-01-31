using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS_Bitcamp
{
    class _97_LINQ
    {
        static void Mian()
        {
            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> Query = from n in ar where (n % 3 == 0) select n;

            foreach(int k in Query)
            {
                Console.WriteLine(k);
            }
        }
    }
}
// 배열로부터 필요한 데이터를 가져오는 LINQ문입니다.
// from n in ar은 데이터를 가져올 대상이며,
// select n은 데이터를 가져오라는 명령입니다.
// where (n%3 == 0)은 3의 배수만 가져오라는 조건입니다.
// 이렇게 조건에 의해서 추출된 데이터만 가져와서 사용하면 되겠습니다.
