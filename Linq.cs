using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Address { get; set; }
}

class Program
{
    static void Main()
    {
        // Sample list of employees
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Name = "Khushbu", Salary = 60000, Address = "Kathmandu" },
            new Employee { Name = "Amit", Salary = 45000, Address = "Lalitpur" },
            new Employee { Name = "Sita", Salary = 70000, Address = "Kathmandu" },
            new Employee { Name = "Ram", Salary = 52000, Address = "Bhaktapur" },
            new Employee { Name = "Hari", Salary = 30000, Address = "Kathmandu" }
        };

        // LINQ query to select matching employees
        var filteredEmployees = from emp in employees
                                where emp.Salary > 50000 && emp.Address == "Kathmandu"
                                select emp;

        
        Console.WriteLine("Employees with salary > 50000 and address 'Kathmandu':\n");

        foreach (var emp in filteredEmployees)
        {
            Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}, Address: {emp.Address}");
        }
    }
}
