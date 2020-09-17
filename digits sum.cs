using System;

public class Program
{
    public static void Main()
    {
        int n = 546;
        int sum = 0;
        while (n != 0 || sum > 9)
        {
            if (n == 0)
            {
                n = sum;
                sum = 0;
            }
            sum = sum + (n % 10);
            n /= 10;
        }
        Console.WriteLine(sum);
    }
}