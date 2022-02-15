using System;

namespace StringsAndArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib eesnime
			//programm kuvab eesnime pikkust

			Console.WriteLine("Sisesta oma eesnimi:");
			
			string firstName = Console.ReadLine();
			int firstNameLength = firstName.Length;

			Console.WriteLine($"Sinu eesnimes on {firstNameLength} sümbolit.");



			
		}
	}
}
