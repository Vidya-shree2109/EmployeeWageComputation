using System;
using EmployeeWageComputation;
class Program
{
    public static void Main(String[] args)
    {
        WageComputation company = new WageComputation();
        company.AddCompanyEmpWage("SAMSUNG", 400, 200, 20);
        company.AddCompanyEmpWage("RELIANCE", 500, 100, 15);
        company.AddCompanyEmpWage("AIRTEL", 600, 150, 18);
        company.ComputeEmpWage();
        Console.WriteLine(company.ToString());
    }
}