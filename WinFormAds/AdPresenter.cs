using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinFormAds;

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
			for (int i = 0; i < AdModel.adsList.Count; i++)
			{
				var row = dataGridViewAdsList.Rows[i];
				row.Tag = i;

				row.Cells[0].Value = AdModel.adsList[i].adName;
				row.Cells[1].Value = AdModel.adsList[i].adDescription;
				row.Cells[2].Value = AdModel.adsList[i].adPrice;
				row.Cells[3].Value = AdModel.adsList[i].sellerNumber;
				row.Cells[4].Value = AdModel.adsList[i].sellerName;
				row.Cells[5].Value = AdModel.adsList[i].adDate;
			}

			dataGridViewModerAdsList.RowCount = AdModel.moderList.Count;
			for (int i = 0; i < AdModel.moderList.Count; i++)
			{
				var row = dataGridViewModerAdsList.Rows[i];
				row.Tag = i;

				row.Cells[0].Value = AdModel.moderList[i].adName;
				row.Cells[1].Value = AdModel.moderList[i].adDescription;
				row.Cells[2].Value = AdModel.moderList[i].adPrice;
				row.Cells[3].Value = AdModel.moderList[i].sellerNumber;
				row.Cells[4].Value = AdModel.moderList[i].sellerName;
				row.Cells[5].Value = AdModel.moderList[i].adDate;
			}
		}

		public void AddAd(TextBox textBoxAdNameAdd, TextBox textBoxAdDescriptionAdd, TextBox textBoxAdPriceAdd, TextBox textBoxSellerNumberAdd, TextBox textBoxSellerNameAdd)
		{
			string adName = textBoxAdNameAdd.Text.Trim();
			string adDescription = textBoxAdDescriptionAdd.Text.Trim();
			uint adPrice;

			if (textBoxAdNameAdd.Text.Trim() == "" ||
				textBoxAdDescriptionAdd.Text.Trim() == "" ||
				textBoxAdPriceAdd.Text.Trim() == "" ||
				textBoxSellerNumberAdd.Text.Trim() == "" ||
				textBoxSellerNameAdd.Text.Trim() == "")
			{
				MessageBox.Show("Не все поля заполнены!", "Ошибка!");
				return;
			}

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

			try
			{
				model.AddAd(adName, adDescription, adPrice, sellerNumber, sellerName, adDate);
				MessageBox.Show("Объявление добавлено!", "Успех!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Внимание!");
			}
			textBoxAdNameAdd.Clear();
			textBoxAdDescriptionAdd.Clear();
			textBoxAdPriceAdd.Clear();
			textBoxSellerNumberAdd.Clear();
			textBoxSellerNameAdd.Clear();
			View.DataGridViewUpdateAdsList();
		}

		public void DelAd(DataGridView dataGridViewAdsList)
		{
			if (dataGridViewAdsList.RowCount == 0)
			{
				MessageBox.Show("Список объявлений пуст!", "Ошибка!");
				return;
			}

			FormQustion question = new FormQustion();
			question.ShowDialog();
			if (question.DialogResult == DialogResult.OK)
			{
				int delet = dataGridViewAdsList.SelectedCells[0].RowIndex;
				int indexFromBase = (int)dataGridViewAdsList.Rows[delet].Tag;

				AdDB.DatabaseDelete(AdModel.adsList[indexFromBase], "general_ads");
				model.DelAd(indexFromBase);
				dataGridViewAdsList.Rows.RemoveAt(delet);
				View.DataGridViewUpdateAdsList();
			}
		}

		public void AllowAd(DataGridView dataGridViewAdsList, DataGridView dataGridViewModerAdsList)
		{
			if (dataGridViewModerAdsList.RowCount == 0)
			{
				MessageBox.Show("Список объявлений пуст!", "Ошибка!");
				return;
			}

			int selectedAd = dataGridViewModerAdsList.SelectedCells[0].RowIndex;
			int indexFromBase = (int)dataGridViewModerAdsList.Rows[selectedAd].Tag;

			Ad tempAd = AdModel.moderList[indexFromBase];
			AdModel.adsList.Add(tempAd);

			AdDB.DatabaseDelete(AdModel.moderList[indexFromBase], "moder_ads");
			model.CancelAd(indexFromBase);
			dataGridViewModerAdsList.Rows.RemoveAt(selectedAd);
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
			int indexFromBase = (int)dataGridViewModerAdsList.Rows[delet].Tag;

			AdDB.DatabaseDelete(AdModel.moderList[indexFromBase], "moder_ads");
			model.CancelAd(indexFromBase);
			dataGridViewModerAdsList.Rows.RemoveAt(delet);
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
				for (int i = 0; i < foundAds.Count(); i++)
				{
					var row = dataGridViewAdsList.Rows[i];
					row.Tag = i;

					row.Cells[0].Value = foundAdsByAdNameList[i].adName;
					row.Cells[1].Value = foundAdsByAdNameList[i].adDescription;
					row.Cells[2].Value = foundAdsByAdNameList[i].adPrice;
					row.Cells[3].Value = foundAdsByAdNameList[i].sellerNumber;
					row.Cells[4].Value = foundAdsByAdNameList[i].sellerName;
					row.Cells[5].Value = foundAdsByAdNameList[i].adDate;
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
				for (int i = 0; i < filteredAds.Count(); i++)
				{
					var row = dataGridViewAdsList.Rows[i];
					row.Tag = i;

					row.Cells[0].Value = foundAdsByPhoneList[i].adName;
					row.Cells[1].Value = foundAdsByPhoneList[i].adDescription;
					row.Cells[2].Value = foundAdsByPhoneList[i].adPrice;
					row.Cells[3].Value = foundAdsByPhoneList[i].sellerNumber;
					row.Cells[4].Value = foundAdsByPhoneList[i].sellerName;
					row.Cells[5].Value = foundAdsByPhoneList[i].adDate;
				}
			}
		}
	}
}
