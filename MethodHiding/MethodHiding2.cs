using System;

namespace MethodHiding2
{
    class MethodHiding2
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
    class ChildClass : MethodHiding2
    {
        public override void Test1()
        {
            Console.WriteLine("ChildClass Test1");  // Method Overriding
        }
        public new void Test2()
        {
            Console.WriteLine("ChildClass Test2");  // Method Hiding by using new keyword
        }
        public void ParentTest1()
        {
            base.Test1();
        }
        public void ParentTest2()
        {
            base.Test2();
        }
        static void Main()
        {
            //MethodHiding2 m = new MethodHiding2();
            //m.Test1();
            //m.Test2();
            ChildClass c = new ChildClass();
            c.ParentTest1();
            c.ParentTest2();
            c.Test1();
            c.Test2();
        }
    }
}