using System;
using CSharp_DayThree_MarkLibrary;

namespace CSharp_DayThree_SportsLibrary
{
    public class Sports : Marks
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
}
