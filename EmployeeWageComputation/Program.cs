using System;
using EmployeeWageComputation;
class Program
{
    private static string companyName;
    private static int empWagePerHr;
    private static int empmaxWorkingHr;
    private static int empWorkingDaysPerMonth;

    public static void Main(String[] args)
    {
        WageComputation company = new WageComputation();
        EmpWageBuilderObject wage = new EmpWageBuilderObject(companyName, empWagePerHr, empmaxWorkingHr, empWorkingDaysPerMonth);
        company.AddCompanyEmpWage("SAMSUNG", 400, 200, 20);
        company.AddCompanyEmpWage("RELIANCE", 500, 100, 15);
        company.AddCompanyEmpWage("AIRTEL", 600, 150, 18);
       // company.ComputeEmpWage();
        Console.WriteLine(wage.toString());
    }
}