using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
	class LoopingConstructExample
	{
		static void Main(string[] args)
		{
			string[] pets = { "dog", "cat", "bird" };

			for (int i = 0; i < pets.Length; i++)
			{
				if (i == 1)
					continue;
				Console.WriteLine(pets[i]);
			}

			Console.WriteLine("************************");

			foreach (string pet in pets)
			{
				if (pet == "cat")
					continue;
				Console.WriteLine(pet);
			}

			Console.ReadLine();
		}
	}
}
