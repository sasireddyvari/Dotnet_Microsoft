using System;

public class Program
{
    public static void Main()
    {
        string str;
        char temp;
        str = Console.ReadLine();
        char[] arr = str.ToCharArray();
        for (int i = 0; i < str.Length; i++)
        {
            // temp=arr[i];
            //int ascii=temp;
            //	ascii++;
            // arr[i]=(char)ascii;
            arr[i] = Convert.ToChar(Convert.ToInt32(arr[i]) + 1);
        }
        //Console.WriteLine(new string(arr));
        Console.WriteLine(new string(arr));
    }
}