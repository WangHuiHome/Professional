using System;

namespace Specialization
{
    public class MethodOverloads
    {
        public void Foo<T>(T obj) => Console.WriteLine($"Foo<T>(T obj),obj type:{obj.GetType().Name}");
        public void Foo(int x) => Console.WriteLine("Foo(int x)");
        public void Foo<T1,T2>(T1 obj1,T2 obj2) =>
            Console.WriteLine($"Foo<T1,T2>(T1 obj1,T2 obj2);{obj1.GetType().Name} {obj2.GetType().Name}"); 
        public void Foo<T>(int obj1,T obj2) => 
            Console.WriteLine($"Foo<T>(int lobj1,T obj2);{obj2.GetType().Name}");
        public void Bar<T>(T obj) =>
            Foo(obj);
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var test = new MethodOverloads();
            test.Foo(23);
            test.Foo("abc");
            test.Foo("abc",34);
            test.Foo(35,"abc");
            test.Bar(36);
        }
    }
}
