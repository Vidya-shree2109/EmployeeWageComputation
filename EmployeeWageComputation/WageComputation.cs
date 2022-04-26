using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        public const int IS_PART_TIME = 1, IS_FULL_TIME = 2;
        private int numberOfCompany = 0;
        private EmpWageBuilderObject[] companyEmpWageArray;
        public WageComputation()
        {
           this.companyEmpWageArray=new EmpWageBuilderObject[5];
        }
        public void AddCompanyEmpWage(string companyName, int empWagePerHr, int maxWorkingHr, int empWorkingDaysPerMonth)
        {
            companyEmpWageArray[this.numberOfCompany] = new EmpWageBuilderObject(companyName, empWagePerHr, maxWorkingHr, empWorkingDaysPerMonth);
            numberOfCompany++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < companyEmpWageArray.Length; i++)
            {
                companyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());
            }
        }
        private int ComputeEmpWage(EmpWageBuilderObject empWageBuilderObject)
        {
            int empHrs = 0, totalEmpSalary = 0, totalEmpHrs = 0, days = 0;
            while (days <= empWageBuilderObject.empWorkingDaysPerMonth && empHrs < empWageBuilderObject.empMaxWorkingHr)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs += 8;
                        break;
                    case IS_PART_TIME:
                        empHrs += 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                days++;
                totalEmpHrs += empHrs;
                Console.WriteLine("\nDays @ " + empWageBuilderObject.empWorkingDaysPerMonth + " , " + "empHours" + " = " + empHrs);
            }
            return totalEmpSalary = totalEmpHrs * empWageBuilderObject.empWagePerHr;
        }
    }
}