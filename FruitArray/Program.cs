﻿using System;

namespace FruitArray
{
	class Program
	{
		static void Main(string[] args)
		{
			//proge ennustab mis puuvilja kasutaja sööb

			//string[] fruit = new string[5];
			string[] fruit = new string[5] { "an apple", "a banana", "a lemon", "an orange", "some grapes" };

			//Console.WriteLine(fruit[0]);
			//Console.WriteLine(fruit[1]);
			//...

			//Console.WriteLine("Enter a number:");
			Random rnd = new Random();
			int userNumber = rnd.Next(0, fruit.Length);
			//int userNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"Today you will have {fruit[userNumber]}.");

		}
	}
}
