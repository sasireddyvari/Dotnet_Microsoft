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
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("the sum of the array elements is {0}", sum);
    }
}