using System;

namespace ClassWork
{
	class Program
	{
		public static void Main(string[] args)
		{
			int number1, number2;
			int summary;
			
			Console.WriteLine("Введите Первое число: ");
			number1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите Второе число: ");
			number2 = int.Parse(Console.ReadLine());
			
			summary = number1 + number2;
			
			Console.WriteLine("Сумма чисел {0} и {1} = {2}", number1, number2, summary);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}