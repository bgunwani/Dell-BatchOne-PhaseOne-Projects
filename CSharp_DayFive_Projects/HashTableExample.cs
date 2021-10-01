/*using System;
using System.Collections;

namespace CSharp_DayFive_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("EID", 1001);
            hashtable.Add("EName", "King Kochhar");
            hashtable.Add("ESalary", 12000);
            hashtable.Add("EDesignation", "Manager");

            // Printing Hash Keys and their values:
            foreach (var item in hashtable.Keys)
                Console.WriteLine("{0} : {1}", item, hashtable[item]);

            // Print Element based upon the Key
            Console.WriteLine("Employee Designation : " + hashtable["EDesignation"]);

            Console.WriteLine("Value Exists : " + hashtable.ContainsValue("King Kochhar"));
            Console.WriteLine("Key Exists : " + hashtable.ContainsKey("EDesignation"));


            Console.ReadKey();


        }
    }
}
*/