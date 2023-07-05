// Write a program to create interface named Shape. In this interface, we
// have three methods Circle(), Triangle() and Square() which calculates area
// of Circle, Triangle and Square respectively. Implement Shape interface
interface Shape{
    void Circle(double r);
    void Triangle(double b , double h);
    void Square(int a);
}
class Area : Shape{
    public void Circle(double a){
        Console.WriteLine("Area of Circle :"+ (3.14*a*a));
    }
    public void Triangle(double b , double h){
        Console.WriteLine("Area of Triange :"+ (0.5*b*h));
    }
    public void Square(int a){
        Console.WriteLine("Area of Square :"+ (a*a));
    }
}
class Program{
    
    public static void Main(string[] args)
    {
        Area area = new Area();
        area.Circle(10);
        area.Triangle(10,10);
        area.Square(10);
    }
}