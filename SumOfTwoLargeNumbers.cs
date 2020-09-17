using System;

public class Program
{
    public static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int n1 = a.Length;
        int n2 = b.Length;
        char[] ch1 = a.ToCharArray();
        Array.Reverse(ch1);
        char[] ch2 = b.ToCharArray();
        Array.Reverse(ch2);
        string res = "";
        a = new string(ch1);
        b = new string(ch2);
        int sum, carry = 0;
        if (n1 > n2)
        {
            string t = a;
            a = b;
            b = t;
        }
        for (int i = 0; i < n1; i++)
        {
            sum = (int)(a[i] - '0') + ((int)b[i] - '0') + carry;
            res += (char)((sum % 10) + '0');
            carry = sum / 10;
        }
        for (int i = n1; i < n2; i++)
        {
            sum = (int)(a[i] - '0') + ((int)b[i] - '0') + carry;
            res += (char)((sum % 10) + '0');
            carry = sum / 10;
        }
        if (carry > 0)
        {
            res += (char)carry;
        }
        char[] ch = res.ToCharArray();
        Array.Reverse(ch);
        res = new String(ch);
        Console.WriteLine(res);
    }
}