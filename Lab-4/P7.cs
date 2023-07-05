// Write program showing use of common methods of String class.
class Program
{
    static void Main()
    {
        string str = "Hello, world!";
        
        // Format()
        string formattedString = string.Format("The string is: {0}", str);
        Console.WriteLine(formattedString);
        
        // Split()
        string[] substrings = str.Split(',');
        foreach (string sub in substrings)
        {
            Console.WriteLine(sub);
        }
        
        // Substring()
        string substring = str.Substring(7);
        Console.WriteLine(substring);
        
        // Compare()
        int result = string.Compare("abc", "def");
        Console.WriteLine(result);
        
        // Replace()
        string replacedString = str.Replace("world", "everyone");
        Console.WriteLine(replacedString);
        
        // Contains()
        bool containsSubstring = str.Contains("Hello");
        Console.WriteLine(containsSubstring);
        
        // Join()
        string[] stringsToJoin = { "Hello", "world" };
        string joinedString = string.Join(", ", stringsToJoin);
        Console.WriteLine(joinedString);
        
        // Trim()
        string trimmedString = "   Trimmed   ";
        string trimmed = trimmedString.Trim();
        Console.WriteLine(trimmed);
        
        // EndsWith()
        bool endsWith = str.EndsWith("!");
        Console.WriteLine(endsWith);
        
        // IndexOf()
        int index = str.IndexOf('o');
        Console.WriteLine(index);
        
        // Remove()
        string removedString = str.Remove(7, 6);
        Console.WriteLine(removedString);
        
        // ToUpper()
        string upperCaseString = str.ToUpper();
        Console.WriteLine(upperCaseString);
        
        // ToLower()
        string lowerCaseString = str.ToLower();
        Console.WriteLine(lowerCaseString);
        
        // PadLeft()
        string paddedLeftString = str.PadLeft(15);
        Console.WriteLine(paddedLeftString);
        
        // PadRight()
        string paddedRightString = str.PadRight(15);
        Console.WriteLine(paddedRightString);
        
        // StartsWith()
        bool startsWith = str.StartsWith("Hello");
        Console.WriteLine(startsWith);
        
        // ToCharArray()
        char[] charArray = str.ToCharArray();
        foreach (char c in charArray)
        {
            Console.WriteLine(c);
        }
        
        // LastIndexOf()
        int lastIndex = str.LastIndexOf('o');
        Console.WriteLine(lastIndex);
    }
}
