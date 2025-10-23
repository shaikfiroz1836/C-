using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class StaticConDemo
    {
        static StaticConDemo()
        {
            Console.WriteLine("Static Constructor Called");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Called");
        }
    }
}
