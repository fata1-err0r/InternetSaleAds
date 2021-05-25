using System;
using System.Windows.Forms;
using WinFormAds;
using System.Linq;
using System.Collections.Generic;

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

		public void UpdateAdsList(DataGridView dataGridViewAdsList, DataGridView dataGridViewModerAdsList)
		{
			dataGridViewAdsList.RowCount = AdModel.adsList.Count;
			for (int i = 0; i < dataGridViewAdsList.Rows.Count; i++)
			{
				dataGridViewAdsList.Rows[i].Cells[0].Value = AdModel.adsList[i].adName;
				dataGridViewAdsList.Rows[i].Cells[1].Value = AdModel.adsList[i].adDescription;
				dataGridViewAdsList.Rows[i].Cells[2].Value = AdModel.adsList[i].adPrice;
				dataGridViewAdsList.Rows[i].Cells[3].Value = AdModel.adsList[i].sellerNumber;
				dataGridViewAdsList.Rows[i].Cells[4].Value = AdModel.adsList[i].sellerName;
				dataGridViewAdsList.Rows[i].Cells[5].Value = AdModel.adsList[i].adDate;
			}

			dataGridViewModerAdsList.RowCount = AdModel.moderList.Count;
			for (int i = 0; i < dataGridViewModerAdsList.Rows.Count; i++)
			{
				dataGridViewModerAdsList.Rows[i].Cells[0].Value = AdModel.moderList[i].adName;
				dataGridViewModerAdsList.Rows[i].Cells[1].Value = AdModel.moderList[i].adDescription;
				dataGridViewModerAdsList.Rows[i].Cells[2].Value = AdModel.moderList[i].adPrice;
				dataGridViewModerAdsList.Rows[i].Cells[3].Value = AdModel.moderList[i].sellerNumber;
				dataGridViewModerAdsList.Rows[i].Cells[4].Value = AdModel.moderList[i].sellerName;
				dataGridViewModerAdsList.Rows[i].Cells[5].Value = AdModel.moderList[i].adDate;
			}
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
			View.DataGridViewUpdateAdsList();
		}

		public void DelAd(DataGridView dataGridViewAdsList)
		{
			if (dataGridViewAdsList.RowCount == 0)
			{
				MessageBox.Show("Список объявлений пуст!", "Ошибка!");
				return;
			}
			int delet = dataGridViewAdsList.SelectedCells[0].RowIndex;
			dataGridViewAdsList.Rows.RemoveAt(delet);
			AdModel.adsList.RemoveAt(delet);
			View.DataGridViewUpdateAdsList();
		}

		public void AllowAd(DataGridView dataGridViewAdsList, DataGridView dataGridViewModerAdsList)
		{
			if (dataGridViewModerAdsList.RowCount == 0)
			{
				MessageBox.Show("Список объявлений пуст!", "Ошибка!");
				return;
			}

			int selectedAd = dataGridViewModerAdsList.SelectedCells[0].RowIndex;
			string adName = dataGridViewModerAdsList.Rows[selectedAd].Cells[0].Value.ToString();
			string adDescription = dataGridViewModerAdsList.Rows[selectedAd].Cells[1].Value.ToString();
			uint adPrice = (uint)dataGridViewModerAdsList.Rows[selectedAd].Cells[2].Value;
			ulong sellerNumber = (ulong)dataGridViewModerAdsList.Rows[selectedAd].Cells[3].Value;
			string sellerName = dataGridViewModerAdsList.Rows[selectedAd].Cells[4].Value.ToString();
			DateTime adDate = (DateTime)dataGridViewModerAdsList.Rows[selectedAd].Cells[5].Value;

			Ad tempAd = new(adName, adDescription, adPrice, sellerNumber, sellerName, adDate);
			dataGridViewModerAdsList.Rows.RemoveAt(selectedAd);
			AdModel.moderList.RemoveAt(selectedAd);
			AdModel.adsList.Add(tempAd);
			View.DataGridViewUpdateAdsList();
		}

		public void CancelAd(DataGridView dataGridViewModerAdsList)
		{
			if (dataGridViewModerAdsList.RowCount == 0)
			{
				MessageBox.Show("Список объявлений пуст!", "Ошибка!");
				return;
			}
			int delet = dataGridViewModerAdsList.SelectedCells[0].RowIndex;
			dataGridViewModerAdsList.Rows.RemoveAt(delet);
			AdModel.moderList.RemoveAt(delet);
			View.DataGridViewUpdateAdsList();
		}

		public void SearchByAdName(TextBox textBoxSearchByAdName, DataGridView dataGridViewAdsList)
		{
			string searchByAdName = textBoxSearchByAdName.Text.Trim();

			var foundAds = from query in AdModel.adsList
						   where query.adName.Equals(searchByAdName)
						   select query;

			if (foundAds.Count() == 0)
			{
				MessageBox.Show("Объявлений не найдено!", "Ошибка!");
				return;
			}
			else
			{
				List<Ad> foundAdsByAdNameList = new();
				foreach (Ad elem in foundAds)
				{
					foundAdsByAdNameList.Add(elem);
				}

				dataGridViewAdsList.RowCount = foundAds.Count();
				for (int i = 0; i < dataGridViewAdsList.Rows.Count; i++)
				{
					dataGridViewAdsList.Rows[i].Cells[0].Value = foundAdsByAdNameList[i].adName;
					dataGridViewAdsList.Rows[i].Cells[1].Value = foundAdsByAdNameList[i].adDescription;
					dataGridViewAdsList.Rows[i].Cells[2].Value = foundAdsByAdNameList[i].adPrice;
					dataGridViewAdsList.Rows[i].Cells[3].Value = foundAdsByAdNameList[i].sellerNumber;
					dataGridViewAdsList.Rows[i].Cells[4].Value = foundAdsByAdNameList[i].sellerName;
					dataGridViewAdsList.Rows[i].Cells[5].Value = foundAdsByAdNameList[i].adDate;
				}
			}
		}

		public void FilteringAdsByNumber(TextBox textBoxFilterBySellerNumber, DataGridView dataGridViewAdsList)
		{
			ulong filterAdsByPhone;
			if (!ulong.TryParse(textBoxFilterBySellerNumber.Text, out filterAdsByPhone))
			{
				MessageBox.Show("Не получилось прочитать номер!", "Ошибка!");
				return;
			}

			var filteredAds = from query in AdModel.adsList
							  where query.sellerNumber.Equals(filterAdsByPhone)
							  select query;

			if (filteredAds.Count() == 0)
			{
				MessageBox.Show("Объявлений не найдено!", "Ошибка!");
				return;
			}
			else
			{
				List<Ad> foundAdsByPhoneList = new();
				foreach (Ad elem in filteredAds)
				{
					foundAdsByPhoneList.Add(elem);
				}

				dataGridViewAdsList.RowCount = filteredAds.Count();
				for (int i = 0; i < dataGridViewAdsList.Rows.Count; i++)
				{
					dataGridViewAdsList.Rows[i].Cells[0].Value = foundAdsByPhoneList[i].adName;
					dataGridViewAdsList.Rows[i].Cells[1].Value = foundAdsByPhoneList[i].adDescription;
					dataGridViewAdsList.Rows[i].Cells[2].Value = foundAdsByPhoneList[i].adPrice;
					dataGridViewAdsList.Rows[i].Cells[3].Value = foundAdsByPhoneList[i].sellerNumber;
					dataGridViewAdsList.Rows[i].Cells[4].Value = foundAdsByPhoneList[i].sellerName;
					dataGridViewAdsList.Rows[i].Cells[5].Value = foundAdsByPhoneList[i].adDate;
				}
			}
		}
	}
}
