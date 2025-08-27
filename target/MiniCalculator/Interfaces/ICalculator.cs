namespace MiniCalculator.Interfaces
{
    /// <summary>
    /// Interface defining basic calculator operations.
    /// </summary>
    public interface ICalculator
    {
        double Add(double firstAddend, double secondAddend);
        double Subtract(double minuend, double subtrahend);
        double Multiply(double multiplicand, double multiplier);
        double Divide(double dividend, double divisor);
        double Power(double baseValue, double exponent);
        double SquareRoot(double value);
        double FindPerpendicular(double hypotenuseLength, double baseLength);
        double FindBase(double hypotenuseLength, double perpendicularLength);
        double FindHypotenuse(double perpendicularLength, double baseLength);
    }
}