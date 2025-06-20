using System;

class Program
{
    static void Main(string[] args)
    {
        // Input a single character
        Console.Write("Enter an alphabet: ");
        char ch = char.ToLower(Console.ReadKey().KeyChar);  // Accept char and convert to lowercase
        Console.WriteLine();

      
        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine($"{ch} is a vowel.");
                break;
            default:
                if (char.IsLetter(ch))
                    Console.WriteLine($"{ch} is a consonant.");
                else
                    Console.WriteLine("Invalid input. Please enter an alphabet.");
                break;
        }
    }
}
