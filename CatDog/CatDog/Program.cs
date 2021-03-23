using System;
using System.Threading;

namespace CatDog
{
	class Program
	{
		static void Main(string[] args)
		{
			//Version1();
			Version2();
			//Version3();
		}
		private static void Version1()
		{
			string outputValue;
			for (int i = 1; i <= 100; i++)
			{
				outputValue = string.Empty;
				if (i % 3 == 0)
				{
					outputValue = "cat";
				}

				if (i % 5 == 0)
				{
					outputValue += "dog";
				}

				if (i % 3 != 0 && i % 5 != 0)
				{
					outputValue = i.ToString();
				}
				Console.WriteLine(outputValue);
				Thread.Sleep(500);
			}
		}

		private static void Version2()
		{
			for (int i = 1; i <= 100; i++)
			{
				Thread.Sleep(500);
				if (i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine("catDog");
					continue;
				}
				if (i % 3 == 0)
				{
					Console.WriteLine("cat");
					continue;
				}
				if (i % 5 == 0)
				{
					Console.WriteLine("dog");
					continue;
				}
				Console.WriteLine();
			}
		}

		private static void Version3()
		{
			for (int i = 1; i <= 100; i++)
			{
				Thread.Sleep(500);
				Console.WriteLine(
					i % 3 == 0 && i % 5 == 0
					? "catDog"
					: (i % 3 == 0
					? "cat"
					: (i % 5 == 0
					? "dog"
					: i)));
			}
		}
	}
}