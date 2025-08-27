using MiniCalculator.Interfaces;
using MiniCalculator.Native;

namespace MiniCalculator.Native
{
    /// <summary>
    /// This class can be expanded to include methods that utilize the InteropWrapper to perform calculations using the native DLL functions.
    /// </summary>
    public class CalculatorNative : ICalculator
    {
        public double Add(double firstAddend, double secondAddend) => InteropWrapper.add(firstAddend, secondAddend);
        public double Subtract(double minuend, double subtrahend) => InteropWrapper.subtract(minuend, subtrahend);
        public double Multiply(double multiplicand, double multiplier) => InteropWrapper.multiply(multiplicand, multiplier);
        public double Divide(double dividend, double divisor) => InteropWrapper.divide(dividend, divisor);
        public double Power(double baseValue, double exponent) => InteropWrapper.power(baseValue, exponent);
        public double SquareRoot(double value) => InteropWrapper.square_root(value);
        public double FindPerpendicular(double hypotenuseLength, double baseLength)
            => InteropWrapper.find_perpendicular(hypotenuseLength, baseLength);
        public double FindBase(double hypotenuseLength, double perpendicularLength)
            => InteropWrapper.find_base(hypotenuseLength, perpendicularLength);
        public double FindHypotenuse(double perpendicularLength, double baseLength)
            => InteropWrapper.find_hypotenuse(perpendicularLength, baseLength);
    }
}