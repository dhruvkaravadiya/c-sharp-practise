// Write a program to create a delegate calculator to demonstrate the
// example of generic delegate.
delegate cal CalcDelegate<cal>(cal x, cal y);

class Calculator
{
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static double Divide(double x, double y)
    {
        if (y != 0)
            return x / y;
        else
            throw new DivideByZeroException("Cannot divide by zero.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CalcDelegate<int> addDelegate = Calculator.Add;
        CalcDelegate<double> divideDelegate = Calculator.Divide;

        int num1 = 10;
        int num2 = 5;
        int sum = addDelegate(num1, num2);
        Console.WriteLine("Sum: " + sum);

        double num3 = 12.5;
        double num4 = 3.5;
        double result = divideDelegate(num3, num4);
        Console.WriteLine("Result: " + result);
    }
}
