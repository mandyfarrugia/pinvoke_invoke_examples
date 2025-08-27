namespace MiniCalculator.Interfaces
{
    /// <summary>
    /// Interface defining basic calculator operations.
    /// </summary>
    public interface ICalculator
    {
        int Add(int firstAddend, int secondAddend);
        int Subtract(int minuend, int subtrahend);
        double Multiply(int multiplicand, int multiplier);
        double Divide(int dividend, int divisor);
        double Power(double baseValue, double exponent);
        double SquareRoot(double value);
        double FindPerpendicular(double hypotenuseLength, double baseLength);
        double FindBase(double hypotenuseLength, double perpendicularLength);
        double FindHypotenuse(double perpendicularLength, double baseLength);
    }
}