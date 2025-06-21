using System;

// Base class with virtual method
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Derived class that overrides the virtual method
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

// Another derived class
class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal;

        animal = new Dog();
        animal.Speak();  

        animal = new Cat();
        animal.Speak();  
    }
}
