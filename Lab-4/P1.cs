// Write a program to Create a divide by zero exception and handle it.
class Program
{
    static void Main(string[] args)
    {
        int num1 = 2 , num2 = 0;
        int result = 0;
        try {
            result = (num1 / num2);
         } catch (DivideByZeroException e) {
            Console.WriteLine("Divide By Zero Error", e);
         } finally {
            Console.WriteLine("Answer : " +  result);
         }
    }
}
