using System;

public class Program
{
    public static void Main()
    {
        string str;
        str = Console.ReadLine();
        char[] ch = str.ToCharArray();
        for (int i = 0; i < str.Length; i++)
        {
            if (ch[0] >= 'a' && ch[0] <= 'z')
                ch[0] = (char)(ch[0] - 'a' + 'A');
            else if (ch[i] >= 'A' && ch[i] <= 'Z')
                ch[i] = (char)(ch[i] + 'a' - 'A');

        }
        Console.WriteLine(ch);

    }
}