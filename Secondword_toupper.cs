using System;

public class second_word_to_upper
{
    public static void Main()
    {
        string str;
        str = Console.ReadLine();
        string[] split = str.Split(' ');
        if (split.Length > 1)
            Console.WriteLine(split[1].ToUpper());
        else
            Console.WriteLine("Please give the input with space and atleast two words");
    }
}