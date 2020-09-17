using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_3
{
    class Person
    {
        private string fname, lname, email;
        private DateTime dob;

        public Person(string f, string l, string e, string d)
        {
            fname = f;
            lname = l;
            email = e;
            dob = Convert.ToDateTime(d);
        }

        public bool Isadult()
        {
            int x = dob.Year;
            DateTime y = DateTime.Today;
            int z = y.Year;
            if (z - x > 18)
            {
                return true;
            }
            else
                return false;
        }

        public bool Isbday()
        {
            DateTime dt = DateTime.Now;

            if (DateTime.Today.Date == dob.Date)
            {
                //if(dt.Date==dob.Date)
                //{
                return true;
                //}
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Harsh", "Sharma", "harsh@gmail.com", "6/3/1997");

            if (p.Isadult() == true)
            {
                Console.WriteLine("ADult");
            }
            else
            {
                Console.WriteLine("not an adult");
            }

            if (p.Isbday() == true)
            {
                Console.WriteLine("Today is his birthday");
            }
            else
            {
                Console.WriteLine("Today is not his birthday");
            }

            Console.ReadKey();



        }
    }
}
