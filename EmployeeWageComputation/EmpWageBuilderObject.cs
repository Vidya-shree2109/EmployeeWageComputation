using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilderObject
    {
        public string companyName;
        public int empWagePerHr;
        public int empMaxWorkingHr;
        public int empWorkingDaysPerMonth;
        public decimal totalEmpWage;
        public EmpWageBuilderObject(string companyName, int empWagePerHr, int empmaxWorkingHr, int empWorkingDaysPerMonth)
        {
            this.companyName = companyName;
            this.empWagePerHr = empWagePerHr;
            this.empMaxWorkingHr = empmaxWorkingHr;
            this.empWorkingDaysPerMonth = empWorkingDaysPerMonth;
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Employee wage for Company --> " + this.companyName + "=" + this.totalEmpWage;
        }
    }
}
