using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        
        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        
        int sum = num1 + num2 + num3;

        
        Console.WriteLine("The sum of the three numbers is: " + sum);
    }
}
