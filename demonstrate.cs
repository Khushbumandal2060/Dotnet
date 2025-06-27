using System;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("✅ Exception Handling Example");

            try
            {
                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                // This may throw DivideByZeroException
                int result = num1 / num2;

                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("❌ Error: Cannot divide by zero.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("❌ Error: Invalid input. Please enter valid numbers.");
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ General Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("✅ Finally block executed.");
            }

            Console.ReadKey();
        }
    }
}
