using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage
{
    class EmpWageComputation
    {
        const int  FULL_DAY_HR = 8, PART_DAY_HR = 4, IS_FULLTIME = 1, IS_PARTTIME = 2;
        int totalEmpWage = 0, empHrs = 0, workingDays = 0;
        
        public int  ComputeEmpWage(string company,int wage_per_hr,int total_working_hrs,int working_day_month)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            while (workingDays < working_day_month && empHrs <= total_working_hrs)
            {
                workingDays = workingDays + 1;
                switch (empCheck)
                {
                    case IS_FULLTIME:
                        empHrs += FULL_DAY_HR;
                        break;
                    case IS_PARTTIME:
                        empHrs += PART_DAY_HR;
                        break;
                    default:
                        empHrs += 0;
                        break;
                }
                Console.WriteLine("emp hrs: " + empHrs);
            }
            //cal wages till workinghrs is 100 and workingdays is 20
            Console.WriteLine("working hrs: " + empHrs + ",working days:" + workingDays);
            totalEmpWage = empHrs * wage_per_hr;
                Console.WriteLine("Total employee wage for "+company+ " of "+working_day_month+ " days is :" + totalEmpWage);
            return totalEmpWage;
        }
    }
}
