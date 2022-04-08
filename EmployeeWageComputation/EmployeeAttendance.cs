using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeAttendance
    {
        const int IS_PRESENT = 0,IS_FULL_TIME=1,EMP_RATE_PER_HOUR=20;
        int empHrs = 0, empWage = 0;
        public void EmployeeAttendence()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");

        }
        public void EmployeeWage()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if(check==IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage :" + empWage);
        }
    }

}

