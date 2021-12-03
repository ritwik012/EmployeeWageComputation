using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Problem");
            EmpWageBuilder dMart = new EmpWageBuilder("DMart", 20, 20, 100);
            EmpWageBuilder pvp = new EmpWageBuilder("PVP", 25, 24, 160);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            pvp.computeEmpWage();
            Console.WriteLine(pvp.toString());
        }
    }
}