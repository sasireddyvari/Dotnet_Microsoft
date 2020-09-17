using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter the string:");
        string str = Console.ReadLine();
        string rev = string.Empty;
        for (int i = str.Length; i > 0; i--)
        {
            rev += str[i - 1].ToString();
        }
        Console.Write("reversed string:");
        Console.WriteLine(rev);
        Console.Write("The substring in the given string from 2nd position:");
        Console.WriteLine(str.Substring(1));
        Console.Write("Enter the character to be replaced with $:");
        char c = Convert.ToChar(Console.ReadLine());
        char[] arr = str.ToCharArray();
        for (int i = 0; i < str.Length; i++)
        {
            if (c == arr[i])
            {
                arr[i] = '$';
            }
        }
        Console.Write("Replace with the $:");
        Console.WriteLine(new string(arr));
        string cop = string.Copy(str);
        Console.Write("Copied  string:");
        Console.WriteLine(cop);
        string modi = string.Concat(rev, cop);
        Console.Write("Modified copied string is {0} and the original string is {1}", modi, str);
    }
}