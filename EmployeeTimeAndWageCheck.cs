using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public static class EmployeeTimeAndWageCheck

    {
        
        public static void CheckTimeAndWage()
        {
           const int Is_Full_Time = 1;
           const  int Is_Part_Time = 2;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;


            Random random = new Random();
            int empcheck = random.Next(3);
            switch(empcheck)
            {
                case Is_Full_Time:
                    Console.WriteLine("Employee is full time");
                    empHrs = 8;
                    break;
                case Is_Part_Time:
                    Console.WriteLine("Employee is part time");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    empHrs = 0;
                    break;
            }
            
            
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
