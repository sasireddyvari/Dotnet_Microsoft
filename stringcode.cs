using System;

public class Program
{
    public static void Main()
    {
        string str = Console.ReadLine().ToUpper();
        string[] s = str.Split();
        int l = s.Length;
        int k, temp, d;
        int[] sum = new int[l];
        char[] ch = new char[10];
        for (int i = 0; i < l; i++)
        {
            k = s[i].Length;
            ch = s[i].ToCharArray();
            for (int j = 0; j < (s[i].Length) / 2; j++)
            {
                temp = ch[j] - ch[k - 1];
                d = temp > 0 ? temp : -temp;
                sum[i] += d;
                k--;
            }
            if (((s[i].Length) % 2) != 0)
            {
                sum[i] += (ch[(s[i].Length / 2)] - 64);
            }
        }
        string code = String.Empty;
        for (int i = 0; i < sum.Length; i++)
        {
            code += sum[i];
        }
        Console.WriteLine(code);


    }
}