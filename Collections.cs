using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Collection_1
{
    public class Employee
    {
        public int emplid;
        public string empname;
        public double salary;



    }

    class EmployeeDAL : Employee
    {
        ArrayList name = new ArrayList();
        ArrayList id = new ArrayList();
        ArrayList sal = new ArrayList();

        public bool AddEmployee()
        {
            Console.WriteLine("Enter the name :");
            empname = Console.ReadLine();
            Console.Write("Enter the ID:");
            emplid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the salary");
            salary = Convert.ToDouble(Console.ReadLine());

            name.Add(empname);
            id.Add(emplid);
            sal.Add(salary);

            return true;

        }

        public bool DelEmployee()
        {
            Console.WriteLine("Enter the employee id:");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = id.IndexOf(i);
            name.RemoveAt(j);
            id.RemoveAt(j);
            sal.RemoveAt(j);
            return true;


        }

        public void SearchEmployee()
        {
            Console.WriteLine("Enter the employee's id:");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = id.IndexOf(i);

            Console.WriteLine("Employee information : \nID : {0}\nNAME:{1}\nSALARY:{2}", id[j], name[j], sal[j]);

        }

        public void EmployeeList()
        {
            for (int i = 0; i < name.Count; i++)
            {
                Console.Write(name[i] + " ");
                Console.Write(id[i] + " ");
                Console.Write(sal[i] + " ");
            }
        }

    }

    class Program : EmployeeDAL
    {
        static void Main(string[] args)
        {
            //string s1;
            EmployeeDAL empd = new EmployeeDAL();


            int num;
            do
            {
                Console.WriteLine("Press 1. To Add Employee Name");
                Console.WriteLine("Press 2. To Delete Employee");
                Console.WriteLine("Press 3. To Search Employee");
                Console.WriteLine("Press 4. TO get the Employee List");

                Console.WriteLine("Enter your choice : ");
                num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1: empd.AddEmployee(); break;
                    case 2: empd.DelEmployee(); break;
                    case 3: empd.SearchEmployee(); break;
                    case 4: empd.EmployeeList(); break;
                    case 5: break;
                }

            } while (num != 5);


            Console.Read();
        }
    }
}
