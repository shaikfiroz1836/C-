using System;

namespace TypesProject
{
    class Program
    {
        int i;
        static int j = 200;
        const float pi = 3.14f;
        readonly bool flag;
        public Program(int i,bool flag)
        {
            this.i = i;
            this.flag = flag;
        }
        static void Main()
        {
            Program p1 = new Program(50,true);
            Program p2 = new Program(150,false);
            Console.WriteLine(p1.i +" "+p2.i);
            Console.WriteLine(j);
            Console.WriteLine(pi);
            Console.WriteLine(p1.flag + " " + p2.flag);
            p1.i = 50000;
            Console.WriteLine(p1.i+" "+p2.i);
        }
    }
}