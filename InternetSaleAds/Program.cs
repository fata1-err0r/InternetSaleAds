using System;
using System.Collections.Generic;

namespace InternetSaleAds
{
	class Program
	{
		static public string[] MenuStrings =
		{
			"1 - Показать список объявлений",
			"2 - Добавить объявление",
			"3 - Поиск объявления по коду",
			"4 - Удалить объявление",
			"5 - Выход"
		};
		static void Main(string[] args)
		{
			Dictionary<int, Ads> adsList = new()
			{
				{ 1, new Ads() },
				{ 2, new Ads("тест имя", 666, 999) },
				{ 3, new Ads("Телефон", "iPont 99", 9999, 89000001111, "Вася", DateTime.Now) },
				{ 4, new Ads("Консоль", "PayStation $", 3000, 89000002222, "Петя", DateTime.Now) },
				{ 5, new Ads("Телевизор", "Pony", 5000, 89000003333, "Оля", DateTime.Now) },
				{ 6, new Ads("Сумочка", "Гусси", 7000, 89000004444, "Катя", DateTime.Now) },
				{ 7, new Ads("Кактус", "Колючий", 10, 890000005555, "Женя", DateTime.Now) }
			};

			ConsoleKey key = ConsoleKey.Enter;
			do
			{
				PrintMenu();
				key = Console.ReadKey().Key;
				switch (key)
				{
					case ConsoleKey.D1:
						PrintAdsList(adsList);
						break;
					case ConsoleKey.D2:
						AddAds(adsList);
						break;
					case ConsoleKey.D3:
						FindAds(adsList);
						break;
					case ConsoleKey.D4:
						DelAds(adsList);
						break;
					default: continue;
				}
			} while (key != ConsoleKey.D5);
			Console.WriteLine("\nУдачи!");
		}
		static public void PrintMenu()
		{
			Console.Clear();
			foreach (var menu in MenuStrings)
			{
				Console.WriteLine(menu);
			}
			Console.WriteLine("Нажмите цифру, соответствующую номеру меню. ");
		}
		static public void PrintAdsList(Dictionary<int, Ads> adsList)
		{
			Console.Clear();
			if (adsList.Count == 0)
			{
				Console.WriteLine("Список объявлений пуст. ");
			}
			else
			{
				foreach (KeyValuePair<int, Ads> elem in adsList)
				{
					Console.WriteLine($"{elem.Key} " +
						$"\nНаименование: {elem.Value.adsName} " +
						$"\nОписание: {elem.Value.adsDescription} " +
						$"\nЦена: {elem.Value.adsPrice} bucks " +
						$"\nНомер тел.: {elem.Value.sellerNumber} " +
						$"\nПродавец: {elem.Value.sellerName} " +
						$"\nДата размещения: {elem.Value.adsDate} ");
					Console.WriteLine();
				}
			}
			Console.WriteLine("Для возврата в главное меню нажмите любую клавишу... ");
			Console.ReadKey();
		}
		static public void AddAds(Dictionary<int, Ads> adsList)
		{
			Console.Clear();
			int adsCode = adsList.Count + 1;

		// 			string adsName = Console.ReadLine();
		// 			do
		// 			{
		// 				Console.WriteLine("Введите название объявления: ");
		// 				if (Console.ReadLine() == "")
		// 				{
		// 					Console.WriteLine("Ошибка! Попробуйте снова... ");
		// 				}
		// 				else
		// 					break;
		// 			} while (true);

		AdsName:
			Console.WriteLine("Введите название объявления: ");
			string adsName = Console.ReadLine();
			if (adsName == "")
			{
				Console.WriteLine("Ошибка! Попробуйте снова... ");
				goto AdsName;
			}

		AdsDescription:
			Console.WriteLine("Введите описание: ");
			string adsDescription = Console.ReadLine();
			if (adsDescription == "")
			{
				Console.WriteLine("Ошибка! Попробуйте снова... ");
				goto AdsDescription;
			}

		AdsPrice:
			Console.WriteLine("Укажите цену: ");
			int adsPrice = Convert.ToInt32(Console.ReadLine());
			if (adsPrice <= 0)
			{
				Console.WriteLine("Ошибка! Попробуйте снова... ");
				goto AdsPrice;
			}

		SellerNumber:
			Console.WriteLine("Укажите ваш номер телефона: ");
			ulong sellerNumber = (ulong)Convert.ToInt64(Console.ReadLine());
			if (sellerNumber <= 0)
			{
				Console.WriteLine("Ошибка! Попробуйте снова... ");
				goto SellerNumber;
			}

		SellerName:
			Console.WriteLine("Введите ваше имя: ");
			string sellerName = Console.ReadLine();
			if (sellerName == "")
			{
				Console.WriteLine("Ошибка! Попробуйте снова... ");
				goto SellerName;
			}

			adsList.Add(adsCode, new Ads(adsName,
										 adsDescription,
										 adsPrice,
										 sellerNumber,
										 sellerName,
										 DateTime.Now));

			Console.WriteLine("Объявление добавлено! ");
			Console.WriteLine("Для возврата в главное меню нажмите любую клавишу... ");
			Console.ReadKey();
		}
		static public void FindAds(Dictionary<int, Ads> adsList)
		{
			Console.Clear();
		FindAds:
			Console.WriteLine("Введите номер объявления для поиска: ");
			string adsCode = Console.ReadLine();
			if (adsCode != "")
			{
				if (adsList.ContainsKey(adsList.Count))
				{
					Console.WriteLine(adsList.Count);
				}
				else
				{
					Console.WriteLine("Такого объявления не существует! ");
				}
			}
			else
			{
				Console.WriteLine("Ошибка! Попробуйте снова... ");
				goto FindAds;
			}
			Console.WriteLine("Для возврата в главное меню нажмите любую клавишу...");
			Console.ReadKey();
		}
		static public void DelAds(Dictionary<int, Ads> adsList)
		{
			Console.Clear();
		DelAds:
			Console.WriteLine("Введите код объявления для удаления: ");
			string adsCode = Console.ReadLine();
			if (adsCode != "")
			{
				if (adsList.ContainsKey(adsList.Count))
				{
					adsList.Remove(adsList.Count);
					Console.WriteLine("Объявление удалено ");
				}
				else
				{
					Console.WriteLine("Такого объявления не существует! ");
				}
			}
			else
			{
				Console.WriteLine("Вы ничего не ввели, попробуйте снова: ");
				goto DelAds;
			}
			Console.WriteLine("Для возврата в главное меню нажмите любую клавишу... ");
			Console.ReadKey();
		}
	}
}
