using System;

namespace HelloWorldReverse
{
	class Program
	{
		static void Main(string[] args)
		{

			//hello world tagurpidi

			
			string HelloWR = "Hello World!";


			for (int i = HelloWR.Length - 1; i >= 0; i--)
			{
				Console.Write(HelloWR[i]);
			}
		}
	}
}
