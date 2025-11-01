using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class2 : Class1
    {
        Class2()
        {
            Console.WriteLine("Class2 Constructor is called");
        }
        public void Test3()
        {
            Console.WriteLine("Test 3 method");
        }
        static void Main()
        {
            Class2 c = new Class2();
            c.Test1();
            c.Test2();
            c.Test3();
        }
    }
}
