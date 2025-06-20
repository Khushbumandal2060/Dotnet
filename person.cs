namespace MyApplication.Models
{
    public class Person
    {
        // Fields
        public string Name;
        public int Age;

        // Method
        public void Display()
        {
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Age: {Age}");
        }
    }
}
