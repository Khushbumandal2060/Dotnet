using System;

#region Single Inheritance
class Animal  // Base class
{
    public void Eat()
    {
        Console.WriteLine("Animal eats food.");
    }
}

class Dog : Animal  // Derived class (Single Inheritance)
{
    public void Bark()
    {
        Console.WriteLine("Dog barks.");
    }
}
#endregion

#region Multilevel Inheritance
class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started.");
    }
}

class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

class SportsCar : Car
{
    public void Boost()
    {
        Console.WriteLine("Sports car uses turbo boost!");
    }
}
#endregion

#region Hierarchical Inheritance
class Shape
{
    public void Show()
    {
        Console.WriteLine("This is a shape.");
    }
}

class Circle : Shape
{
    public void AreaCircle()
    {
        Console.WriteLine("Area of Circle: πr²");
    }
}

class Rectangle : Shape
{
    public void AreaRectangle()
    {
        Console.WriteLine("Area of Rectangle: l × b");
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---- Single Inheritance ----");
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();

        Console.WriteLine("\n---- Multilevel Inheritance ----");
        SportsCar sc = new SportsCar();
        sc.Start();
        sc.Drive();
        sc.Boost();

        Console.WriteLine("\n---- Hierarchical Inheritance ----");
        Circle circle = new Circle();
        circle.Show();
        circle.AreaCircle();

        Rectangle rectangle = new Rectangle();
        rectangle.Show();
        rectangle.AreaRectangle();
    }
}
