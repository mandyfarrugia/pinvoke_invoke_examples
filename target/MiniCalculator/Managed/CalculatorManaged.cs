using MiniCalculator.Interfaces;

namespace MiniCalculator.Managed
{
    public class CalculatorManaged : ICalculator
    {
        public double Add(double firstAddend, double secondAddend) => firstAddend + secondAddend;
        public double Subtract(double minuend, double subtrahend) => minuend - subtrahend;
        public double Multiply(double multiplicand, double multiplier) => multiplicand * multiplier;
        public double Divide(double dividend, double divisor) => divisor != 0 ? (double)dividend / divisor : -1;
        public double Power(double baseValue, double exponent) => Math.Pow(baseValue, exponent);
        public double SquareRoot(double value) => value >= 0 ? Math.Sqrt(value) : -1;
        public double FindPerpendicular(double hypotenuseLength, double baseLength)
            => Math.Sqrt(Math.Pow(hypotenuseLength, 2) - Math.Pow(baseLength, 2));
        public double FindBase(double hypotenuseLength, double perpendicularLength)
            => Math.Sqrt(Math.Pow(hypotenuseLength, 2) - Math.Pow(perpendicularLength, 2));
        public double FindHypotenuse(double perpendicularLength, double baseLength)
            => Math.Sqrt(Math.Pow(perpendicularLength, 2) + Math.Pow(baseLength, 2));
    }
}