using System;
using MyApplication.Models;  // Import the namespace

class Program
{
    static void Main(string[] args)
    {
        // Create object of Person class from MyApplication.Models namespace
        Person p = new Person();

        // Access fields
        p.Name = "Khushbu";
        p.Age = 22;

        // Call method
        p.Display();
    }
}
