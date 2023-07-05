// Write a program to create interface Calculate. In this interface we have two
// member functions Addition() and Subtraction(). Implements this interface
// in another class named Result
interface Calculate{
    void Addition(int a , int b);
    void Substraction(int a, int b);
}
class Result : Calculate
{
    public void Addition(int a,int b)
    {   
        Console.WriteLine(a+b);
    }

    public void Substraction(int a , int b)
    {
        Console.WriteLine(a-b);
    }
}
class Program{
    public static void Main(string[] args)
    {
        Result r = new Result();
        r.Addition(2,3);
        r.Substraction(5,3);
    }
}