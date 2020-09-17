using System;

public class Program
{
    public static void Main()
    {
        int a = 234521;
        int[] arr = new int[6];
        for (int i = 0; i < 6; i++)
        {
            arr[i] = a % 10;
            a /= 10;
        }
        Array.Sort(arr);
        for (int i = 0; i < arr.Length; i++)
            Console.WriteLine(+arr[i]);
        //Console.WriteLine( arr[0] + arr[1]);
    }
}