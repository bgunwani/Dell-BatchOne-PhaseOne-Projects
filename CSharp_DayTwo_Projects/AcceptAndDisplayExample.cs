using System;

namespace CSharp_DayTwo_Projects
{
    class Student
    {
        // Data Members
        int StudentId;
        string StudentName;
        int StudentAge;
        static string UniversityName;

        // Static Constructor 
        static Student()
        {
            UniversityName = "Amity University";
        }

        // Member Function
        protected void AcceptDetails()
        {
            Console.Write("Enter Student Id : ");
            this.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name : ");
            this.StudentName = Console.ReadLine();
            Console.Write("Enter Student Age : ");
            this.StudentAge = int.Parse(Console.ReadLine());
        }
        
        protected void DisplayDetails()
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Student Id : {0}", this.StudentId);
            Console.WriteLine("Student Name : {0}", this.StudentName);
            Console.WriteLine("Student Age : {0}", this.StudentAge);
            Console.WriteLine("University Name : {0}", Student.UniversityName);
        }
    }

    class Marks: Student
    {
        protected float ObjectiveMarks, SubjectiveMarks;
        protected new void AcceptDetails()
        {
            base.AcceptDetails();
            Console.Write("Enter Objective Marks : ");
            this.ObjectiveMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Student Name : ");
            this.SubjectiveMarks = float.Parse(Console.ReadLine());
        }

        protected new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Marks Details : ");
            Console.WriteLine("Objective Marks : {0}", this.ObjectiveMarks);
            Console.WriteLine("Subjective Marks : {0}", this.SubjectiveMarks);
        }
    }

    class Sports: Marks
    {
        protected float score;
        public new void AcceptDetails()
        {
            base.AcceptDetails();
            Console.Write("Enter Sports Score : ");
            this.score = float.Parse(Console.ReadLine());
        }

        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Sports Score : {0}", this.score);
        }
    }
    class Result : Sports
    {
        float TotalMarks, AverageMarks;
        public void Calculate()
        {
            this.TotalMarks = this.ObjectiveMarks + this.SubjectiveMarks + this.score;
            this.AverageMarks = this.TotalMarks / 3;
            Console.WriteLine("Total Marks : " + this.TotalMarks);
            Console.WriteLine("Average Marks : " + this.AverageMarks);
        }
    }
    class ConstructorExample
    {
        static void Main(string[] args)
        {

            Result obj = new Result();
            obj.AcceptDetails();
            obj.DisplayDetails();
            obj.Calculate();
            
            Console.ReadKey();
        }
    }
}
