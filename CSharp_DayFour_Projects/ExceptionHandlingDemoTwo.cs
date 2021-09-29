/*using System;

namespace CSharp_DayFour_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter First Number : ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Second Number : ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("Result : " + result);
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine("Catch Block One : " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Catch Block Two : " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Catch Block Three : " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
*/