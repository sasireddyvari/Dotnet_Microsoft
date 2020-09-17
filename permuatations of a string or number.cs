using System;

public class Program
{

    public static void Main()
    {
        string str = "121";
        char temp;
        char[] ch = str.ToCharArray();
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 1; j < str.Length; j++)
            {
                temp = ch[j];
                ch[j] = ch[j - 1];
                ch[j - 1] = temp;
                Console.WriteLine(new string(ch));
            }
        }
    }
}