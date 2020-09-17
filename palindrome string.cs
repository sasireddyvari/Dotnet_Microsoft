using System;

public class Program
{
    public static void Main()
    {
        string str = Console.ReadLine();
        string rev = string.Empty;
        for (int i = str.Length; i > 0; i--)
        {
            rev += str[i - 1].ToString();
        }
        if (rev == str)
            Console.WriteLine("palindrome string");
        else
            Console.WriteLine("no");
    }
}