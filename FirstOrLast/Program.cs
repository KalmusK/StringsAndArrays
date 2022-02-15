using System;

namespace FirstOrLast
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib sisestada ees ja perekonna nime
			//programm kontrollib eraldi andmete pikkust
			//programm kuvab kumb on pikem



			Console.WriteLine("Sisesta oma eesnimi:");

			string firstName = Console.ReadLine();
			int firstNameLength = firstName.Length;

			Console.WriteLine($"Sinu eesnimes on {firstNameLength} sümbolit.");

			Console.WriteLine("Sisesta oma perekonnanimi:");

			string lastName = Console.ReadLine();
			int lastNameLength = lastName.Length;

			Console.WriteLine($"Sinu perekonnanimes on {lastNameLength} sümbolit.");

			if (firstNameLength > lastNameLength)
			{
				Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi!");
			}
			else if(firstNameLength == lastNameLength)
			{
				Console.WriteLine("Eesnimi ning perekonnanimi on sama pikad!");
			}
			else
			{
				Console.WriteLine("Perekonnanimi on pikem!");
			}

		}
	}
}
