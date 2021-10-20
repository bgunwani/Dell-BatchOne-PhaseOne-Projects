/*using System;

namespace CSharp_Misc_Projects
{
    class OutVariableExample
    {
        static void GetEmployeeDetails(out string EmpName, out string Gender, out string Department, out long EmpSalary)
        {
            EmpName = "Kartik";
            Gender = "Male";
            Department = "Admin";
            EmpSalary = 20000;
        }
        static void Main(string[] args)
        {
            GetEmployeeDetails(out var EmpName, out var Gender, out var Department, out _);
            Console.WriteLine("Employee Details : ");
            Console.WriteLine("{0} : {1} : {2}", EmpName, Gender, Department);
            Console.ReadKey();
        }
    }
}
*/