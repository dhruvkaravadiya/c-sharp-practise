// Write a program to find the longest word in a string.
class Program{
    public static void Main(string[] args)
    {
        string str = "My name is Dhruv Karavadiya";
        string[] words = str.Split(' ');
        string max = words[0];
        for(int i = 1 ; i < words.Length ;i++){
            if(words[i].Length > max.Length){
                max = words[i];
            }
        }
        Console.WriteLine(max+" is the longest word");
    }
}