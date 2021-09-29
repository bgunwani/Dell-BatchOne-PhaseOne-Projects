using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFour_Projects
{
    [Serializable]
    class Employee
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public int Age { get; set; }
    }

    class SeralizeDeseralize
    {
        public static void SeralizeObject(Employee employee)
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("D:\\data\\data.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(fileStream, employee);
            Console.WriteLine("Employee Object is Searlized.");
            fileStream.Close();
        }
        public static Employee DesearlizeObject()
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("D:\\data\\data.txt", FileMode.Open, FileAccess.Read);
            Employee employee = (Employee) formatter.Deserialize(fileStream);
            Console.WriteLine("Employee Object is desearlized.");
            fileStream.Close();
            return employee;
        }
    }
    class SearlizationExample
    { 
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Name = "Gautam",
                Salary = 12000,
                Age = 23
            };
            SeralizeDeseralize.SeralizeObject(employee);
            Console.WriteLine("****************");
            var empObj = SeralizeDeseralize.DesearlizeObject();
            Console.WriteLine("{0} : {1} : {2}", empObj.Name, empObj.Salary, empObj.Age);
            
        }
    }
}
