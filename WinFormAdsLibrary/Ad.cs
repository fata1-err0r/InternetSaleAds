using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WinFormAds
{
	public class Ad
	{
// 		public static List<Ad> adsListTest = new()
// 		{
// 			{ new Ad() },
// 			{ new Ad("Телефон", "iPont 99", 9999, 89000001111, "Вася") },
// 			{ new Ad("Консоль", "PayStation $", 3000, 89000002222, "Петя") },
// 			{ new Ad("Телевизор", "Pony", 5000, 89000003333, "Оля") },
// 			{ new Ad("Сумочка", "Гусси", 7000, 89000004444, "Катя") },
// 			{ new Ad("Кактус", "Колючий", 5, 89000005555, "Женя") }
// 		};

// 		public static List<Ad> adsList = AdsDataBase.adsDataBase.Load();
// 		public static List<Ad> moderList = AdsDataBase.moderAdsDataBase.Load();

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
				$"{adName}\t{adDescription}\t{adPrice}\t{sellerNumber}\t{sellerName}\t{adDate} ";
		}

		public Ad(string adName, string adDescription, uint adPrice, ulong sellerNumber, string sellerName, DateTime adDate)
		{
			this.adName = adName;
			this.adDescription = adDescription;
			this.adPrice = adPrice;
			this.sellerNumber = sellerNumber;
			this.sellerName = sellerName;
			this.adDate = adDate;
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

		enum CheckEnum
		{
			Ok = 0,
			Error1 = 1,
			Error2 = 2,
		}

		public static uint CheckPrice(string input)
		{
			bool check = int.TryParse(input, out int price);
			if (check)
			{
				if (price < 0)
				{
					return (uint)CheckEnum.Error1;
				}
				return (uint)CheckEnum.Ok;
			}
			else
			{
				return (uint)CheckEnum.Error2;
			}
		}

		public static uint CheckPhone(string input)
		{
			bool check = long.TryParse(input, out long phone);
			if (check)
			{
				if (phone < 0)
				{
					return (uint)CheckEnum.Error1;
				}
				return (uint)CheckEnum.Ok;
			}
			else
			{
				return (uint)CheckEnum.Error2;
			}
		}
	}

	public class AdModel
	{
		public static AdModel adsDataBase = new("AdsListDataBase.txt");
		public static AdModel moderAdsDataBase = new("ModerAdsListDataBase.txt");
		public static List<Ad> adsList = adsDataBase.Load();
		public static List<Ad> moderList = moderAdsDataBase.Load();

		protected string fileName;
		public AdModel(string fileName)
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

		public void AddAd(string adName, string adDescription, uint adPrice, ulong sellerNumber, string sellerName, DateTime adDate)
		{
			if (adsList.Any(ad => ad.adName == adName && ad.adDescription == adDescription && ad.adPrice == adPrice && ad.sellerNumber == sellerNumber && ad.sellerName == sellerName))
				throw new Exception("Такое объявление уже существует!");
			if (moderList.Any(ad => ad.adName == adName && ad.adDescription == adDescription && ad.adPrice == adPrice && ad.sellerNumber == sellerNumber && ad.sellerName == sellerName))
				throw new Exception("Такое объявление уже существует!");

			Ad ad = new(adName, adDescription, adPrice, sellerNumber, sellerName, adDate);

			if (adPrice >= 10000)
			{
				moderList.Add(ad);
				throw new Exception("Объявление отправлено на модерацию!");
			}
			else
			{
				adsList.Add(ad);
			}
		}
	}
}
