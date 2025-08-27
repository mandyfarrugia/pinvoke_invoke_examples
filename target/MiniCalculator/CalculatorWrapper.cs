using MiniCalculator.Interfaces;

namespace MiniCalculator
{
    public delegate double CalculatorUnary(double operand);
    public delegate double CalculatorBinary(double firstOperand, double secondOperand);

    /// <summary>
    /// A wrapper class for calculator operations.
    /// </summary>
    public class CalculatorWrapper
    {
        // This class can be expanded to include additional functionality or to wrap around other calculator implementations.

        public CalculatorBinary Add { get; private set; }
        public CalculatorBinary Subtract { get; private set; }
        public CalculatorBinary Multiply { get; private set; }
        public CalculatorBinary Divide { get; private set; }
        public CalculatorBinary Power { get; private set; }
        public CalculatorUnary SquareRoot { get; private set; }
        public CalculatorBinary PerpendicularCalculation { get; private set; }
        public CalculatorBinary BaseCalculation { get; private set; }
        public CalculatorBinary HypotenuseCalculation { get; private set; }

        public CalculatorWrapper(ICalculator calculator)
        {
            this.Add = calculator.Add;
            this.Subtract = calculator.Subtract;
            this.Multiply = calculator.Multiply;
            this.Divide = calculator.Divide;
            this.Power = calculator.Power;
            this.SquareRoot = calculator.SquareRoot;
            this.PerpendicularCalculation = calculator.FindPerpendicular;
            this.BaseCalculation = calculator.FindBase;
            this.HypotenuseCalculation = calculator.FindHypotenuse;
        }

        public double ExecuteOperation(double operand, CalculatorUnary operation)
        {
            if (operation == null)
                throw new ArgumentNullException(nameof(operation));
            return operation(operand);
        }

        public double ExecuteOperation(double firstOperand, double secondOperand, CalculatorBinary operation)
        {
            if (operation == null)
                throw new ArgumentNullException(nameof(operation));
            return operation(firstOperand, secondOperand);
        }
    }
}