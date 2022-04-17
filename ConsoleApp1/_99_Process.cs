using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Cs_Bitcamp
{
    class _99_Process
    {
        static void Main()
        {
            Process Proc = Process.Start("mspaint.exe");
            Thread.Sleep(5000);
            Proc.Kill();
        }
    }
}



