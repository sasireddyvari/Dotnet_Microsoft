using System;

public class Program
{
    public static void Main()
    {
        string str = Console.ReadLine();
        /*
		string[] rm=str.Split();
		string rmm="";
		for(int i=0;i<rm.Length;i++)
		{
			rmm+=rm[i].ToString();
		}
		Console.WriteLine(rmm);
		*/
        string rmm;
        rmm = str.Replace(" ", String.Empty);
        Console.WriteLine(rmm);
    }
}