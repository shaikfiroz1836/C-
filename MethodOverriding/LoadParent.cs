using System;

namespace MethodOverriding
{
    public class LoadParent
    {
        public void Show()
        {
            Console.WriteLine("Parent Show method is called.");
        }
        public void Test()
        {
            Console.WriteLine("Parent Test method is called.");
        }
    }
    public class LoadChild : LoadParent
    {
        static void Main()
        {
            LoadChild c = new LoadChild();
            c.Show();
            c.Test();
        }
    }
}