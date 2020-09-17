using System;

public class Program
{
    public static void Main()
    {
        int countalpha = 0, countnum = 0, countspl = 0;
        string str;
        str = Console.ReadLine().ToUpper();
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= '0' && str[i] <= '9')
                countnum++;
            else if (str[i] >= 'A' && str[i] <= 'Z')
                countalpha++;
            else
                countspl++;
        }
        Console.WriteLine("The number of digits is {0} in the given string ", countnum);
        Console.WriteLine("The number of alphabets is {0} in the given string ", countalpha);
        Console.WriteLine("The number of spl characters is {0} in the given string ", countspl);
    }
}