using System;

public class Program
{
    public static void Main()
    {
        string str = Console.ReadLine();
        char[] ch = str.ToCharArray();
        for (int i = 0; i < str.Length; i++)
        {
            ch[i] = Convert.ToChar(Convert.ToInt32(ch[i]) + 1);
        }
        Console.Write(ch);
    }
}