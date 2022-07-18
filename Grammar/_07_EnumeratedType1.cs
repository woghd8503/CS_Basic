using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _07_EnumInt
    {
        enum SEASON {Spring, Summer, Fall, Winter}
        static void Main(string[] args)
        {
            SEASON season;
            season = SEASON.Fall;
            string name = season.ToString();
            Console.WriteLine(name);
            season = (SEASON)Enum.Parse(typeof(SEASON), "Spring");
            Console.WriteLine(season);
            Console.WriteLine((int)season);
        }
    }
}

// C#은 문자열을 이용해서 상수 값을 얻어내는 것이 가능합니다.