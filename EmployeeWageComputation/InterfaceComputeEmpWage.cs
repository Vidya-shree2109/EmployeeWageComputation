using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface InterfaceComputeEmpWage
    {
        public void AddCompanyEmpWage(string company_Name, int emp_Wage_PR_Hr, int max_Working_Hr, int emp_Working_Days_Pr_Month);
        public void ComputeEmpWage();
        public int GetTotalEmpWage(string companyName);


    }
}