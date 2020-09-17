using System;

public class Program
{
    public static void Main()
    {
        string str = Console.ReadLine().ToUpper();
        int input = Convert.ToInt32(Console.ReadLine());
        char[] ch = str.ToCharArray();
        int weight = 0, temp = 0;
        for (int i = 0; i < ch.Length; i++)
        {
            if (ch[i] >= 'A' && ch[i] <= 'Z' || ch[i] == ' ')
                weight = weight + (Convert.ToInt32(ch[i]) - 64);
        }
        for (int i = 0; i < ch.Length; i++)
        {
            if (ch[i] == 'A' || ch[i] == 'E' || ch[i] == 'I' || ch[i] == 'O' || ch[i] == 'U')
                temp = temp + (Convert.ToInt32(ch[i]) - 64);
        }
        if (input == 0)
        {
            weight = weight - temp;
        }
        Console.WriteLine(weight);
    }
}