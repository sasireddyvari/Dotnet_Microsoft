using System;

public class Program
{
    public static void Main()
    {
        decimal input1 = 723, input2 = 234, input3 = 345;
        string str = Convert.ToString(Convert.ToString(input1) + Convert.ToString(input2) + Convert.ToString(input3));
        long l = Convert.ToInt64(str);
        int count = 1, tempcount, tempnumber = 0, j, frequentnumber = 0;
        int[] arr = new int[str.Length];
        int k = 0;
        while (l != 0)
        {
            arr[k] = Convert.ToInt32(l % 10);
            k++;
            l /= 10;
        }
        for (int i = 0; i < (arr.Length); i++)
        {
            Console.Write(arr[i]);
        }
        for (int i = 0; i < (arr.Length); i++)
        {
            tempcount = 0;
            for (j = 0; j < (arr.Length); j++)
            {
                if (arr[i] == arr[j])
                {
                    tempcount++;
                    tempnumber = arr[i];
                }
                if (tempcount > count)
                {
                    frequentnumber = tempnumber;
                    count = tempcount;
                }
            }
        }
        Console.WriteLine(" " + frequentnumber);
    }
}