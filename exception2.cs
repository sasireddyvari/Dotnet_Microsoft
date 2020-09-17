using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_1
{

    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(String msg) : base(msg)
        {

        }
    }
    class Program
    {
        static void validate(int n)
        {
            if (n < 0)
            {
                throw new NegativeNumberException("NEGATIVE MARKS CANNOT BE INSERTED");
            }
        }

        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            string name;
            Console.Write("Enter the name : ");
            name = Console.ReadLine();

            Console.Write("Enter the marks of English :");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                validate(a);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong Input");
            }
            catch (NegativeNumberException e)
            {
                Console.WriteLine(e);
            }
            try
            {
                Console.Write("Enter the marks of Science :");
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input");
            }
            catch (NegativeNumberException e)
            {
                Console.WriteLine(e);
            }
            try
            {
                Console.Write("Enter the marks of Hindi :");
                c = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Wrong Input");
            }
            catch (NegativeNumberException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Marks in english : " + a);
            Console.WriteLine("Marks in english : " + b);
            Console.WriteLine("Marks in english : " + c);
            Console.ReadKey();
        }
    }
}
