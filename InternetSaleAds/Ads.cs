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
		public Ads(string adsName, string adsDescription, int adsPrice, ulong sellerNumber, string sellerName, DateTime adsDate)
		{
			this.adsName = adsName;
			this.adsDescription = adsDescription;
			this.adsPrice = adsPrice;
			this.sellerNumber = sellerNumber;
			this.sellerName = sellerName;
			this.adsDate = adsDate;
		}
		public Ads(string adsName, int adsPrice, ulong sellerNumber)
			: this(adsName, "тест описание", adsPrice, sellerNumber, "тест продавец", DateTime.Now)
		{
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
	}
}
