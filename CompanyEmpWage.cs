using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numofWorkingDays;
        public int maxHoursePerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour,int numofWorkingDays,int maxHoursePerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHoursePerMonth = maxHoursePerMonth;
            this.totalEmpWage = totalEmpWage;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string tostring()
        {
            return "Total Emp Wage for company:" + this.company + "is:" + this.totalEmpWage;
        }
    }
}
