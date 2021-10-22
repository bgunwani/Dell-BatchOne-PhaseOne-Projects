/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Misc_Projects
{
    public class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        public static bool GetEmployee(Employee employee)
        {
            return employee.Id == 101;
        }
    }
    class AnnonymousMethodExample
    {
        static void Main(string[] args)
        {

            //Predicate<Employee> employeePredicate = new Predicate<Employee>(Employee.GetEmployee);
            //List<Employee> employeeList = new List<Employee>();
            //employeeList.Add(new Employee() { Id = 101, Name = "King", Gender = "Male", Experience = 5, Salary = 10000 });
            //employeeList.Add(new Employee() { Id = 102, Name = "Sarah", Gender = "Female", Experience = 10, Salary = 20000 });
            //employeeList.Add(new Employee() { Id = 103, Name = "Kochhar", Gender = "Male", Experience = 15, Salary = 30000 });
            //Employee employee = employeeList.Find(x => employeePredicate(x));
            //Console.WriteLine($"Id : {employee.Id}, Name: {employee.Name}, Salary: ${employee.Salary}");

            Predicate<Employee> employeePredicate = new Predicate<Employee>(Employee.GetEmployee);
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { Id = 101, Name = "King", Gender = "Male", Experience = 5, Salary = 10000 });
            employeeList.Add(new Employee() { Id = 102, Name = "Sarah", Gender = "Female", Experience = 10, Salary = 20000 });
            employeeList.Add(new Employee() { Id = 103, Name = "Kochhar", Gender = "Male", Experience = 15, Salary = 30000 });
            Employee employee = employeeList.Find(
                delegate(Employee x) 
                {
                    return x.Id == 101;
                    }
                );
            Console.WriteLine($"Id : {employee.Id}, Name: {employee.Name}, Salary: ${employee.Salary}");
            Console.ReadKey();
        }
    }
}
*/