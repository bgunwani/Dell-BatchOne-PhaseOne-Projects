/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Misc_Projects
{
    public interface IEmployee
    {
        void EmployeeMethod();
    }
    public interface ICustomer
    {
        void CustomerMethod();
    }
    public partial class PartialClass : IEmployee
    {
        partial void PartialMethod();
        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked.");
            PartialMethod();
        }
        public void EmployeeMethod()
        {
            Console.WriteLine("Employee Method Invoked.");
        }
    }
    public partial class PartialClass : ICustomer
    {
        partial void PartialMethod()
        {
            Console.WriteLine("Partial Method Invoked from Public Method.");
        }
        public void CustomerMethod()
        {
            Console.WriteLine("Customer Method Invoked.");
        }
    }
    class PartialClassExample
    {
        static void Main(string[] args)
        {
            PartialClass partialClass = new PartialClass();
            partialClass.CustomerMethod();
            partialClass.EmployeeMethod();
            partialClass.PublicMethod();
            Console.ReadKey();
        }
    }
}
*/