using System;

namespace MethodHiding
{
    class ParentClass
    {
        public virtual void Test1()
        {
            Console.WriteLine("ParentClass Test1");
        }
        public void Test2()
        {
            Console.WriteLine("ParentClass Test2");
        }
    }
    class ChildClass : ParentClass 
    {
        public override void Test1()
        {
            Console.WriteLine("ChildClass Test1");
        }
        public new void Test2()
        {
            Console.WriteLine("ChildClass Test2");
        }
        static void Main()
        {
            ChildClass c = new ChildClass();
            c.Test1();
            c.Test2();
        }
    }
}