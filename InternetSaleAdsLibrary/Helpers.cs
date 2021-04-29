using System;

namespace InternetSaleAdsLibrary
{
	public class Helpers
	{
		public static uint AskAdPrice(string question) // Проверка верно указанной цены
		{
			while (true)
			{
				Console.WriteLine(question);
				string input = Console.ReadLine();
				uint check = Ad.CheckPrice(input);
				if (check == 1)
				{
					Console.WriteLine("Ошибка! Цена не может быть отрицательной! ");
				}
				else if (check == 2)
				{
					Console.WriteLine("Ошибка! Введено не верное значение! ");
				}
				else if (check == 0)
				{
					return Convert.ToUInt32(input);
				}
			}
		}

		public static ulong AskPhoneNumber(string question) // Проверка верно указанного номера телефона
		{
			while (true)
			{
				Console.WriteLine(question);
				string input = Console.ReadLine();
				uint check = Ad.CheckPhone(input);
				if (check == 1)
				{
					Console.WriteLine("Ошибка! Номер введен не правильно! ");
				}
				else if (check == 2)
				{
					Console.WriteLine("Ошибка! Введено не верное значение! ");
				}
				else if (check == 0)
				{
					return Convert.ToUInt64(input);
				}
			}
		}

		public static string AskFilledString(string question)
		{
			while (true)
			{
				Console.WriteLine(question);
				string input = Console.ReadLine().Trim();
				if (input == "")
				{
					Console.WriteLine("Ошибка! Попробуйте снова... ");
				}
				else
				{
					return input;
				}
			}
		}

		public static long AskNumber(string question)
		{
			while (true)
			{
				Console.WriteLine(question);
				string input = Console.ReadLine().Trim();
				bool check = long.TryParse(input, out long result);
				if (check)
				{
					return result;
				}
				else
				{
					Console.WriteLine("Ошибка! Попробуйте снова... ");
				}
			}
		}

		public static ulong AskPositiveNumber(string question)
		{
			while (true)
			{
				long number = AskNumber(question);
				if (number < 0)
				{
					Console.WriteLine("Ошибка! Число не может быть отрицательным! ");
				}
				else
				{
					return (ulong)number;
				}
			}
		}

		public static ConsoleKeyInfo AskForKey(string question)
		{
			Console.WriteLine(question);
			return Console.ReadKey();
		}
	}
}
