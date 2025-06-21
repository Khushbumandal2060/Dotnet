using System;

class Number
{
    public int Value;

    // Constructor
    public Number(int value)
    {
        Value = value;
    }

    // Overload unary minus operator
    public static Number operator -(Number n)
    {
        return new Number(-n.Value);
    }

    // Method to display value
    public void Display()
    {
        Console.WriteLine($"Value: {Value}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Number num = new Number(100);
        Console.WriteLine("Original number:");
        num.Display();

        Number negatedNum = -num;
        Console.WriteLine("After overloading unary - operator:");
        negatedNum.Display();
    }
}
