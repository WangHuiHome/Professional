using System;

namespace SimpleDelegates
{
    // public delegate double DoubleOp(double x);
    public class Program
    {
        public static void Main(string[] args)
        {
            // DoubleOp[] operations = {MathOperations.MultiplyByTwo,MathOperations.Square};
            // for(int i = 0;i < operations.Length;i++)
            // {
            //     Console.WriteLine($"Using operations[{i}]:");
            //     ProcessAndDisplayNumber(operations[i],2.0);
            //     ProcessAndDisplayNumber(operations[i],7.94);
            //     ProcessAndDisplayNumber(operations[i],1.414);
            // }
            Action<double> operations = MathOperations.MultiplyByTwo;
            operations += MathOperations.Square;
            ProcessAndDisplayNumber(operations,2.0);
            ProcessAndDisplayNumber(operations,7.94);
            ProcessAndDisplayNumber(operations,1.414);
        }
        // public static void ProcessAndDisplayNumber(DoubleOp action,double value) =>
        //     Console.WriteLine($"Value is {value},result of operation is {action(value)}");
        public static void ProcessAndDisplayNumber(Action<double> action,double value)
        {
            Console.WriteLine();
            Console.WriteLine($"ProcessAndDisplayNumber called with value = {value}");
            action(value);
        }
    }



}
