using System;
using System.Windows.Forms;
using WinFormAds;
using System.Linq;


namespace WinFormAdsLibrary
{
	public class AdPresenter
	{
		public AdModel model;
		public FormISA View;
		public AdPresenter(FormISA view, AdModel adModel)
		{
			View = view;
			model = adModel;
		}

		public void AddAd(TextBox textBoxAdNameAdd, TextBox textBoxAdDescriptionAdd, TextBox textBoxAdPriceAdd, TextBox textBoxSellerNumberAdd, TextBox textBoxSellerNameAdd)
		{
			string adName = textBoxAdNameAdd.Text.Trim();
			string adDescription = textBoxAdDescriptionAdd.Text.Trim();
			uint adPrice;
			if (!uint.TryParse(textBoxAdPriceAdd.Text, out adPrice))
			{
				MessageBox.Show("Не получилось прочитать цену!", "Ошибка!");
				return;
			}
			ulong sellerNumber;
			if (!ulong.TryParse(textBoxSellerNumberAdd.Text, out sellerNumber))
			{
				MessageBox.Show("Не получилось прочитать номер!", "Ошибка!");
				return;
			}
			string sellerName = textBoxSellerNameAdd.Text.Trim();
			DateTime adDate = DateTime.Now;

			if (textBoxAdNameAdd.Text.Trim() == "" ||
				textBoxAdDescriptionAdd.Text.Trim() == "" ||
				textBoxAdPriceAdd.Text.Trim() == "" ||
				textBoxSellerNumberAdd.Text.Trim() == "" ||
				textBoxSellerNameAdd.Text.Trim() == "")
			{
				MessageBox.Show("Не все поля заполнены!", "Ошибка!");
				return;
			}
			try
			{
				model.AddAd(adName, adDescription, adPrice, sellerNumber, sellerName, adDate);
				MessageBox.Show("Объявление добавлено!", "Успех!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Внимание!");
			}
			View.DataGridViewAdsUpdate();
		}
	}
}
