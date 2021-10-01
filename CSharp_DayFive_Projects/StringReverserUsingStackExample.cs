/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFive_Projects
{
    class StringReverser
    {
        public String reverse(String input)
        {
            string reversed = "";
            Stack<char> stack = new Stack<char>();
            char[] charArr = input.ToCharArray();

            foreach(char ch in charArr)
                stack.Push(ch);

            while(stack.Count != 0) {
                reversed += stack.Pop();
            }

            return reversed;
        }
    }
    class StringReverserUsingStackExample
    {
        static void Main(string[] args)
        {
            StringReverser stringReverser = new StringReverser();
            Console.WriteLine(stringReverser.reverse("BHAWNA"));
        }
    }
}
*/