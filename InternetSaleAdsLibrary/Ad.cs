using System;
using System.Collections.Generic;
using System.IO;

namespace InternetSaleAdsLibrary
{
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
}
