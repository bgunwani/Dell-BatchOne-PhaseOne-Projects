using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Misc_Projects
{
    public delegate string GreetingDelegate(string name);
    class DelgateUsingAnnonymousMethodExample
    {
        static void Main(string[] args)
        {
            //GreetingDelegate greetingDelegate = delegate (string name)
            //{
            //    return $"Hello {name}!!";
            //};
            //string result = greetingDelegate.Invoke("Bhawna Gunwani");
            //Console.WriteLine(result);

            // Using Lambda Expression
            GreetingDelegate greetingDelegate = (name) => { return $"Hello {name}!!"; };
            string result = greetingDelegate.Invoke("Bhawna Gunwani");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
}
