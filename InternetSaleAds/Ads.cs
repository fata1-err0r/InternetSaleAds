using System;

namespace InternetSaleAds
{
	class Ads
	{
		/*название товара, описание, цена, номер телефона продавца,
		 * фио продавца, дата-время создания*/
		public string adsName;
		public string adsDescription;
		public int adsPrice;
		public long sellerNumber;
		public string sellerName;
		public DateTime	adsDate;	// Console.WriteLine(thisDay.ToString("g"));

		public void GetInfo()
		{
			Console.WriteLine($"Наименование: {adsName} " +
				$"\nОписание: {adsDescription} " +
				$"\nЦена: {adsPrice} " +
				$"\nНомер тел.: {sellerNumber} " +
				$"\nПродавец: {sellerName} " +
				$"\nДата размещения: {adsDate} ");
		}
		public Ads()
		{
			adsName = "Тестовый товар";
			adsDescription = "Тестовое описание";
			adsPrice = 5000;
			sellerNumber = 89008889988;
			sellerName = "Тестовое Имя";
			adsDate = DateTime.Now;
		}
		public Ads(string name, string desc, int price, long number, string nameSel, DateTime date)
		{
			adsName = name;
			adsDescription = desc;
			adsPrice = price;
			sellerNumber = number;
			sellerName = nameSel;
			adsDate = date;
		}

	}
}
