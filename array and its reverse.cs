using System;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter the array Elements:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("element {0}:", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 10; i++)
            Console.Write(" " + arr[i]);
        Array.Reverse(arr);
        Console.WriteLine("\nthe array after reversing:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(arr[i]);
        }
    }
}