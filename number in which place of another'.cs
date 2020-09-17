using System;

public class Program
{
    public static void Main()
    {
        int num1, num2;
        Console.Write("Enter the Numbers:");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        int digit = 1;
        while (num1 != 0)
        {
            int temp;
            temp = num1 % 10;
            if (temp == num2)
                Console.WriteLine("digit is in {0} 's place", digit);
            digit = digit * 10;
            num1 /= 10;
        }
    }
}