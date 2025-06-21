using System;

class Shape
{
    // Properties
    public double Length { get; set; }
    public double Breadth { get; set; }

    // Default Constructor
    public Shape()
    {
        Length = 0;
        Breadth = 0;
        Console.WriteLine("Default constructor of Shape called.");
    }

    // Parameterized Constructor
    public Shape(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
        Console.WriteLine("Parameterized constructor of Shape called.");
    }
}

// Derived class: Rectangle
class Rectangle : Shape
{
    // Constructor that calls base class constructor
    public Rectangle(double length, double breadth) : base(length, breadth)
    {
    }

    public double GetArea()
    {
        return Length * Breadth;
    }
}

class Program
{
    static void Main()
    {
        // Create Rectangle object using parameterized constructor
        Rectangle rect = new Rectangle(10, 5);


        Console.WriteLine($"Area of rectangle: {rect.GetArea()}");
    }
}
