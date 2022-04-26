using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilderObject
    {
        public string CompanyName { get; set; }
        public int EmpWagePerHr { get; set; }
        public int EmpMaxWorkingHr { get; set; }
        public int EmpWorkingDayPerMonth { get; set; }
        public decimal TotalEmpWage { get; set; }

    }
}