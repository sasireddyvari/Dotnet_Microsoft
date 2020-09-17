using System;

public class Program
{
    public static void Main()
    {
        int k = 0, input1 = 82323443;
        string str = Convert.ToString(input1);
        int[] arr = new int[str.Length];
        int sum = 0;
        while (input1 != 0)
        {
            arr[k] = input1 % 10;
            k++;
            sum += input1 % 10;
            input1 /= 10;

        }
        int count = arr.Length;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length - 1; j++)
            {
                if (arr[i] == arr[j + 1])
                {
                    --count;
                    sum = sum - arr[j + 1];
                    break;
                }
            }
        }
        Console.WriteLine(count);
        Console.WriteLine(sum);
    }
}