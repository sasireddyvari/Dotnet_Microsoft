using System;
class Employee
{
    string EmployeeName;
    double BasicSalary, HRA, DA, TAX, GrossSalary, NetSalary;
    public Employee(String Name, int salary)
    {
        EmployeeName = Name;
        BasicSalary = salary;
    }
    public void CalculateNetpay()
    {
        HRA = 0.15 * (BasicSalary);
        DA = 0.1 * BasicSalary;
        GrossSalary = (BasicSalary + HRA + DA);
        TAX = 0.08 * (GrossSalary);
        NetSalary = (GrossSalary - TAX);
    }
    public void Display()
    {
        Console.WriteLine("Salary details of {0}", EmployeeName);
        Console.WriteLine("Basic Salary:{0} ", BasicSalary);
        Console.WriteLine("HRA         :{0} ", HRA);
        Console.WriteLine("DA          :{0} ", DA);
        Console.WriteLine("GrossSalary :{0} ", GrossSalary);
        Console.WriteLine("TAX         :{0} ", TAX);
        Console.WriteLine("NetSalary   :{0} ", NetSalary);
    }
}

public class Program
{
    public static void Main()
    {
        Employee sasi = new Employee("Sasi", 200000);
        sasi.CalculateNetpay();
        sasi.Display();
    }
}