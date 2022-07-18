using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace CS_Bitcamp
{
    class _85_Attribute
    {
        #region 외부 DLL 정의문
        [DllImport("User32.dll")]
        public static extern int MessageBox(int hParent, string Message, string Caption, int Type);
        [DllImport("Kernel32.dll")]
        public static extern uint WinExec(string Path, uint nCmdShow);

        #endregion

        static void Main()
        {
            MessageBox(0, "메모장을 실행합니다.", "알림", 0);
            WinExec("notepad.exe", 1);
        }
    }
}

// Dllmport 어트리뷰트는 외부 DLL의 함수를 사용할 때 정의하게 됩니다.
// 위는 각각 User32.dll와 Kernel32.dll로부터 Win32 API 함수를 가져다 쓰는 것입니다.
// Windows 프로그래밍에서는 종종 Win32 API나 사용자가 만든 DLL의 API를 사용할 때가 있습니다.
// 그럴 때 이렇게 사용하면 C#에서도, C, C++과 연동이 가능합니다.

// 하지만 C#을 Mono같은 리눅스로 포팅할 경우는 Win32 API에 의존적인 경우는 포팅에 많은 노력이 필요하게 됩니다.
// Win32 API에 독립적인 경우는 적은 노력으로도 리눅스 상에서 돌아가게 할 수 있지만, 직접 API를 사용하는
// 경우는 대안에 잘 찾아야 합니다.