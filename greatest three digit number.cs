using System;

public class Program
{
    public static void Main()
    {
        int a = 5346;
        string str = Convert.ToString(a);
        char[] ch = str.ToCharArray();
        Array.Sort(ch);
        Array.Reverse(ch);
        Console.WriteLine(ch);
        Console.WriteLine(ch[0] + "" + ch[1] + "" + ch[2]);
    }
}