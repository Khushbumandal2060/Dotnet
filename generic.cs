using System;

// Generic class
class MyGenericClass<T>
{
    private T value;

    // Constructor
    public MyGenericClass(T val)
    {
        value = val;
    }

    // Generic method inside generic class
    public void Display()
    {
        Console.WriteLine("Value: " + value);
    }

    // Separate generic method
    public void ShowType<U>(U data)
    {
        Console.WriteLine("Generic method value: " + data);
        Console.WriteLine("Type of U is: " + data.GetType());
    }
}

class Program
{
    static void Main()
    {
        // Create generic class object with int type
        MyGenericClass<int> obj1 = new MyGenericClass<int>(100);
        obj1.Display();
        obj1.ShowType<string>("Hello");

        // Create generic class object with string type
        MyGenericClass<string> obj2 = new MyGenericClass<string>("C# Generics");
        obj2.Display();
        obj2.ShowType<double>(3.14);
    }
}
