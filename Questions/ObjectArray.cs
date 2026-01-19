using System;
using System.Collections.Generic;

public class Ques11
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine()!);

        object[] values = new object[n];

        Console.WriteLine("Enter values (can be int, bool, null, string):");

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine()!;

            if (input.Equals("null", StringComparison.OrdinalIgnoreCase))
            {
                values[i] = null!;
            }
            else if (int.TryParse(input, out int intVal))
            {
                values[i] = intVal;
            }
            else if (bool.TryParse(input, out bool boolVal))
            {
                values[i] = boolVal;
            }
            else
            {
                values[i] = input; // keep as string
            }
        }

        int sum = 0;

        foreach (var item in values)
        {
            if (item is int x)   // pattern matching
            {
                sum += x;
            }
        }

        Console.WriteLine("Sum of integers = " + sum);
    }
}
