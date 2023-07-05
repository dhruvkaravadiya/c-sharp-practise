// Write a program to accept a number from the user and throw an exception
// if the number is not an even number
class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        try{
            if(n%2!=0){
                 throw new Exception("Number is not even!");
            }
            Console.WriteLine("Number is Even");
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
}