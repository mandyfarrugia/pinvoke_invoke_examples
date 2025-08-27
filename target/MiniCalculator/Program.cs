using System;
using MiniCalculator.Native;

namespace MiniCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculatorNative calculatorNative = new CalculatorNative();
            CalculatorWrapper calculatorWrapper = new CalculatorWrapper(calculatorNative);
            Console.WriteLine($"10 + 20 = {calculatorWrapper.ExecuteOperation(10, 20, calculatorWrapper.Add)}");
            Console.WriteLine($"5 - 4 = {calculatorWrapper.ExecuteOperation(5, 4, calculatorWrapper.Subtract)}");
            Console.WriteLine($"45 * 2 = {calculatorWrapper.ExecuteOperation(45, 2, calculatorWrapper.Multiply)}");
            Console.WriteLine($"88 / 2 = {calculatorWrapper.ExecuteOperation(88, 2, calculatorWrapper.Divide)}");
        }
    }
}