// Write a program that reads 5 numbers from user. Demonstrate
// concept of IndexOutOfRange Exception.
class Program
{
    static void Main(string[] args)
    {
        int []arr = new int[5];
        int x = 1;
        try{
            for(int i = 0 ; i <= 5 ; i++){
                arr[i] = x+i;
            }
        }
        catch(IndexOutOfRangeException ex){
            Console.WriteLine("Index out of range");
        }
        finally{
            Console.WriteLine("No errors");
        }
    }
}