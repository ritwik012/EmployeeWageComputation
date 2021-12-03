using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Problem");
            EmployeeWageProblem.monthlyEmployeeWage("PVP", 20, 20, 100);
            EmployeeWageProblem.monthlyEmployeeWage("DMART", 30, 24, 140);
        }
    }
}