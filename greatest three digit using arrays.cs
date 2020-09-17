using System;
public class Program
{
    public static void Main()

    {
        int a = 100, b = 321;
        int temp1 = a, temp2 = b, l1 = 0, l2 = 0;
        while (temp1 != 0)
        {
            temp1 /= 10;
            l1++;
        }
        while (temp2 != 0)
        {
            temp2 /= 10;
            l2++;
        }
        int[] arr1 = new int[l1];
        int[] arr2 = new int[l2];
        for (int i = 0; i < l1; i++)
        {
            arr1[i] = a % 10;
            a /= 10;
        }
        for (int i = 0; i < l2; i++)
        {
            arr2[i] = b % 10;
            b /= 10;
        }
        Array.Sort(arr1);
        Array.Reverse(arr1);
        Array.Sort(arr2);
        Array.Reverse(arr2);
        int temp3, temp4;
        temp3 = (arr1[0] * 100) + (arr1[1] * 10) + arr1[2];
        temp4 = (arr2[0] * 100) + (arr2[1] * 10) + arr2[2];
        Console.WriteLine("The Sum of Largest 3 Digit Number Formed from the given numbers is " + (temp3 + temp4));
    }
}