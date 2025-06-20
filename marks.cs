using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] marks = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter marks for student {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }

        int min = marks[0];
        int max = marks[0];
        int sum = 0;

        // Find min, max and total
        for (int i = 0; i < n; i++)
        {
            if (marks[i] < min)
                min = marks[i];
            if (marks[i] > max)
                max = marks[i];

            sum += marks[i];
        }

      
        double average = (double)sum / n;

       
        Console.WriteLine($"\nMinimum marks: {min}");
        Console.WriteLine($"Maximum marks: {max}");
        Console.WriteLine($"Average marks: {average:F2}");
    }
}
