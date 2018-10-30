using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVarExercise
{
	class Program
	{
		static void Main(string[] args)
		{

			var fName = "Blake";

			const string greeting = "Hello, ";
			Console.WriteLine(greeting + fName + ".");
			Console.ReadLine();
		}
	}
}
