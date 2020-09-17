using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_1
{
    public interface IPayable
    {
        void Calculatepay();
    }


    class HourlyEmployee : IPayable
    {
        double hoursworks;
        double payperhour;

        public void Calculatepay()
        {
            Console.WriteLine("Enter the hours worked : ");
            hoursworks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the payperhour : ");
            payperhour = Convert.ToDouble(Console.ReadLine());
            double sal = hoursworks * payperhour;

            Console.WriteLine("Salary is {0} : ", sal);
        }
    }

    class PermanentEmployee : IPayable
    {
        double totalpay, hra, da, tax, netpay, gs;

        public void Calculatepay()
        {
            Console.WriteLine("Enter the Total salary : ");
            totalpay = Convert.ToDouble(Console.ReadLine());
            hra = 15 * totalpay / 100;
            da = 10 * totalpay / 100;
            gs = hra + da + totalpay;
            tax = 8 * gs / 100;

            Console.WriteLine("HRA : {0}\nDA : {1}\nGS : {2}\nTAX : {3}", hra, da, gs, tax);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPayable ip;
            //ip = new HourlyEmployee();


            Console.WriteLine("Press 1 for HOURLY EMPLOYEE\nPress 2 for PERMANENT EMPLOYEE");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    ip = new HourlyEmployee();
                    ip.Calculatepay();
                    break;
                case 2:
                    ip = new PermanentEmployee();
                    ip.Calculatepay();
                    break;
            }
            Console.ReadKey();
        }
    }
}
