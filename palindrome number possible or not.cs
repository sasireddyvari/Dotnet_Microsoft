using System;

public class Program
{
    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int temp1 = a, l1 = 0;
        while (temp1 != 0)
        {
            temp1 /= 10;
            l1++;
        }
        int[] arr = new int[l1];
        for (int i = 0; i < l1; i++)
        {
            arr[i] = a % 10;
            a /= 10;
        }
        int[] count = new int[l1];
        int tempcount, num, c = 0;
        for (int i = 0; i < l1; i++)
        {
            num = arr[i];
            for (int j = 0; j < l1; j++)
            {
                if (num == arr[j])
                {
                    c++;
                    count[i] = c;
                }
            }
        }
        int oddoccur = 0, evenoccur = 0;
        Console.WriteLine(count.Length);
        for (int i = 0; i < l1; i++)
        {
            if ((count[i] % 2) != 0)
                oddoccur++;
            else
                evenoccur++;
        }
        Console.WriteLine(oddoccur);
        Console.WriteLine(evenoccur);
        Console.WriteLine(l1);
        if ((l1 % 2) == 0)
        {
            if (oddoccur >= 1)
                Console.WriteLine("the palindrome canot");
            else
                Console.WriteLine("can can");
        }
        else
        {
            if ((evenoccur % 2) == 0)
                Console.WriteLine("can form");
            else
                Console.WriteLine("Palindrome cannot");
        }

    }
}