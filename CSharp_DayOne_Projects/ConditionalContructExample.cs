/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
	class ConditionalContructExample
	{
		static void Main(string[] args)
		{
			*//* Create an application with following roles:
			 * 1. admin - get full access
			 * 2. subadmin - gets access to create/delete courses
			 * 3. testprep - gets access to create/delete tests
			 * 4. user - gets access to consume content
			 *//*

			string userType = "admin";
			switch (userType)
			{
				case "admin":
					Console.WriteLine("You get full access.");
					break;

				case "subadmin":
					Console.WriteLine("You get access to create/delete courses.");
					break;

				case "testprep":
					Console.WriteLine("You get access to create/delete tests.");
					break;

				case "user":
					Console.WriteLine("You get access to consume content.");
					break;

				default:
					Console.WriteLine("You a trial user.");
					break;
			}

			Console.ReadLine();
		}
	}
}
*/