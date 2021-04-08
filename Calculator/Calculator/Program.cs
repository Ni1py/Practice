using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
			Calculate();
        }
		public static void Calculate()
		{
			Console.Write("Enter first number: ");
			string number1 = Console.ReadLine();
			Console.Write("Enter second number: ");
			string number2 = Console.ReadLine();
			Console.Write("Enter the calculation operation: ");
			string operation = Console.ReadLine();
			int CalculationResult = 0;
			if (operation == "+")
			{
				CalculationResult = Convert.ToInt32(number1) + Convert.ToInt32(number2);
			}
			if (operation == "-")
			{
				CalculationResult = Convert.ToInt32(number1) - Convert.ToInt32(number2);
			}
			if (operation == "*")
			{
				CalculationResult = Convert.ToInt32(number1) * Convert.ToInt32(number2);
			}
			if (operation == "/")
			{
				CalculationResult = Convert.ToInt32(number1) / Convert.ToInt32(number2);
			}
			Console.WriteLine($"{number1} {operation} {number2} = {CalculationResult}");
			}
	}
}
