using System;

namespace GetAStringDemo
{
    public class Program
    {
        private delegate string GetAString();
        public static void Main(string[] args)
        {
            int x = 40;
            GetAString firstStringMethod = new GetAString(x.ToString);
            Console.WriteLine($"String is {firstStringMethod()}");
            var balance = new Currency(34,50);
            firstStringMethod = balance.ToString;
            Console.WriteLine($"String is {firstStringMethod()}");
            firstStringMethod = new GetAString(Currency.GetCurrencyUnit);
            Console.WriteLine($"String is {firstStringMethod()}");
        }
    }
}
