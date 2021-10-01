/*using System;
using System.Collections;

namespace CSharp_DayFive_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Array List Capacity : " + list.Capacity);

            list.Add(100);
            Console.WriteLine("Array List Capacity : " + list.Capacity);

            list.Add("King kochhar");
            list.Add("King kochhar");
            list.Add(true);
            list.Add(12000.56F);
            Console.WriteLine("Array List Capacity : " + list.Capacity);

            list.Add("John Smith");
            Console.WriteLine("Array List Capacity : " + list.Capacity);
            Console.WriteLine("Array List Count : " + list.Count);

            Console.WriteLine("------------------------------------");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]) ;
            }

            list.Remove("King Kochhar");
            list.RemoveAt(0);
            list.RemoveRange(0, 2);

            list.Insert(0, "Bhawna Gunwani");
            list.InsertRange(3, list);

            Console.WriteLine("------------------------------------");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
*/