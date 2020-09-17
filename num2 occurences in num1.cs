using System;

public class Program
{
    public static void Main()
    {
        long num1, num2;
        Console.Write("Enter the Numbers num1 and num2:");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (num1 != 0)
        {
            long temp;
            temp = num1 % 10;
            if (temp == num2)
                count++;
            num1 /= 10;
        }
        Console.WriteLine("{0} has occured {1} times", num2, count);
    }
}