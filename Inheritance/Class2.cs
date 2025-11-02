using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class2 : Class1
    {
        public Class2(int a) : base(a)
        {
            Console.WriteLine("Class2 Constructor is called: "+a);
        }
        public void Test3()
        {
            Console.WriteLine("Test 3 method");
        }
        static void Main()
        {
            //Object obj = new Object();
            //Console.WriteLine(obj.GetType);
            //Class2 c = new Class2();
            //c.Test1();
            //c.Test2();
            //c.Test3();
            //Class1 c1 = new Class1();
            //Console.WriteLine(c1.GetType());
            Class2 c2 = new Class2(50);
            //Console.WriteLine(c2.GetType());

        }
    }
}
