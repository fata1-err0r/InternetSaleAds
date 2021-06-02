using System;
using System.Collections.Generic;
using System.Linq;

namespace WinFormAdsLibrary
{
	public class Ad
	{
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
	}

	public class AdModel
	{
		public List<Ad> adsList = new List<Ad>();
		public List<Ad> moderList = new List<Ad>();

		public AdModel()
		{
			adsList = AdDB.DatabaseLoad("general_ads");
			moderList = AdDB.DatabaseLoad("moder_ads");
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

		public void DelAd(int index)
		{
			adsList.RemoveAt(index);
		}

		public void CancelAd(int index)
		{
			moderList.RemoveAt(index);
		}

		public void SaveAds(List<Ad> adsList, List<Ad> moderList)
		{
			AdDB.DatabaseSave(adsList, "general_ads");
			AdDB.DatabaseSave(moderList, "moder_ads");
		}
	}
}
