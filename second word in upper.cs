using System;

public class Program
{
    public static void Main()
    {
        string str = Console.ReadLine();
        string[] words = str.Split(' ');
        string word1;
        if (words[1] == "\0")
        {
            Console.WriteLine("Less");
        }
        else
        {
            word1 = words[1].ToUpper();
            Console.WriteLine(word1);
        }
    }
}