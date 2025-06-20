using System;

class Employee
{
   
    public string Name;
    public string Email;
    public double Salary;

    // Constructor
    public Employee(string name, string email, double salary)
    {
        Name = name;
        Email = email;
        Salary = salary;
    }


    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Salary: {Salary:C}");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee("Khushbu Mandal","khushbumandal225@gmail.com", 50000);

        
        emp.Display();
    }
}
