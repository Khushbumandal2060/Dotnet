using System;

class Student
{
    public string Name;
    public int Age;

    // 1. Default Constructor
    public Student()
    {
        Name = "Unknown";
        Age = 0;
        Console.WriteLine("Default constructor called.");
    }

    // 2. Parameterized Constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Parameterized constructor called.");
    }

    // 3. Copy Constructor (custom)
    public Student(Student s)
    {
        Name = s.Name;
        Age = s.Age;
        Console.WriteLine("Copy constructor called.");
    }

    // 4. Static Constructor
    static Student()
    {
        Console.WriteLine("Static constructor called (runs once only).");
    }

    // Method to display student details
    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        // Static constructor is called automatically before any object is created

        // Using Default Constructor
        Student s1 = new Student();
        s1.Display();

        // Using Parameterized Constructor
        Student s2 = new Student("Khushbu", 20);
        s2.Display();

        // Using Copy Constructor
        Student s3 = new Student(s2);
        s3.Display();
    }
}
