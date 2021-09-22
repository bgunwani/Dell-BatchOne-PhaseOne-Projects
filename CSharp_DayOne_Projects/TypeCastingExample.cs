/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
	class TypeCastingExample
	{
		static void Main(string[] args)
		{
			int intVariable = 100;
			float floatVariable = intVariable;  // Implicit Casting
			Console.WriteLine("{0} : {1}", intVariable, floatVariable);

			double doubleVariable = 123.45d;
			intVariable = (int) doubleVariable;     // Explicit Casting
			Console.WriteLine("{0} : {1}", doubleVariable, intVariable);

			*//*int num1 = 100;
			int num2 = 200;
			double num3 = num1 + num2;	// Implicit Casting
			Console.WriteLine("{0} + {1} = {2}", num1, num2, num3);*/

			/*double num1 = 100.45;
			double num2 = 200.67;
			// int num3 = (int) num1 +  (int) num2;  // Explicit Casting
			int num3 = (int) (num1 + num2);  // Explicit Casting
			Console.WriteLine("{0} + {1} = {2}", num1, num2, num3);*//*

			// byte, short and char : they gets implicitly converted into int at the time of calculation.

			byte num1 = 100;
			byte num2 = 200;
			// int num3 = (num1 + num2);  // Implicit Casting
			byte num3 = (byte) (num1 + num2);  // Explicit Casting
			Console.WriteLine("{0} + {1} = {2}", num1, num2, num3);

			Console.ReadKey();

		}
	}
}
*/