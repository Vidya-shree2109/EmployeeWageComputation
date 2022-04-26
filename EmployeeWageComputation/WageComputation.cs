using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int PART_TIME_EMP = 1;
        const int FULL_TIME_EMP = 2;
        int empHrs = 0, totalEmpSalary = 0, totalEmpHrs = 0, day = 0;
        ArrayList compEmpWageList = new ArrayList();
        public WageComputation()
        {
            Console.WriteLine("Enter :\nCompany Name\nEmpWage Working Per Hours\nTotal Working Hours\nTotal Working Days In Month");
            EmpWageBuilderObject company1 = new EmpWageBuilderObject()
            {
                CompanyName = Console.ReadLine(),
                EmpWagePerHr = Convert.ToInt32(Console.ReadLine()),
                EmpMaxWorkingHr = Convert.ToInt32(Console.ReadLine()),
                EmpWorkingDayPerMonth = Convert.ToInt32(Console.ReadLine()),
                TotalEmpWage = 0
            };
            Console.WriteLine("Enter the Company_Name \n EmpWage_Working_Pr_Hours \n Total_Working_Hours \n Total_Working_Das_In_Month");
            EmpWageBuilderObject company2 = new EmpWageBuilderObject()
            {
                CompanyName = Console.ReadLine(),
                EmpWagePerHr = Convert.ToInt32(Console.ReadLine()),
                EmpMaxWorkingHr = Convert.ToInt32(Console.ReadLine()),
                EmpWorkingDayPerMonth = Convert.ToInt32(Console.ReadLine()),
                TotalEmpWage = 0
            };
            compEmpWageList.Add(company1);
            compEmpWageList.Add(company2);
        }
        public void ComputeEmpWage()
        {
            foreach (EmpWageBuilderObject empWageBuilderObject in this.compEmpWageList)
            {
                this.ComputeEmpWage(empWageBuilderObject);
                empWageBuilderObject.TotalEmpWage = this.totalEmpSalary;
                Console.WriteLine("Total Employee salary of One Employee  " + empWageBuilderObject.TotalEmpWage);
            }
        }
        private void ComputeEmpWage(EmpWageBuilderObject empWageBuilderObject)
        {
            while (day <= empWageBuilderObject.EmpWorkingDayPerMonth && empHrs < empWageBuilderObject.EmpMaxWorkingHr)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case FULL_TIME_EMP:
                        empHrs += 8;
                        break;
                    case PART_TIME_EMP:

                        empHrs += 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                day++;
                totalEmpHrs += empHrs;
                Console.WriteLine("Days @" + empWageBuilderObject.EmpWorkingDayPerMonth + "empHours " + empHrs);
            }
            totalEmpSalary = totalEmpHrs * empWageBuilderObject.EmpWagePerHr;

        }
    }
}