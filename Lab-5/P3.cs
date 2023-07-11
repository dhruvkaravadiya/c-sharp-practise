// Write a programs to Find Area of Square, Rectangle and Circle using
// Method Overloading
class Program{
    public static void area(int a){  
        Console.WriteLine("Area of Square : "+(a*a));
    }
    public static void area(double a){  
        Console.WriteLine("Area of Circle : "+(3.14*a*a));
    }
    public static void area(int a , int b){
        Console.WriteLine("Area of Rectangle : "+(a*b));
    }
    public static void Main(string[] args)
    {
        area(2);
        area(10.0);
        area(2,4);
    }
}