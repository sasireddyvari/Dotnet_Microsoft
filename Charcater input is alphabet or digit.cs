using System;

public class Program
{
    public static void Main()
    {
        char c = Convert.ToChar(Console.ReadLine());
        if (c >= '0' && c <= '9')
            Console.WriteLine("the charcter is digit");
        else if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
            Console.WriteLine("the character is alphabet");
        else
            Console.WriteLine("the character isn't an alphabet or digit");

    }
}