using System;
namespace SimpleDelegates
{
    public class MathOperations
    {
        // public static double MultiplyByTwo(double value) => value * 2;
        // public static double Square(double value) => value * value;
        public static void MultiplyByTwo(double value) => 
            Console.WriteLine($"Multiplying by 2:{value} gives {value * 2}");
        
        public static void Square(double value) => 
            Console.WriteLine($"Squaring:{value} gives {value * value}");
    }
}