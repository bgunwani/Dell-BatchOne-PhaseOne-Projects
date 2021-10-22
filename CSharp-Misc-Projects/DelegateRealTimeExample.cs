/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Misc_Projects
{
    public delegate bool EligibleToPromotion(Employee employeeToPromotion);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        public static void PromoteEmployee(List<Employee> employees, EligibleToPromotion isEmployeeEligible)
        {
            foreach (var employee in employees)
            {
                if (isEmployeeEligible(employee))
                {
                    Console.WriteLine("Employee {0} promoted.", employee.Name);
                }
            }
        }
        public static bool Promote(Employee employee)
        {
            if(employee.Salary > 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class DelegateRealTimeExample
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee() { Id = 101, Name = "King", Gender = "Male", Experience = 5, Salary = 10000 };
            //Employee emp2 = new Employee() { Id = 102, Name = "Sarah", Gender = "Female", Experience = 10, Salary = 20000 };
            //Employee emp3 = new Employee() { Id = 103, Name = "Kochhar", Gender = "Male", Experience = 15, Salary = 30000 };
            //List<Employee> employeeList = new List<Employee>();
            //employeeList.Add(emp1);
            //employeeList.Add(emp2);
            //employeeList.Add(emp3);
            //EligibleToPromotion eligibleToPromotion = new EligibleToPromotion(Employee.Promote);
            //Employee.PromoteEmployee(employeeList, eligibleToPromotion);

            Employee emp1 = new Employee() { Id = 101, Name = "King", Gender = "Male", Experience = 5, Salary = 10000 };
            Employee emp2 = new Employee() { Id = 102, Name = "Sarah", Gender = "Female", Experience = 10, Salary = 20000 };
            Employee emp3 = new Employee() { Id = 103, Name = "Kochhar", Gender = "Male", Experience = 15, Salary = 30000 };
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);
            Employee.PromoteEmployee(employeeList, e => e.Salary > 10000);
            Console.ReadKey();
        }
        
    }
}
*/