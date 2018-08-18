using System;

namespace MulticastDelegatesUsingInvocationList
{
    public class Program
    {
        public static void One()
        {
            Console.WriteLine("one");
            throw new Exception("Error in One");
        }
        public static void Two()
        {
            Console.WriteLine("two");
        }
        public static void Main(string[] args)
        {
            Action d1 = One;
            d1 += Two;
            Delegate[] delegates = d1.GetInvocationList();
            foreach(Action d in delegates)
            {
                try
                {
                    d();
                }
                catch(Exception)
                {
                    Console.WriteLine("Exception caught");
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
