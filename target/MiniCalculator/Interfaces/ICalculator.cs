public interface ICalculator
{
    int Add(int firstAddend, int secondAddend);
    int Subtract(int minuend, int subtrahend);
    int Multiply(int multiplicand, int multiplier);
    double Divide(int dividend, int divisor);
    double Power();
    double SquareRoot();
    double FindPerpendicular();
    double FindBase();
    double FindHypotenuse();   
}