using System;

class Complex
{
    public int Real;
    public int Imaginary;

    // Constructor
    public Complex(int real, int imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Overload binary + operator
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    // Display method
    public void Display()
    {
        Console.WriteLine($"Complex Number: {Real} + {Imaginary}i");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Complex c1 = new Complex(5, 6);
        Complex c2 = new Complex(7, 8);

        Console.WriteLine("First Complex Number:");
        c1.Display();

        Console.WriteLine("Second Complex Number:");
        c2.Display();

        // Using overloaded + operator
        Complex result = c1 + c2;

        Console.WriteLine("After Addition:");
        result.Display();
    }
}
