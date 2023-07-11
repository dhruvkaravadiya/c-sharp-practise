// Write a program to return the factorial from the method using delegate

delegate int FactorialDelegate(int num);

class Program
{
    static void Main(string[] args)
    {
        FactorialDelegate factorialDelegate = CalculateFactorial;

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int factorial = factorialDelegate(number);

        Console.WriteLine($"Factorial of {number} is: {factorial}");
    }

    static int CalculateFactorial(int num)
    {
        if (num == 0)
            return 1;

        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
