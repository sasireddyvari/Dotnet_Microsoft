using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePerson
{
    class Person
    {
        string FirstName, Lastname, EmailAddress;
        DateTime DateOfBirth;
        public int age;

        public Person(string a, string b, string c, DateTime dateofbirth)
        {
            FirstName = a;
            Lastname = b;
            EmailAddress = c;
            DateOfBirth = dateofbirth;
            age = DateTime.Now.Year - dateofbirth.Year;


        }
        public bool IsAdult()
        {
            if (age >= 18)
                return true;
            else
                return false;
        }
        // public string SunSign(DateTime dateofbirth)
        //{
        //  if (dateofbirth.Month >= && dateofbirth <=)
        //        return " ";
        //}
        public bool IsBirthday(DateTime dateofbirth)
        {
            if (DateTime.Today.Day == dateofbirth.Day)
                return true;
            else
                return false;

        }
        public string ScreenName(string fname, DateTime dateofbirth)
        {
            return fname.Substring(0, 2) + dateofbirth.Month + dateofbirth.Year;
        }
    }
    class Employee : Person
    {
        public Employee(string a, string b, string c, DateTime dateofbirth) : base(a, b, c, dateofbirth)
        {

        }
        double salary;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee sasi = new Employee("sasi", "reddyvari", "sasi1997@gmail.com", new DateTime(1997, 11, 24));
            sasi.IsAdult();
            sasi.IsBirthday(new DateTime(2019, 06, 06));
            Console.ReadLine();
        }
    }
}
