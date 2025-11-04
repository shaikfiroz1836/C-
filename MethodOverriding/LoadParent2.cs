using System;

namespace MethodOverriding
{
    public class LoadParent2
    {
        public void Show()
        {
            Console.WriteLine("Parent Show method is called.");
        }
        public virtual void Test()
        {
            Console.WriteLine("Parent Test method is called.");
        }
    }
    public class LoadChild2 : LoadParent2
    {
        public void Show(int i)
        {
            Console.WriteLine("Child Show method is called.");
        }
        public override void Test()
        {
            Console.WriteLine("Child Test method is called.");
        }
        static void Main()
        {
            LoadChild2 c = new LoadChild2();
            c.Show();
            c.Show(10);
            c.Test();
        }
    }
}