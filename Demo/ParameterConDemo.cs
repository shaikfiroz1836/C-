using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ParameterConDemo
    {
        int x;
        public ParameterConDemo(int a)
        {
            x = a;
            Console.WriteLine("Parameterized Constructor: " + a);
        }
        public void Display()
        {
            Console.WriteLine("The value of x is : " + x);
        }
        static void Main() 
        {
            ParameterConDemo p = new ParameterConDemo(100);
            ParameterConDemo p1 = new ParameterConDemo(1);
            ParameterConDemo p2 = new ParameterConDemo(1200);
            p.Display();
            p1.Display();
            p2.Display();

        }
    }
}
