using System;
using CSharp_DayThree_SportsLibrary;

namespace CSharp_DayThree_ResultLibrary
{
    public class Result : Sports
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
}
