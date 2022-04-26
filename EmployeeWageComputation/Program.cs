using System;
using EmployeeWageComputation;
class Program
{
    public static void Main(String[] args)
    {
        WageComputation company = new WageComputation();
        company.ComputeEmpWage();
    }
}