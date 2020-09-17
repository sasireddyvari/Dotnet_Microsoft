using System;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[] { 1, 3, 4, 5, 6, 7 };
        int count = 0;
        foreach (int i in arr)
        {
            count++;
        }
        Console.WriteLine("there are {0} number of elements ", count);

    }
}