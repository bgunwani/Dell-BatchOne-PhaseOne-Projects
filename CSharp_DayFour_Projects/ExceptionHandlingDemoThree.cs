/*using System;

namespace CSharp_DayFour_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result = 0;
            try
            {
                Console.Write("Enter First Number : ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Second Number : ");
                num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Catch Block One : " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Catch Block Two : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch Block Three : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Result : " + result);
            }

            Console.ReadKey();
        }
    }
}
*/