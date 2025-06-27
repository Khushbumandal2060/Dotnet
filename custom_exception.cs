using System;

namespace CustomExceptionExample
{
    // ✅ 1. Define custom exception by inheriting from Exception
    public class AgeTooLowException : Exception
    {
        public AgeTooLowException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("✅ Custom Exception Example");

            try
            {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 18)
                {
                    // ✅ Throw custom exception if age is too low
                    throw new AgeTooLowException("Age must be 18 or older to register.");
                }

                Console.WriteLine("✅ You are eligible to register!");
            }
            catch (AgeTooLowException ex)
            {
                Console.WriteLine("❌ Custom Exception Caught: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("❌ Error: Invalid input. Enter a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ General Error: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
