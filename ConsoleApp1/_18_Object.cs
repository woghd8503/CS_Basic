using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class _18_Object
    {
        public Object();
        public virtual bool Equals(object obj);
        public static bool Equals(object objA, Object objB);

        public virtual int GetHashCode();
        public Type GetType();
        protected object MemberwiseClone();
        public static bool ReferenceEquals(object objA, object objB);
        public virtual string ToString();
    }
}


// 닷넷에서 클래스를 정의한 후 컴파일 하면 모든 클래스는 자동적으로 object의 상속을 받게 되어 있습니다.
// 아래의 메서드를 기본 메서드로 가지고 있습니다.