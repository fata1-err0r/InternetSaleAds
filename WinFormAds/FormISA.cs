using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormAdsLibrary;

namespace WinFormAds
{
	public partial class FormISA : Form
	{
		public AdPresenter adPresenter;
		public AdPresenter adModerPresenter;
		public int n = 0;

		public FormISA()
		{
			InitializeComponent();
			AdModel adModel = new AdModel("AdsListDataBase.txt");
			AdModel adModerModel = new AdModel("ModerAdsListDataBase.txt");
			adPresenter = new AdPresenter(this, adModel);
			adModerPresenter = new AdPresenter(this, adModerModel);
			DataGridViewAdsUpdate();
		}

		public void DataGridViewAdsUpdate()
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

		private void buttonAddAd_Click(object sender, EventArgs e)
		{
			adPresenter.AddAd(textBoxAdNameAdd, textBoxAdDescriptionAdd, textBoxAdPriceAdd, textBoxSellerNumberAdd, textBoxSellerNameAdd);
		}

		private void buttonAllowAd_Click(object sender, EventArgs e)
		{
			int selectedAd = dataGridViewModerAdsList.SelectedCells[0].RowIndex;
			string adName = dataGridViewModerAdsList.Rows[selectedAd].Cells[0].Value.ToString();
			string adDescription = dataGridViewModerAdsList.Rows[selectedAd].Cells[1].Value.ToString();
			uint adPrice = (uint)dataGridViewModerAdsList.Rows[selectedAd].Cells[2].Value;
			ulong sellerNumber = (ulong)dataGridViewModerAdsList.Rows[selectedAd].Cells[3].Value;
			string sellerName = dataGridViewModerAdsList.Rows[selectedAd].Cells[4].Value.ToString();
			DateTime adDate = (DateTime)dataGridViewModerAdsList.Rows[selectedAd].Cells[5].Value;

			Ad tempAd = new( adName,  adDescription,  adPrice,  sellerNumber,  sellerName,  adDate);
			if (dataGridViewModerAdsList.RowCount == 0)
			{
				MessageBox.Show("Список объявлений пуст!", "Ошибка!");
				return;
			}
			dataGridViewModerAdsList.Rows.RemoveAt(selectedAd);
			AdModel.moderList.RemoveAt(selectedAd);
			AdModel.adsList.Add(tempAd);
			DataGridViewAdsUpdate();
		}

		private void buttonDelAd_Click(object sender, EventArgs e)
		{
			if (dataGridViewAdsList.RowCount == 0)
			{
				MessageBox.Show("Список объявлений пуст!", "Ошибка!");
				return;
			}
			int delet = dataGridViewAdsList.SelectedCells[0].RowIndex;
			dataGridViewAdsList.Rows.RemoveAt(delet);
			AdModel.adsList.RemoveAt(delet);
			DataGridViewAdsUpdate();
		}

		private void buttonCancelAd_Click(object sender, EventArgs e)
		{
			if (dataGridViewModerAdsList.RowCount == 0)
			{
				MessageBox.Show("Список объявлений пуст!", "Ошибка!");
				return;
			}
			int delet = dataGridViewModerAdsList.SelectedCells[0].RowIndex;
			dataGridViewModerAdsList.Rows.RemoveAt(delet);
			AdModel.moderList.RemoveAt(delet);
			DataGridViewAdsUpdate();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void ISA_Load(object sender, EventArgs e)
		{

		}
		private void buttonAdmin_Click(object sender, EventArgs e)
		{
			labelChooseProfile.Hide();
			labelAdFields.Show();
			labelStarsShitAdm.Show();
			labelStarsShitUsr.Hide();
			tabControlAds.Show();
			tabControlAds.TabPages.Clear();
			tabControlAds.TabPages.Add(tabPageAdsList);
			tabControlAds.TabPages.Add(tabPageModerAdsList);
			labelAdmin.Show();
			labelUser.Hide();
			buttonAdmin.Hide();
			buttonUser.Hide();
			buttonExitToMain.Show();
			dataGridViewAdsList.Show();
			buttonDelAd.Show();
			dataGridViewModerAdsList.Show();
			buttonAllowAd.Show();
			buttonCancelAd.Show();
			labelFilteringAds.Show();
			textBoxFilterBySellerNumber.Show();
			buttonFilterBySellerNumber.Show();
			textBoxAdNameAdd.Show();
			textBoxAdDescriptionAdd.Show();
			textBoxAdPriceAdd.Show();
			textBoxSellerNumberAdd.Show();
			textBoxSellerNameAdd.Show();
			buttonAddAd.Show();
		}

		private void buttonUser_Click(object sender, EventArgs e)
		{
			labelChooseProfile.Hide();
			labelAdFields.Show();
			labelStarsShitAdm.Hide();
			labelStarsShitUsr.Show();
			tabControlAds.Show();
			tabControlAds.TabPages.Remove(tabPageModerAdsList); 
			labelAdmin.Hide();
			labelUser.Show();
			buttonAdmin.Hide();
			buttonUser.Hide();
			buttonExitToMain.Show();
			dataGridViewAdsList.Show();
			buttonDelAd.Hide();
			dataGridViewModerAdsList.Hide();
			buttonAllowAd.Hide();
			buttonCancelAd.Hide();
			labelFilteringAds.Show();
			textBoxFilterBySellerNumber.Show();
			buttonFilterBySellerNumber.Show();
			textBoxAdNameAdd.Show();
			textBoxAdDescriptionAdd.Show();
			textBoxAdPriceAdd.Show();
			textBoxSellerNumberAdd.Show();
			textBoxSellerNameAdd.Show();
			buttonAddAd.Show();
		}

		private void buttonExitToMain_Click(object sender, EventArgs e)
		{
			labelChooseProfile.Show();
			labelAdFields.Hide();
			labelStarsShitAdm.Hide();
			labelStarsShitUsr.Hide();
			tabControlAds.Hide();
			labelAdmin.Hide();
			labelUser.Hide();
			buttonAdmin.Show();
			buttonUser.Show();
			buttonExitToMain.Hide();
			dataGridViewAdsList.Hide();
			buttonDelAd.Hide();
			dataGridViewModerAdsList.Hide();
			buttonAllowAd.Hide();
			buttonCancelAd.Hide();
			labelFilteringAds.Hide();
			textBoxFilterBySellerNumber.Hide();
			buttonFilterBySellerNumber.Hide();
			textBoxAdNameAdd.Hide();
			textBoxAdDescriptionAdd.Hide();
			textBoxAdPriceAdd.Hide();
			textBoxSellerNumberAdd.Hide();
			textBoxSellerNameAdd.Hide();
			buttonAddAd.Hide();

			AdModel.adsDataBase.Save(AdModel.adsList);
			AdModel.moderAdsDataBase.Save(AdModel.moderList);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridViewModerAdsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void labelFilteringAds_Click(object sender, EventArgs e)
		{

		}

		private void buttonFilteringAdsByNumber_Click(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void dataGridViewAdsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void buttonPrintAdsList_MouseClick(object sender, MouseEventArgs e)
		{

		}

		private void labelAdName_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBoxAdPriceAdd_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBoxAdDescriptionAdd_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBoxAdNameAdd_TextChanged(object sender, EventArgs e)
		{

		}

		private void labelChooseProfile_Click(object sender, EventArgs e)
		{

		}
	}
}
