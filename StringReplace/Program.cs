﻿using System;

namespace StringReplace
{
	class Program
	{
		static void Main(string[] args)
		{
			//Programm asendab kõik 'o' tähed tärniga sõnas "hello world"

			string helloW = "Hello World!";

			//for (int i = 0; i < helloW.Length; i++)
			//{
			//	helloW[i] = '*'; //sõned on muutumatud
			//}

			helloW = helloW.Replace('o', '*');
			helloW = helloW.Replace('!', '1');
			Console.WriteLine(helloW);

		}
	}
}
