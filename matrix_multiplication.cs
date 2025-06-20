using System;

class Program
{
    static void Main()
    {
        int[,] A = new int[10, 10];
        int[,] B = new int[10, 10];
        int[,] C = new int[10, 10];

        int r1, c1, r2, c2;

        Console.Write("Enter number of rows for Matrix A: ");
        r1 = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns for Matrix A: ");
        c1 = int.Parse(Console.ReadLine());

        Console.Write("Enter number of rows for Matrix B: ");
        r2 = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns for Matrix B: ");
        c2 = int.Parse(Console.ReadLine());

        if (c1 != r2)
        {
            Console.WriteLine("Matrix multiplication not possible. Columns of A must equal rows of B.");
            return;
        }

        // Input Matrix A
        Console.WriteLine("\nEnter elements of Matrix A:");
        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c1; j++)
            {
                Console.Write($"A[{i},{j}]: ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Input Matrix B
        Console.WriteLine("\nEnter elements of Matrix B:");
        for (int i = 0; i < r2; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                Console.Write($"B[{i},{j}]: ");
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                C[i, j] = 0;
                for (int k = 0; k < c1; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        Console.WriteLine("\nResult of Matrix Multiplication (A x B):");
        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                Console.Write(C[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
