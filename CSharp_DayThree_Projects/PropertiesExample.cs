/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayThree_Projects
{
    class Student
    {
        private int _studentId;
        private string _studentName;
        private int _studentAge;
        public string City { get; set; }
        

        public Student()
        {
            this._studentId = 1001;
        }

        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }
        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }
        public int StudentAge
        {
            get { return _studentAge; }
            set
            {
                if(value < 18)
                {
                    // throw new Exception("Invalid Age");
                    Console.WriteLine("Age is not valid.");
                }
                else
                {
                    _studentAge = value;
                }
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Student Id : {0}", this._studentId);
            Console.WriteLine("Student Name : {0}", this._studentName);
            Console.WriteLine("Student Name : {0}", this._studentAge);
        }
    }
    class PropertiesExample
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.StudentId = 101;
            student.StudentName = "King Kochhar";
            student.StudentAge = 15;

            Console.WriteLine("Student Id : {0}", student.StudentId);
            Console.WriteLine("Student Name : {0}", student.StudentName);
            Console.WriteLine("Student Age : {0}", student.StudentAge);

            Console.WriteLine("************************************");

            student.DisplayDetails();

            Console.ReadKey();

        }
    }
}
*/