/*
 * Created by SharpDevelop.
 * User: Alibek
 * Date: 07.09.2018
 * Time: 11:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ClassWork
{
	class Program
	{
		public static void Main(string[] args)
		{
			string name, surname;
			
			Console.WriteLine("Введите Ваше имя: ");
			name = Console.ReadLine();
			Console.WriteLine("Введите Вашу фамилию: ");
			surname = Console.ReadLine();
			
			Console.WriteLine("Ваше имя и фамилия {0} {1}", name , surname);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}