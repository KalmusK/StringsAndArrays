using System;

namespace DontPanic
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm asendab "dont panic" lauses kõik o tähed nulliga
			// kõik a tähed number 4ga

			string dontP = "Don't Panic!";

			dontP = dontP.Replace('o', '0');
			dontP = dontP.Replace('a', '4');
			Console.WriteLine(dontP);
		}
	}
}
