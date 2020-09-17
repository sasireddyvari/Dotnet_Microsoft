using System;

public class Program
{
    public static void Main()
    {
        int num1, num2, temp;
        Console.WriteLine("Enter the value of num1:");
        num1 = Convert.ToInt32(Console.ReadLine());
        temp = num1;
        num2 = ++num1;
        int temp1;
        temp1 = num2;
        Console.Write("the value of num2 when  assigning num1 by preincrementing :");
        Console.WriteLine(num2);
        num2 = temp++;
        Console.Write("the value of num2 when  assigning num1 by postincrementing :");
        Console.WriteLine(num2);
        Console.Write("after swapping the num2 values are ");
        int temp2;
        temp2 = num2;
        Console.WriteLine("{0} {1}", temp2, temp1);
    }
}