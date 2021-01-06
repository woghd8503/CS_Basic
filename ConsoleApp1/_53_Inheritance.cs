﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Bitcamp
{
    class Student
    {
        protected string Name;
        protected int Age;
        public Student(string aName, int aAge)
        {
            Name = aName;
            Age = aAge;
        }
        public virtual void Intro()
        {
            Console.WriteLine("이름:" + Name);
            Console.WriteLine("나이:" + Age);
        }
    }
    class MiddleStudent : Student
    {
        protected int StNum;
        public MiddleStudent(string aName, int aAge, int aStNum): base(aName, aAge)
        {
            StNum = aStNum;
        }
        public override void Intro()
        {
            base.Intro();
            Console.WriteLine("학번:" + StNum);
        }
        public void Study()
        {
            Console.WriteLine("나랏 말쌈이 듕귁에 달아...");
        }
    }
    class CSTest
    {
        static void Main()
        {
            MiddleStudent Jang;
            Jang = new MiddleStudent("장길산", 15, 901211);
            Jang.Intro();
            Jang.Study();
        }
    }
}

// 상속 부모의 모든 것들을 물려받는다. public 상속만 사용