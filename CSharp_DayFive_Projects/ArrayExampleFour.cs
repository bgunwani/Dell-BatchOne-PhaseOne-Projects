/*using System;

namespace CSharp_DayFive_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declared an Array
            int[] arr = { 17, 23, 4, 59, 27, 36, 96, 1, 3 };

            // Print the array elements
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("**********************************");

            // Sort the array elements:
            Array.Sort(arr);

            // Print the array elements after Sort
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }

            Console.WriteLine();
            Console.WriteLine("**********************************");

            // Reverse the array elements:
            Array.Reverse(arr);

            // Print the array elements after Reverse
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }

            Console.WriteLine();
            Console.WriteLine("**********************************");

            int[] newArray = new int[3];
            Array.Copy(arr, newArray, 3);
            // Print the array elements of Copied One.
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + "  ");
            }

            Console.WriteLine();
            Console.WriteLine("**********************************");

            Console.WriteLine("newArray Length : " + newArray.Length);
            Console.WriteLine("newArray Length : " + newArray.GetLength(0));

            Console.ReadKey();
        }
    }
}
*/