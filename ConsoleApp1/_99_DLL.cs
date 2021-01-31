using System;
using System.Collections.Generic;
using System.Text;

namespace CalcLib
{
    class _99_DLL
    {
            public static int Add(int a, int b) { return a + b; }
            public static int Sub(int a, int b) { return a - b; }
            public static int Mul(int a, int b) { return a * b; }
            public static int Div(int a, int b) { return a / b; }
    }
}

// 빌드를 하게 되면 bin 폴더에 CalcLib.dll 파일이 생성되어 있습니다.
// pdb파일은 심볼파일이라고 부르고 Debug시 사용되게 됩니다