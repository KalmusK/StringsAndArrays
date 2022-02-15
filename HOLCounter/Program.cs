using System;

namespace HOLCounter
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm kuvab konsoolis mitu h o l on lauses "Hello World!"


			
			string fullName = "Hello World!";
						
			int hCounter = 0;
			int oCounter = 0;
			int lCounter = 0;


			for (int i = 0; i < fullName.Length; i++)
			{
				if (fullName[i] == 'h')
				{
					hCounter++;
				}
			}

			if (hCounter != 1)
			{
				Console.WriteLine($"Hello World!'is on {hCounter} 'h' tähte.");
			}
			else
			{
				Console.WriteLine($"Hello World!'is on {hCounter} 'h' täht.");
			}

			for (int i = 0; i < fullName.Length; i++)
			{
				if (fullName[i] == 'o')
				{
					oCounter++;
				}
			}

			if (oCounter != 1)
			{
				Console.WriteLine($"Hello World!'is on {oCounter} 'o' tähte.");
			}
			else
			{
				Console.WriteLine($"Hello World!'is on {oCounter} 'o' täht.");
			}

			for (int i = 0; i < fullName.Length; i++)
			{
				if (fullName[i] == 'l')
				{
					lCounter++;
				}
			}

			if (lCounter != 1)
			{
				Console.WriteLine($"Hello World!'is on {lCounter} 'l' tähte.");
			}
			else
			{
				Console.WriteLine($"Hello World!'is on {lCounter} 'l' täht.");
			}




		}
	}
}
