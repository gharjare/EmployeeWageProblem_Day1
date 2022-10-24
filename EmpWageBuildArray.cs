using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public  class EmpWageBuildArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public int numofCompany = 0;

        public int[] a = new int[5];
        public CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuildArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addcompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursePerMonth)
        {
            companyEmpWageArray[this.numofCompany] = new CompanyEmpWage(company, empRatePerHour, numofWorkingDays,maxHoursePerMonth);
            numofCompany++;

        }
        public void computeEmpWage()
        {
            for(int i = 0;i<numofCompany;i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].tostring());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            
            return 0;

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            

            while(totalEmpHrs <= companyEmpWage.maxHoursePerMonth && totalWorkingDays < companyEmpWage.numofWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch(empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = empHrs;
                Console.WriteLine("Day # :" + totalWorkingDays + "Emp Hrs:" + empHrs);
            }
        }
    }
}
