using System;

class Program
{
    public static void Main(string[] args)
    {
        string str = "asdfGHJK";
        Console.WriteLine("Before: " + str);
        
        char[] charArray = str.ToCharArray(); // Convert string to a character array
        
        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLower(charArray[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
            else if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
        }
        
        string modifiedStr = new string(charArray); // Convert the modified character array back to a string
        Console.WriteLine("After: " + modifiedStr);
    }
}
