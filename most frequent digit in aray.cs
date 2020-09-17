using System;

namespace DevApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[6] { 5, 5, 3, 5, 3, 3 };
            int count = 1, tempCount;
            int frequentNumber = array[0];
            int tempNumber = 0;
            for (int i = 0; i < (array.Length - 1); i++)
            {
                tempNumber = array[i];
                tempCount = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (tempNumber == array[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequentNumber = tempNumber;
                    count = tempCount;
                }
            }
            Console.WriteLine("The most frequent number in this array is {0} has been repeated {1} times.", frequentNumber, count);
            Console.ReadLine();
        }
    }
}