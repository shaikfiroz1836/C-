using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class CopyConDemo
    {
        int x;
        public CopyConDemo(int i)
        {
            x = i;
        }
        public void Display()
        {            
            Console.WriteLine("The value of x is : " + x);
        }
        static void Main(string[] args)
        {
            CopyConDemo a = new CopyConDemo(10);
            a.Display();
            Console.ReadLine();
        }
    }
}
