using System;

public partial class Student
{
    public string Name;
    public int Age;

    public void DisplayBasicInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}
