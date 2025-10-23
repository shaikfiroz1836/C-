using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Test
    {
        class First
        {
            public int i = 100;
        }
        class Second 
        {
            public int i;
            public Second(int i)
            {
                this.i = i;
            }
        }
        static void Main()
        {
            First f1 = new First();
            First f2 = new First();
            First f3 = new First();
            Console.WriteLine(f1.i + " " + f2.i +" "+ f3.i);

            Second s1 = new Second(1);
            Second s2 = new Second(2);
            Second s3 = new Second(3);
            Console.WriteLine(s1.i + " " + s2.i + " " + s3.i);

        }
    }
}
