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
		public ulong sellerNumber;
		public string sellerName;
		public DateTime adsDate;    // Console.WriteLine(thisDay.ToString("g"));

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
			adsName = "ADS_TEST";
			adsDescription = "DESCRIPTION_TEST";
			adsPrice = 7777;
			sellerNumber = 89009990099;
			sellerName = "NAME_TEST";
			adsDate = DateTime.Now;
		}
		public Ads(string name, string desc, int price, ulong number, string nameSel, DateTime date)
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
