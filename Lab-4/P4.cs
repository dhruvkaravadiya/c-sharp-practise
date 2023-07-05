// Write a program to create an abstract class Sum having abstract methods
// SumOfTwo(int a, int b) and SumOfThree(int a, int b,int c). Create another class
// Calculate which extends the abstract class and implements the abstract methods
abstract class Sum{
    public abstract void SumOfTwo(int a , int b);
    public abstract void SumOfThree(int a, int b,int c);
}
class Calculate : Sum{
    public override void SumOfTwo(int a , int b){
        Console.WriteLine(a + b);
    }
    public override void SumOfThree(int a, int b,int c){
        Console.WriteLine(a+b+c);
    }
}
class Program{
    public static void Main(string[] args)
    {
        Calculate calc = new Calculate();
        int a = 2 , b = 3 , c = 4;
        calc.SumOfTwo(a,b);
        calc.SumOfThree(a,b,c);
    }
}