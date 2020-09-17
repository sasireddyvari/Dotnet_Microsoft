using System;

public class Program
{
    public static void Main()
    {
        int s;
        double Area;
        Console.Write("Enter the side of the square:");
        s = Convert.ToInt32(Console.ReadLine());
        Console.Write("area of the square:");
        Area = s * s;
        Console.WriteLine(Area);
        Console.ReadLine();
    }
}