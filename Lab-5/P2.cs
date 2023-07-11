// Write a program using method overloading by changing number of
// arguments to calculate area of square and rectangle
class Program{
    public static void area(int a){  
        Console.WriteLine("Area of Square : "+(a*a));
    }
    public static void area(int a , int b){
        Console.WriteLine("Area of Rectangle : "+(a*b));
    }
    public static void Main(string[] args)
    {
        area(2);
        area(2,4);
    }
}