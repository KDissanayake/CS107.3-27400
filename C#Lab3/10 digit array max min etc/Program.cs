using System;

public class ArrayOperations
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        Console.WriteLine("Enter 10 integer values:");

        // Input values to the array
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Value " + (i + 1) + ": ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Minimum value: " + FindMinimum(array));
        Console.WriteLine("Maximum value: " + FindMaximum(array));
        Console.WriteLine("Average value: " + CalculateAverage(array));

        Console.WriteLine("Array in reverse order:");
        ReverseArray(array);
        PrintArray(array);
    }
            
     // Print the elements of the array
    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
    }
}
