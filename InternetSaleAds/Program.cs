using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using InternetSaleAdsLibrary;

namespace InternetSaleAds
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleKey key;
			Menu menu;

			List<Ads> adsList = new()
			{
				{ new Ads() },
				{ new Ads("тест имя", 666, 999) },
				{ new Ads("Телефон", "iPont 99", 9999, 89000001111, "Вася", DateTime.Now, true) },
				{ new Ads("Консоль", "PayStation $", 3000, 89000002222, "Петя", DateTime.Now, true) },
				{ new Ads("Телевизор", "Pony", 5000, 89000003333, "Оля", DateTime.Now, true) },
				{ new Ads("Сумочка", "Гусси", 7000, 89000004444, "Катя", DateTime.Now, true) },
				{ new Ads("Кактус", "Колючий", 5, 890000005555, "Женя", DateTime.Now, true) }
			};

			while (true)
			{
				while (true)
				{
					Console.Clear();
					Console.WriteLine("Под кем войти? " +
						"\n1 - Админ " +
						"\n2 - Юзер " +
						"\n0 - Выход из программы");
					key = Console.ReadKey().Key;
					Console.WriteLine();
					if (key == ConsoleKey.D1)
					{
						menu = new AdminMenu(adsList);
					}
					else if (key == ConsoleKey.D2)
					{
						menu = new UserMenu(adsList);
					}
					else if (key == ConsoleKey.D0)
					{
						Console.WriteLine("Пока! ");
						return;
					}
					else
					{
						continue;
					}
					menu.HandleMenu();
				}
			}
		}
	}
}
