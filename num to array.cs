using System;

public class Program
{
    public static void Main()
    {
        int a = 2345612;
        string str = Convert.ToString(a);
        char[] arr = str.ToCharArray();
        Console.WriteLine(arr);
        int b = Convert.ToInt32(arr[0] + "" + arr[1]);
        Console.WriteLine(b);
    }
}