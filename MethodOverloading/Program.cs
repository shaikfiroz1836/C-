using System;

namespace MethodOverloading
{
    class Program
    {
        public void Test()
        {
            Console.WriteLine("1st method");
        }
        public void Test(int i)
        {
            Console.WriteLine("2nd method");
        }
        public void Test(string s)
        {
            Console.WriteLine("3rd method");
        }
        public void Test(int i,string s)
        {
            Console.WriteLine("4th method");
        }
        public void Test(string s, int i)
        {
            Console.WriteLine("5th method");
        }
        static void Main()
        {
            Program p = new Program();
            p.Test();
            p.Test(10);
            p.Test("abcdefg");
            p.Test(100,"asdfghj");
            p.Test("qwertyu",50);

        }
    }
}