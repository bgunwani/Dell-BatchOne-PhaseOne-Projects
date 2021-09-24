using System;
using CSharp_DayThree_StudentLibrary;

namespace CSharp_DayThree_MarkLibrary
{
    public class Marks : Student
    {
        protected float ObjectiveMarks, SubjectiveMarks;
        protected new void AcceptDetails()
        {
            base.AcceptDetails();
            Console.Write("Enter Objective Marks : ");
            this.ObjectiveMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Subjective Marks : ");
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
}
