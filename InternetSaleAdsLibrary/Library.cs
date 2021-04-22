using System;
using System.Collections.Generic;

namespace InternetSaleAdsLibrary
{
	public abstract class Menu
	{
		protected List<Ads> adsList;

		public abstract void HandleMenu();

		public void PrintMenu(string[] MenuStrings)
		{
			foreach (string menu in MenuStrings)
			{
				Console.WriteLine(menu);
			}
			Console.WriteLine("Нажмите цифру, соответствующую номеру меню. ");
		}

		public void PrintAdsList()
		{
			Console.Clear();
			if (adsList.Count == 0)
			{
				Console.WriteLine("Список объявлений пуст. ");
			}
			else
			{
				int i = 0;
				foreach (Ads elem in adsList)
				{
					if (elem.adsAproved)
					{
						i++;
						Console.WriteLine($"{i}\n{elem}");
						Console.WriteLine();
					}
				}
			}
			Console.WriteLine("Для возврата в главное меню нажмите любую клавишу... ");
			Console.ReadKey();
		}

		public void AddAdsMenu()
		{
			Console.Clear();
			string adsName = Helpers.AskFilledString("Введите название объявления: ");
			string adsDescription = Helpers.AskFilledString("Введите описание: ");
			uint adsPrice = Helpers.AskAdPrice("Укажите цену: ");
			ulong sellerNumber = Helpers.AskPhoneNumber("Укажите ваш номер телефона: ");
			string sellerName = Helpers.AskFilledString("Введите ваше имя: ");
			Console.WriteLine("Объявление добавлено! ");

			if (adsPrice >= 10000)
			{
				Console.WriteLine("Ваше обяъявление отправлено на модерацию ");
			}
			adsList.Add(new Ads(adsName,
								adsDescription,
								adsPrice,
								sellerNumber,
								sellerName,
								DateTime.Now,
								adsPrice < 10000));

			Console.WriteLine("Для возврата в главное меню нажмите любую клавишу... ");
			Console.ReadKey();
		}

		public void DelAdsMenu()
		{
			Console.Clear();
			int printedList = 0;
			if (adsList.Count == 0)
			{
				Console.WriteLine("Список объявлений пуст. ");
			}
			else
			{
				foreach (Ads elem in adsList)
				{
					if (elem.adsAproved)
					{
						printedList++;
						Console.WriteLine($"{printedList}\n{elem}");
						Console.WriteLine();
					}
				}
			}

			int adsCode = (int)Helpers.AskPositiveNumber("Введите номер объявления для удаления: ");
			if (adsCode > printedList || adsCode == 0)
			{
				Console.WriteLine("Такого объявления не существует! ");
			}
			else
			{
				adsList.RemoveAt(adsCode);
				Console.WriteLine("Объявление удалено! ");
			}
			Console.WriteLine("Для возврата в главное меню нажмите любую клавишу... ");
			Console.ReadKey();
			Console.WriteLine();
		}
	}

	public class UserMenu : Menu
	{
		private string[] MenuStrings =
		{
			"1 - Показать список объявлений",
			"2 - Добавить объявление",
			"3 - Поиск объявления по порядковому номеру",
			"0 - Выход"
		};

		public UserMenu(List<Ads> ads)
		{
			this.adsList = ads;
		}

		override public void HandleMenu()
		{
			ConsoleKey key;

			do
			{
				Console.Clear();
				PrintMenu(MenuStrings);
				key = Console.ReadKey().Key;
				switch (key)
				{
					case ConsoleKey.D1:
						PrintAdsList();
						break;
					case ConsoleKey.D2:
						AddAdsMenu();
						break;
					// 					case ConsoleKey.D3:
					// 						FindAdsMenu();
					// 						break;
					default: continue;
				}
			} while (key != ConsoleKey.D0);
			Console.WriteLine("\nУдачи!");
		}

	}

	public class AdminMenu : Menu
	{
		private string[] MenuStrings =
		{
			"1 - Показать список объявлений",
			"2 - Добавить объявление",
			"3 - Поиск объявления по порядковому номеру",
			"4 - Удалить объявление",
			"5 - Объявления на модерации",
			"0 - Выход"
		};

		public AdminMenu(List<Ads> ads)
		{
			this.adsList = ads;
		}

