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
			Dictionary<int, Ads> adsList = new Dictionary<int, Ads>();
			adsList.Add(1, new Ads("Телефон", "Андроид 9", 7000, 89000000000, "Вася", DateTime.Now));
			adsList.Add(2, new Ads("Консоль", "Xbox 360", 5000, 89000000001, "Петя", DateTime.Now));
			adsList.Add(3, new Ads("Телевизор", "Sony", 9000, 89000000002, "Оля", DateTime.Now));
			adsList.Add(4, new Ads("Одежда", "Платье, туфли", 1500, 89000000003, "Катя", DateTime.Now));
			adsList.Add(5, new Ads("Кактус", "Колючий", 3000, 89000000004, "Женя", DateTime.Now));

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
// 					case ConsoleKey.D3:
// 						FindAds(adsList);
// 						break;
// 					case ConsoleKey.D4:
// 						DelAds(adsList);
// 						break;
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
						$"\nЦена: {elem.Value.adsPrice} " +
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
			try
			{
				Console.Clear();
				Console.WriteLine("Введите код объявления: ");
				int adsCode = Console.Read();
				while (adsCode.ToString() == "")
				{
					Console.WriteLine("Вы ничего не ввели, попробуйте снова: ");
					adsCode = Console.Read();
				}
			Description:
				Console.WriteLine("Введите описание объявления: ");
				string adsDescription = Console.ReadLine();
				if (adsDescription == "")
				{
					Console.WriteLine("Вы ничего не ввели, попробуйте снова: ");
					goto Description;
				}
				else
				{
					adsList.Add(adsCode, new Ads());
					Console.WriteLine("Объявление добавлено! ");
					Console.WriteLine("Для возврата в главное меню нажмите любую клавишу... ");
					Console.ReadKey();
				}
			}
			catch
			{
				Console.WriteLine("Этот код уже используется! ");
				Console.WriteLine("Для возврата в главное меню нажмите любую клавишу... ");
				Console.ReadKey();
			}
		}
// 		static public void FindAds(Dictionary<int, Ads> adsList)
// 		{
// 			Console.Clear();
// 		FindAds:
// 			Console.WriteLine("Введите код объявления для поиска: ");
// 			string adsCode = Console.ReadLine();
// 			if (adsCode != "")
// 			{
// 				if (adsList.ContainsKey(adsCode))
// 				{
// 					Console.WriteLine(adsList[adsCode]);
// 				}
// 				else
// 				{
// 					Console.WriteLine("Такой код не найден! ");
// 				}
// 			}
// 			else
// 			{
// 				Console.WriteLine("Вы ничего не ввели, попробуйте снова: ");
// 				goto FindAds;
// 			}
// 			Console.WriteLine("Для возврата в главное меню нажмите любую клавишу...");
// 			Console.ReadKey();
// 		}
// 		static public void DelAds(Dictionary<int, Ads> adsList)
// 		{
// 			Console.Clear();
// 		DelAds:
// 			Console.WriteLine("Введите код объявления для удаления: ");
// 			string adsCode = Console.ReadLine();
// 			if (adsCode != "")
// 			{
// 				if (adsList.ContainsKey(adsCode))
// 				{
// 					adsList.Remove(adsCode);
// 					Console.WriteLine("Объявление удалено ");
// 				}
// 				else
// 				{
// 					Console.WriteLine("Такого объявления не существует! ");
// 				}
// 			}
// 			else
// 			{
// 				Console.WriteLine("Вы ничего не ввели, попробуйте снова: ");
// 				goto DelAds;
// 			}
// 			Console.WriteLine("Для возврата в главное меню нажмите любую клавишу... ");
// 			Console.ReadKey();
// 		}
	}
}