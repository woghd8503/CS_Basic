using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    public static class Console
    {
        public static void WriteLine(bool value);
        public static void WriteLine(char value);
        public static void WriteLine(bool[] buffer);
    }
}
// WriteLine()처럼 특정 기능이 아니라 일반적인 기능이면서 자주 쓰이는 기능은 정적 메서드를 만들게 됩니다.

// 그럼으로써 호출 시 객체를 생성하지 않고 System.Console.WriteLine()처럼 클래스 네임스페이스와 클래스 소속만 밝히고 바로
// 사용합니다.

// 그런데 이러한 메서드들만 모아놓았더라도 개발자가 객체를 생성할 수도 있습니다.
// 그것을 원천적으로 방지하기 위해서는 2가지 방법이 있습니다.

// 첫 번째는 private Console(){} 처럼 생성자를 private으로 선언하는 것입니다.
// 이렇게 하면 외부에서는 생성자를 호출할 수가 없으므로 객체를 생성할 수 없게 됩니다.

// 두 번째 방법은 정적 클래스를 만드는 것입니다.
// public static class Console
// 처럼 선언하게 되는 클래스는 정적 클래스가 되어 객체를 생성할 수 없는 클래스가 됩니다.
// 물론 생성자를 private으로 할 필요도 없게 됩니다.