using System;
using System.Windows.Forms;
using WinFormAdsLibrary;

namespace WinFormAds
{
	public partial class FormISA : Form
	{
		public AdPresenter adPresenter;
		public int n = 0;

		public FormISA()
		{
			InitializeComponent();
			AdModel adModel = new();
			adPresenter = new AdPresenter(this, adModel);
		}

		public void DataGridViewUpdateAdsList()
		{
			adPresenter.UpdateAdsList(dataGridViewAdsList, dataGridViewModerAdsList);
		}

		private void buttonUpdateAdsList_Click(object sender, EventArgs e)
		{
			adPresenter.UpdateAdsList(dataGridViewAdsList, dataGridViewModerAdsList);
			if (dataGridViewAdsList.RowCount == 0)
			{
				MessageBox.Show("Список объявлений пуст!", "Ошибка!");
				return;
			}
		}

		private void buttonAddAd_Click(object sender, EventArgs e)
		{
			adPresenter.AddAd(textBoxAdNameAdd, textBoxAdDescriptionAdd, textBoxAdPriceAdd, textBoxSellerNumberAdd, textBoxSellerNameAdd);
		}

		private void buttonDelAd_Click(object sender, EventArgs e)
		{
			adPresenter.DelAd(dataGridViewAdsList);
		}

		private void buttonAllowAd_Click(object sender, EventArgs e)
		{
			adPresenter.AllowAd(dataGridViewAdsList, dataGridViewModerAdsList);
		}

		private void buttonCancelAd_Click(object sender, EventArgs e)
		{
			adPresenter.CancelAd(dataGridViewModerAdsList);
		}
		private void buttonSearchByAdName_Click(object sender, EventArgs e)
		{
			adPresenter.SearchByAdName(textBoxSearchByAdName, dataGridViewAdsList);
		}

		private void buttonFilteringAdsByNumber_Click(object sender, EventArgs e)
		{
			adPresenter.FilteringAdsByNumber(textBoxFilterBySellerNumber, dataGridViewAdsList);
		}

		private void ISA_Load(object sender, EventArgs e)
		{

		}

		private void buttonAdmin_Click(object sender, EventArgs e)
		{
			pictureBoxOligarkhMain.Hide();
			pictureBoxIcon.Show();
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
			labelFilterBySellerNumber.Show();
			textBoxFilterBySellerNumber.Show();
			buttonFilterBySellerNumber.Show();
			labelSearchByAdName.Show();
			textBoxSearchByAdName.Show();
			buttonSearchByAdName.Show();
			textBoxAdNameAdd.Show();
			textBoxAdDescriptionAdd.Show();
			textBoxAdPriceAdd.Show();
			textBoxSellerNumberAdd.Show();
			textBoxSellerNameAdd.Show();
			buttonAddAd.Show();
			DataGridViewUpdateAdsList();
		}

		private void buttonUser_Click(object sender, EventArgs e)
		{
			pictureBoxOligarkhMain.Hide();
			pictureBoxIcon.Show();
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
			labelFilterBySellerNumber.Show();
			textBoxFilterBySellerNumber.Show();
			buttonFilterBySellerNumber.Show();
			labelSearchByAdName.Show();
			textBoxSearchByAdName.Show();
			buttonSearchByAdName.Show();
			textBoxAdNameAdd.Show();
			textBoxAdDescriptionAdd.Show();
			textBoxAdPriceAdd.Show();
			textBoxSellerNumberAdd.Show();
			textBoxSellerNameAdd.Show();
			buttonAddAd.Show();
			DataGridViewUpdateAdsList();
		}

		private void buttonExitToMain_Click(object sender, EventArgs e)
		{
			pictureBoxOligarkhMain.Show();
			pictureBoxIcon.Hide();
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
			labelFilterBySellerNumber.Hide();
			textBoxFilterBySellerNumber.Hide();
			buttonFilterBySellerNumber.Hide();
			labelSearchByAdName.Hide();
			textBoxSearchByAdName.Hide();
			buttonSearchByAdName.Hide();
			textBoxAdNameAdd.Hide();
			textBoxAdDescriptionAdd.Hide();
			textBoxAdPriceAdd.Hide();
			textBoxSellerNumberAdd.Hide();
			textBoxSellerNameAdd.Hide();
			buttonAddAd.Hide();
			textBoxAdNameAdd.Clear();
			textBoxAdDescriptionAdd.Clear();
			textBoxAdPriceAdd.Clear();
			textBoxSellerNumberAdd.Clear();
			textBoxSellerNameAdd.Clear();
			textBoxSearchByAdName.Clear();
			textBoxFilterBySellerNumber.Clear();
			adPresenter.SaveAds(buttonExitToMain);
		}
	}
}
