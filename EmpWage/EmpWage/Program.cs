using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageComputation empWageComputation = new EmpWageComputation();
            Console.WriteLine(empWageComputation.ComputeEmpWage("bridgelabz",20,100,20));
            Console.WriteLine(empWageComputation.ComputeEmpWage("Google", 100, 100, 20));
        }
    }
}
