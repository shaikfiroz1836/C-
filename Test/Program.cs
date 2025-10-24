using System;
using System.Security.Cryptography;

namespace Test
{
    class Program
    {
        int x = 100; //x is Variable of a class
        static void Main(string[] args)
        {
            Program p = new Program();  //p is Instance of a class
            Program p1 = p;    //p1 is Reference of a class        
            Console.WriteLine(p.x);
            Console.WriteLine(p1.x);
            Console.WriteLine(p.x +" "+ p1.x);
        }
    }
}