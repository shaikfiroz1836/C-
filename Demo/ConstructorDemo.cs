using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ConstructorDemo
    {
        static int y;
        int x;
        static ConstructorDemo()
        {
            Console.WriteLine("Static Constructor is Called");
        }
        public ConstructorDemo(int x)
        {
            this.x = x;
            Console.WriteLine("Non-Static Constructor is Called");
        }
        static void Main()
        {
            
            Console.WriteLine("Main Method is called");
            ConstructorDemo a1 = new ConstructorDemo(1);
            ConstructorDemo a2 = new ConstructorDemo(2);
            ConstructorDemo a3 = new ConstructorDemo(3);

            Console.WriteLine(y);
            Console.WriteLine(a1.x + " "+a2.x+" "+a3.x);

            Console.ReadLine();
        }
    }
}
