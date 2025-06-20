using System;

class Program
{
    static void Main(string[] args)
    {
      
        string[] words = { "Hello", "World", "from", "C#" };

    
        string result = string.Join(" ", words);

        
        Console.WriteLine("Combined string: " + result);
    }
}