		override public void HandleMenu()
		{
			ConsoleKey key;
			do
			{
				Console.Clear();
				PrintMenu(MenuStrings);
				key = Console.ReadKey().Key;
				switch (key)
				{
					case ConsoleKey.D1:
						PrintAdsList();
						break;
					case ConsoleKey.D2:
						AddAdsMenu();
						break;
					// 					case ConsoleKey.D3:
					// 						FindAdsMenu();
					// 						break;
					case ConsoleKey.D4:
						DelAdsMenu();
						break;
					case ConsoleKey.D5:
						ModerMenu();
						break;
					default: continue;
				}
			} while (key != ConsoleKey.D0);
			Console.WriteLine("\nУдачи!");
		}
		private void ModerMenu()
		{
			Console.Clear();
			int moderList = 0;
			if (adsList.Count == 0)
			{
				Console.WriteLine("Список объявлений пуст. ");
			}
			else
			{
				foreach (Ads elem in adsList)
				{
					if (elem.adsAproved == false)
					{
						moderList++;
						Console.WriteLine($"{moderList}\n{elem}");
						Console.WriteLine();
					}
				}
			}

			while (true)
			{
				int adNumber = (int)Helpers.AskPositiveNumber("Введите номер объявления для изменения статуса или 0 для выхода");
				if (adNumber == 0)
				{
					return;
				}
				else if (adNumber > adsList.Count || adNumber > moderList)
				{
					Console.WriteLine("Такого объявления не существует! ");
				}
				else
				{
					ulong action = Helpers.AskPositiveNumber("1 - разрешить объявление\n2 - удалить объявление\n0 - отмена ");
					int i = 1, listIndex = 0;
					foreach (Ads elem in adsList)
					{
						if (elem.adsAproved == false)
						{
							if (i == adNumber)
								break;
							i++;
						}
						listIndex++;
					}

					switch (action)
					{
						case 1:
							Ads ads = adsList[listIndex];
							ads.adsAproved = true;
							Console.WriteLine("Объявление добавлено! ");
							break;
						case 2:
							adsList.RemoveAt(listIndex);
							Console.WriteLine("Объявление удалено! ");
							break;
						case 0:
							return;
					}
				}
			}
		}
	}

	public class Ads
	{
		/*название товара, описание, цена, номер телефона продавца,
		 * фио продавца, дата-время создания*/
		public string adsName;
		public string adsDescription;
		public uint adsPrice;
		public ulong sellerNumber;
		public string sellerName;
		public DateTime adsDate;
		public bool adsAproved = true;

		override public string ToString()
		{
			return
				$"Наименование: {adsName} " +
				$"\nОписание: {adsDescription} " +
				$"\nЦена: {adsPrice} bucks " +
				$"\nНомер тел.: {sellerNumber} " +
				$"\nПродавец: {sellerName} " +
				$"\nДата размещения: {adsDate} ";
		}

		public Ads(string adsName, string adsDescription, uint adsPrice, ulong sellerNumber, string sellerName, DateTime adsDate, bool adsAproved)
		{
			this.adsName = adsName;
			this.adsDescription = adsDescription;
			this.adsPrice = adsPrice;
			this.sellerNumber = sellerNumber;
			this.sellerName = sellerName;
			this.adsDate = adsDate;
			this.adsAproved = adsAproved;
		}

		public Ads(string adsName, uint adsPrice, ulong sellerNumber)
			: this(adsName, "тест описание", adsPrice, sellerNumber, "тест продавец", DateTime.Now, true)
		{
		}

		public Ads()
		{
			adsName = "ADS_TEST";
			adsDescription = "DESCRIPTION_TEST";
			adsPrice = 10000;
			sellerNumber = 89009990099;
			sellerName = "NAME_TEST";
			adsDate = DateTime.Now;
			adsAproved = false;
		}

		public static uint CheckPrice(string input)
		{
			int price;
			bool check = int.TryParse(input, out price);
			if (check)
			{
				if (price < 0)
				{
					return 1;
				}
				return 0; // если все ок
			}
			else
			{
				return 2;
			}
		}

		public static uint CheckPhone(string input)
		{
			bool check = long.TryParse(input, out long phone);
			if (check)
			{
				if (phone < 0)
				{
					return 1;
				}
				return 0; // если все ок
			}
			else
			{
				return 2;
			}
		}
	}

	public class Helpers
	{
		public static uint AskAdPrice(string question) // Проверка верно указанной цены
		{
			while (true)
			{
				Console.WriteLine(question);
				string input = Console.ReadLine();
				uint check = Ads.CheckPrice(input);
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
				uint check = Ads.CheckPhone(input);
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
	}
}
