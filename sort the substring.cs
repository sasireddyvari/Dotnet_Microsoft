using System;

public class Program
{
    public static void Main()
    {
        int a;
        a = Convert.ToInt32(Console.ReadLine());
        while (a-- >= 0)
        {
            string str = Console.ReadLine();
            var str1 = str.Split(' ')[0];
            var str2 = str.Split(' ')[1];
            var str3 = str.Split(' ')[2];
            int startingindex = Convert.ToInt32(str2);
            int endingindex = Convert.ToInt32(str3);

            string l1 = str1.Substring(0, startingindex);
            string l2 = str1.Substring(startingindex, endingindex);
            char[] arr = l2.ToCharArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            string l3 = str1.Substring(endingindex + 1);
            string s = l1 + new string(arr) + l3;
            Console.WriteLine(s);
        }
    }
}