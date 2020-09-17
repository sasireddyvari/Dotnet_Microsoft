using System;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[6] { 1, 0, 5, 4, 3, 2 };
        int count = 1, maxlength = 0, seq = 0;
        for (int i = arr.Length - 1; i > 0; i--)
        {
            if (arr[i] < arr[i - 1])
                count++;
            else
            {
                if (count > maxlength)
                    maxlength = count;
                if (count > 1)
                {
                    seq++;
                    count = 1;
                }
            }

        }
        if (count > maxlength)
            maxlength = count;
        if (count > 1)
        {
            seq++;
            count = 1;
        }

        Console.WriteLine("{0},{1}", maxlength, seq);
    }
}