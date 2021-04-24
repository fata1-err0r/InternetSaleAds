using InternetSaleAdsLibrary;
using System;
using System.Collections.Generic;

namespace InternetSaleAds
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleKey key;
			Menu menu;

			AdsDataBase adsDataBase = new("AdsListDataBase.txt");
			AdsDataBase moderAdsDataBase = new("ModerAdsListDataBase.txt");

			List<Ad> adsList = adsDataBase.Load();
			List<Ad> moderList = moderAdsDataBase.Load();

			// 			List<Ad> adsList = new()
			// 			{
			// 				{ new Ad() },
			// 				{ new Ad("Телефон", "iPont 99", 9999, 89000001111, "Вася") },
			// 				{ new Ad("Консоль", "PayStation $", 3000, 89000002222, "Петя") },
			// 				{ new Ad("Телевизор", "Pony", 5000, 89000003333, "Оля") },
			// 				{ new Ad("Сумочка", "Гусси", 7000, 89000004444, "Катя") },
			// 				{ new Ad("Кактус", "Колючий", 5, 890000005555, "Женя") }
			// 			};

			while (true)			
			{
				while (true)
				{
					Console.Clear();
					Console.WriteLine("Вас приветствует магазин \"Наде Ване\" \n ");
					Console.WriteLine("Под кем войти?\n" +
						"1 - Админ\n" +
						"2 - Юзер\n" +
						"0 - Выход из программы");
					key = Console.ReadKey().Key;
					Console.WriteLine();
					if (key == ConsoleKey.D1)
					{
						menu = new AdminMenu(adsList, moderList);
					}
					else if (key == ConsoleKey.D2)
					{
						menu = new UserMenu(adsList, moderList);
					}
					else if (key == ConsoleKey.D0)
					{
						adsDataBase.Save(adsList);
						moderAdsDataBase.Save(moderList);
						Console.WriteLine("Данные пока сохранены =) ");
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
