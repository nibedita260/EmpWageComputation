using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage
{
    interface IEmpWageComputation
    {
        public int ComputeEmpWage(string company, int wage_per_hr, int total_working_hrs, int working_day_month);
    }
}
