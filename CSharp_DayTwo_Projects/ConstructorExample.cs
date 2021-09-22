/*using System;

namespace CSharp_DayTwo_Projects
{
    class Student: ICloneable
    {
        // Data Members
        int StudentId;
        string StudentName;
        int StudentAge;
        public static string UniversityName;

        // Static Constructor 
        static Student()
        {
            UniversityName = "Amity University";
        }

        // Default Constructor(Parameterless Constructor)
        public Student()
        {
            this.StudentId = 1001;
            this.StudentName = "Kartik";
            this.StudentAge = 23;
        }

        // Parameterized Constructor
        public Student(int StudentId, string StudentName, int StudentAge)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.StudentAge = StudentAge;
        }

        // Copy Constructor
        public Student(Student st)
        {
            this.StudentId = st.StudentId;
            this.StudentName = st.StudentName;
            this.StudentAge = st.StudentAge;
        }

        // Alternatively, Use Clone Instead of Copy Constructor
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        // Member Function
        public void DisplayDetails()
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Student Id : {0}", this.StudentId);
            Console.WriteLine("Student Name : {0}", this.StudentName);
            Console.WriteLine("Student Age : {0}", this.StudentAge);
            Console.WriteLine("University Name : {0}", Student.UniversityName);
        }

    
    }
    class ConstructorExample
    {
        static void Main(string[] args)
        {

            Student.UniversityName = "Madurai University";
            Console.WriteLine(Student.UniversityName);

            Student student1 = new Student(1001, "King", 34);
            student1.DisplayDetails();
            
            Console.WriteLine("**************************");

            Student student2 = new Student(1002, "Gautam", 45);
            student2.DisplayDetails();

            Console.WriteLine("**************************");

            Student student3 = new Student(student2);
            student3.DisplayDetails();

            Console.WriteLine("**************************");

            Student student4 = student2.Clone() as Student;
            student4.DisplayDetails();

            Console.ReadKey();
        }
    }
}
*/