﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage
{
    class EmpWageComputation
    {
        const int IS_PRESENT = 1, WAGE_PER_HOUR = 20, FULL_DAY_HR = 8,PART_DAY_HR=4;
        int totalEmpWage=0;
        
        public void EmpWageCal()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                totalEmpWage = WAGE_PER_HOUR * PART_DAY_HR;
            else
                totalEmpWage = 0;
            Console.WriteLine("Total emp wage is: " +totalEmpWage);

        }
    }
}
