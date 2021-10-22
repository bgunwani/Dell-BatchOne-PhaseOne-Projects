/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Misc_Projects
{
    public delegate void myDelegate(int number1, int number2);
    class Calculation
    {
        public void addition(int num1, int num2)
        {
            Console.WriteLine("Sum of two numbers : " + (num1 + num2));
        }
        public void subtraction(int num1, int num2)
        {
            Console.WriteLine("Difference between two numbers : " + (num1 - num2));
        }
        public void product(int num1, int num2)
        {
            Console.WriteLine("Product of two numbers : " + (num1 * num2));
        }
        public void divide(int num1, int num2)
        {
            Console.WriteLine("Division between two numbers : " + (num1 / num2));
        }
    }

    class DelegateExample
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();

            //myDelegate del1 = new myDelegate(calculation.addition);
            //myDelegate del2 = new myDelegate(calculation.subtraction);
            //myDelegate del3 = new myDelegate(calculation.product);
            //myDelegate del4 = new myDelegate(calculation.divide);
            //del1(100, 20);
            //del2(100, 20);
            //del3(100, 20);
            //del4(100, 20);
            // del1.Invoke(100, 20);

            myDelegate myDel = new myDelegate(calculation.addition);
            // myDel(100, 20);
            myDel += calculation.subtraction;
            myDel += calculation.product;
            myDel += calculation.divide;
            myDel(1000, 20);
            Console.WriteLine("----------------------");
            myDel -= calculation.addition;
            myDel(1000, 20);
            Console.ReadKey();
        }
    }
}
*/