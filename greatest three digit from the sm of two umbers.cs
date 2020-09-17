using System;

public class Program
{
    public static void Main()
    {
        int a = 5346, b = 8713;
        string str1 = Convert.ToString(a);
        string str2 = Convert.ToString(b);
        char[] ch1 = str1.ToCharArray();
        char[] ch2 = str2.ToCharArray();
        Array.Sort(ch1);
        Array.Sort(ch2);
        Array.Reverse(ch1);
        Array.Reverse(ch2);
        Console.WriteLine(ch1);
        Console.WriteLine(ch2);
        int c = Convert.ToInt32(ch1[0] + "" + ch1[1] + "" + ch1[2]);
        int d = Convert.ToInt32(ch2[0] + "" + ch2[1] + "" + ch2[2]);
        Console.WriteLine(c + d);
    }
}