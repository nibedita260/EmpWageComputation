using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage
{
    class EmpWageComputation
    {
        const int IS_PRESENT = 1, WAGE_PER_HOUR = 20, FULL_DAY_HR = 8, PART_DAY_HR = 4, IS_FULLTIME = 1, IS_PARTTIME = 2,WORKING_DAY_MONTH=20, TOTAL_WORKING_HRS=100;
        int totalEmpWage = 0, empHrs = 0, workingDays = 0;
        
        public void EmpWageCal()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            while (workingDays < WORKING_DAY_MONTH && empHrs <= TOTAL_WORKING_HRS)
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
            totalEmpWage = empHrs * WAGE_PER_HOUR;
                Console.WriteLine("Total emp wage is: "+totalEmpWage);
        }
    }
}
