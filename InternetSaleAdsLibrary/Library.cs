using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InternetSaleAdsLibrary
{
	public abstract class Menu
	{
		protected List<Ad> adsList;
		protected List<Ad> moderAdsList;

		public Menu(List<Ad> adsList, List<Ad> moderAdsList)
		{
			this.adsList = adsList;
			this.moderAdsList = moderAdsList;
		}

		public abstract void HandleMenu();

		public static void PrintMenu(string[] MenuStrings)
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
				foreach (Ad elem in adsList)
				{
					i++;
					Console.WriteLine($"{i}\n{elem}\n");
				}
				while (true)
				{
					ulong action = Helpers.AskPositiveNumber("Отсортировать:\n" +
															 "1 - по цене\n" +
															 "2 - по имени\n" +
															 "3 - по дате\n" +
															 "4 - фильтровать по номеру\n" +
															 "0 - выход\n");
					Console.Clear();
					switch (action)
					{
						case 1:
							foreach (Ad elem in adsList.OrderBy(x => x.adPrice))
							{
								Console.WriteLine($"{elem}\n");
							}
							break;
						case 2:
							foreach (Ad elem in adsList.OrderBy(x => x.adName))
							{
								Console.WriteLine($"{elem}\n");
							}
							break;
						case 3:
							foreach (Ad elem in adsList.OrderBy(x => x.adDate))
							{
								Console.WriteLine($"{elem}\n");
							}
							break;
						case 4:
							ulong filterAdsByPhone = Helpers.AskPhoneNumber("Введите номер телефона: ");
							var filteredAdsByPhone = from query in adsList
													 where query.sellerNumber.Equals(filterAdsByPhone)
													 select query;

							if (filteredAdsByPhone.Count() == 0)
							{
								Console.WriteLine("Объявлений не найдено ");
							}
							else
							{
								List<Ad> foundAdsByPhoneList = new();
								foreach (Ad elem in filteredAdsByPhone)
								{
									foundAdsByPhoneList.Add(new Ad());
								}
								int j = 0;
								foreach (Ad elem in filteredAdsByPhone)
								{
									j++;
									Console.WriteLine($"{j}\n{elem}\n");
								}
							}
							break;
						case 0:
							return;
					}
				}
			}
			Helpers.AskForKey("Для возврата в главное меню нажмите любую клавишу... ");
		}

		public void AddAdsMenu()
		{
			Console.Clear();
			string adName = Helpers.AskFilledString("Введите название объявления: ");
			string adDescription = Helpers.AskFilledString("Введите описание: ");
			uint adPrice = Helpers.AskAdPrice("Укажите цену: ");
			ulong sellerNumber = Helpers.AskPhoneNumber("Укажите ваш номер телефона: ");
			string sellerName = Helpers.AskFilledString("Введите ваше имя: ");

			Ad ad = new(adName, adDescription, adPrice, sellerNumber, sellerName);

			if (adPrice >= 10000)
			{
				moderAdsList.Add(ad);
				Console.WriteLine("Ваше обяъявление отправлено на модерацию. ");
			}
			else
			{
				adsList.Add(ad);
				Console.WriteLine("Объявление добавлено! ");
			}
			Helpers.AskForKey("Для возврата в главное меню нажмите любую клавишу... ");
		}

		public void FindAdsMenu()
		{
			Console.Clear();
			if (adsList.Count == 0)
			{
				Console.WriteLine("Список объявлений пуст. ");
			}
			else
			{
				string serachAdsByName = Helpers.AskFilledString("Введите название объявления для поиска: ");
				var foundAdsByName = from query in adsList
									 where query.adName.Contains(serachAdsByName)
									 select query;

				if (foundAdsByName.Count() == 0)
				{
					Console.WriteLine("Объявлений не найдено ");
				}
				else
				{
					List<Ad> foundAdsByNameList = new();
					foreach (Ad elem in foundAdsByName)
					{
						foundAdsByNameList.Add(new Ad());
					}
					int i = 0;
					foreach (Ad elem in foundAdsByName)
					{
						i++;
						Console.WriteLine($"{i}\n{elem}\n");
					}
				}
			}
			Helpers.AskForKey("Для возврата в главное меню нажмите любую клавишу... ");
		}

		public void DelAdsMenu()
		{
			Console.Clear();
			if (adsList.Count == 0)
			{
				Console.WriteLine("Список объявлений пуст. ");
			}
			else
			{
				int i = 0;
				foreach (Ad elem in adsList)
				{
					i++;
					Console.WriteLine($"{i}\n{elem}\n");
				}

				int adNumber = (int)Helpers.AskPositiveNumber("Введите номер объявления для удаления: ");
				if (adNumber > adsList.Count || adNumber == 0)
				{
					Console.WriteLine("Такого объявления не существует! ");
				}
				else
				{
					adsList.RemoveAt(adNumber - 1);
					Console.WriteLine("Объявление удалено! ");
				}
			}
			Helpers.AskForKey("Для возврата в главное меню нажмите любую клавишу... ");
		}
	}

	public class UserMenu : Menu
	{
		private string[] MenuStrings =
		{
			"1 - Показать список объявлений",
			"2 - Добавить объявление",
			"3 - Поиск объявления по названию",
			"0 - Выход"
		};

		public UserMenu(List<Ad> adsList, List<Ad> moderAdsList) : base(adsList, moderAdsList)
		{
		}

		public override void HandleMenu()
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
					case ConsoleKey.D3:
						FindAdsMenu();
						break;
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
			"3 - Поиск объявления по названию",
			"4 - Удалить объявление",
			"5 - Объявления на модерации",
			"0 - Выход"
		};

		public AdminMenu(List<Ad> adsList, List<Ad> moderAdsList) : base(adsList, moderAdsList)
		{
		}

		public override void HandleMenu()
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
					case ConsoleKey.D3:
						FindAdsMenu();
						break;
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
			if (moderAdsList.Count == 0)
			{
				Console.WriteLine("Список объявлений пуст. ");
			}
			else
			{
				int i = 0;
				foreach (Ad elem in moderAdsList)
				{
					i++;
					Console.WriteLine($"{i}\n{elem}");
					Console.WriteLine();
				}
				while (true)
				{
					int adNumber = (int)Helpers.AskPositiveNumber("Введите номер объявления для изменения статуса или 0 для выхода");
					if (adNumber == 0)
					{
						return;
					}
					else if (adNumber > moderAdsList.Count)
					{
						Console.WriteLine("Такого объявления не существует! ");
					}
					else
					{
						ulong action = Helpers.AskPositiveNumber("1 - разрешить объявление\n2 - удалить объявление\n0 - отмена ");
						switch (action)
						{
							case 1:
								Ad tempAd = moderAdsList[adNumber - 1];
								moderAdsList.RemoveAt(adNumber - 1);
								adsList.Add(tempAd);
								Console.WriteLine("Объявление опубликовано! ");
								break;
							case 2:
								moderAdsList.RemoveAt(adNumber - 1);
								Console.WriteLine("Объявление удалено! ");
								break;
							case 0:
								return;
						}
					}
				}
			}
			Helpers.AskForKey("Для возврата в главное меню нажмите любую клавишу... ");
		}
	}

	public class Ad
	{
		/*название товара, описание, цена, номер телефона продавца,
		 * фио продавца, дата-время создания*/
		public string adName;
		public string adDescription;
		public uint adPrice;
		public ulong sellerNumber;
		public string sellerName;
		public DateTime adDate = DateTime.Now;

		public override string ToString()
		{
			return
				$"Наименование: {adName} " +
				$"\nОписание: {adDescription} " +
				$"\nЦена: {adPrice} bucks " +
				$"\nНомер тел.: {sellerNumber} " +
				$"\nПродавец: {sellerName} " +
				$"\nДата размещения: {adDate} ";
		}

		public Ad(string adName, string adDescription, uint adPrice, ulong sellerNumber, string sellerName)
		{
			this.adName = adName;
			this.adDescription = adDescription;
			this.adPrice = adPrice;
			this.sellerNumber = sellerNumber;
			this.sellerName = sellerName;
		}

		public Ad()
		{
			adName = "AD_TEST";
			adDescription = "DESCRIPTION_TEST";
			adPrice = 0;
			sellerNumber = 89009990099;
			sellerName = "NAME_TEST";
			adDate = DateTime.Now;
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

	public class AdsDataBase
	{
		protected string fileName;
		public AdsDataBase(string fileName)
		{
			this.fileName = fileName;
		}
		public bool Save(List<Ad> adsList)
		{
			StreamWriter fileIn;
			try
			{
				fileIn = new StreamWriter(fileName);
				foreach (Ad elem in adsList)
				{
					fileIn.WriteLine(elem.adName);
					fileIn.WriteLine(elem.adDescription);
					fileIn.WriteLine(elem.adPrice);
					fileIn.WriteLine(elem.sellerNumber);
					fileIn.WriteLine(elem.sellerName);
					fileIn.WriteLine(elem.adDate);
				}
				fileIn.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ошибка! {ex.Message}");
				return false;
			}
			return true;
		}

		public List<Ad> Load()
		{
			List<Ad> ads = new();
			StreamReader fileOut;
			try
			{
				if (File.Exists(fileName))
				{
					fileOut = new StreamReader(fileName);
					while (!fileOut.EndOfStream)
					{
						Ad ad = new();

						ad.adName = fileOut.ReadLine();
						ad.adDescription = fileOut.ReadLine();
						ad.adPrice = uint.Parse(fileOut.ReadLine());
						ad.sellerNumber = ulong.Parse(fileOut.ReadLine());
						ad.sellerName = fileOut.ReadLine();
						ad.adDate = DateTime.Parse(fileOut.ReadLine());

						ads.Add(ad);
					}
					fileOut.Close();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ошибка! {ex.Message}");
				return null;
			}
			return ads;
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
