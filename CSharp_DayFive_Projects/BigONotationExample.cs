/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFive_Projects
{
    class BigONotationExample
    {
        public static void print(int[] numbers)
        {
            // Constant Notation: O(1)
            //Console.WriteLine(numbers[0]);  // O(1)

            // O(1) + O(1) => O(1+1) => O(2) => O(1)
            // Constant Notation: O(1)
            //Console.WriteLine(numbers[0]);  // O(1)
            //Console.WriteLine(numbers[1]);  // O(1)

            // Linear Notation: O(1)
            //for (int i = 0; i < numbers.Length; i++)
            //    Console.WriteLine(numbers[i]);

            // O(n) + O(2) = O(n)
            // Linear Notation: O(n)
            //Console.WriteLine("Hello Everyone");    // O(1)
            //for (int i = 0; i < numbers.Length; i++)
            //    Console.WriteLine(numbers[i]);      // O(n)
            //Console.WriteLine("Bye Everyone");      // O(1)


            // O(n) + O(n) = O(2n)
            // Linear Notation: O(n)
            //for (int i = 0; i < numbers.Length; i++)
            //    Console.WriteLine(numbers[i]);      // O(n)
            //for (int i = 0; i < numbers.Length; i++)
            //    Console.WriteLine(numbers[i]);      // O(n)

            // O(n^2)
            // Quadratic Notation: O(n^2)
            foreach (var first in numbers) // O(n)
            {
                foreach (var second in numbers) // O(n)
                {
                    Console.WriteLine(first + " : " + second);
                }
            }

        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            print(numbers);
            Console.ReadKey();
        }
    }
}
*/