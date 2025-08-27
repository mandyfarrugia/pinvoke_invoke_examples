using System;
using Native;

namespace MiniCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mini Calculator using Native DLL");

            int a = 10, b = 2;
            Console.WriteLine($"{a} + {b} = {InteropWrapper.add(a, b)}");
            Console.WriteLine($"{a} - {b} = {InteropWrapper.subtract(a, b)}");
            Console.WriteLine($"{a} * {b} = {InteropWrapper.multiply(a, b)}");
            Console.WriteLine($"{a} / {b} = {InteropWrapper.divide(a, b)}");
            Console.WriteLine($"Square root of {a} = {InteropWrapper.square_root(a)}");
            Console.WriteLine($"{a} ^ {b} = {InteropWrapper.power(a, b)}");
            System.Console.WriteLine($"Pythagorean theorem: a={a}, b={b}, c={InteropWrapper.find_hypotenuse(a, b)}");
        }
    }
}