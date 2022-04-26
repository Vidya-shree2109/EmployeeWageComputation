using System;
using EmployeeWageComputation;
class Program
{
    public static void Main(String[] args)
    {
        WageComputation company = new WageComputation();
        Console.WriteLine("Enter :\nThe Company Name\nEmpWage Working Per Hours\nTotal Working Hours\nTotal Working Days In Month");
        string compName = Console.ReadLine();
        int EmpWageWorkingPerHours = Convert.ToInt32(Console.ReadLine());
        int TotalWorkingHours = Convert.ToInt32(Console.ReadLine());
        int TotalWorkingDaysInMonth = Convert.ToInt32(Console.ReadLine());
        company.AddCompanyEmpWage(compName, EmpWageWorkingPerHours, TotalWorkingHours, TotalWorkingDaysInMonth);
        company.ComputeEmpWage();
        Console.WriteLine("Total wage for" + compName + ":" + " " + company.GetTotalEmpWage(compName));
    }
}