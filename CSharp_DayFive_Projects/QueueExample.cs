/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFive_Projects
{
    class QueueExample
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            // Adding Items
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);
            queue.Enqueue(400);
            queue.Enqueue("Gatuam");
            queue.Enqueue("Sarah");

            Console.WriteLine("----------------------------------------------");

            // Print Queue Items
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine("----------------------------------------------");

            // Print Queue Items
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Element ready to dequeue : " + queue.Peek());
            Console.WriteLine(queue.Count == 0 ? "Queue is Empty.": "Queue is Not Empty.");

            Console.ReadKey();
        }
    }
}
*/