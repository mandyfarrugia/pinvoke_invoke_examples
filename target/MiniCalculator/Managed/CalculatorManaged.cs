using Interfaces;

namespace Managed
{
    public class CalculatorManaged : ICalculator
    {
        public int Add(int firstAddend, int secondAddend) => firstAddend + secondAddend;
        public int Subtract(int minuend, int subtrahend) => minuend - subtrahend;
        public double Multiply(int multiplicand, int multiplier) => multiplicand * multiplier;
        public double Divide(int dividend, int divisor) => divisor != 0 ? (double)dividend / divisor : -1;
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