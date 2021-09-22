/*using System;

namespace CSharp_Basics
{
	class InputOutputExample
	{
		static void Main(string[] args)
		{
			int empId;
			string empName;
			float empSalary;
			double empContact;
			bool isGraduate;

			Console.Write("Enter Employee Id : ");
			// empId = Convert.ToInt32(Console.ReadLine());
			empId = int.Parse(Console.ReadLine());
			Console.Write("Enter Employee Name : ");
			//empName = Console.ReadLine();
			empName = Console.ReadLine();
			Console.Write("Enter Employee Salary : ");
			// empSalary = Convert.ToSingle(Console.ReadLine());
			empSalary = float.Parse(Console.ReadLine());
			Console.Write("Enter Employee Contact No : ");
			// empContact = Convert.ToDouble(Console.ReadLine());
			empContact = double.Parse(Console.ReadLine());
			Console.Write("Are you Graduate? (true/false) : ");
			// isGraduate = Convert.ToBoolean(Console.ReadLine());
			isGraduate = bool.Parse(Console.ReadLine());

			Console.WriteLine();
			Console.WriteLine("***** Employee Details *****");
			Console.WriteLine("Employee Id : " + empId);
			Console.WriteLine("Employee Name : " + empName);
			Console.WriteLine("Employee Salary : " + empSalary);
			Console.WriteLine("Employee Contact : " + empContact);
			Console.WriteLine(isGraduate ? "You are eligible." : "You are not eligible.");
			Console.ReadKey();
		}
	}
}
*/