// Write a program to change the case of entered characte
class Program{
    public static void Main(string[] args)
    {
        char ch = Convert.ToChar(Console.Read());
        if(char.IsUpper(ch)){
            ch = char.ToLower(ch);
        }
        else{
            ch = char.ToUpper(ch);
        }
        Console.WriteLine(ch);
    }
}