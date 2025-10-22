using System;
namespace Demo
{
    class Program
    {
        int i;
        string s;
        bool b;
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("value of i: " + p.i);
            Console.WriteLine("value of s: " + p.s);
            Console.WriteLine("value of b: " + p.b);
            Console.WriteLine();
        }
    }
}