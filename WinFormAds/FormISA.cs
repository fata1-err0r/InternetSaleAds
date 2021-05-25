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
		public int n = 0;

		public FormISA()
		{
			InitializeComponent();
			AdModel adModel = new("Ads.txt");
			adPresenter = new AdPresenter(this, adModel);
			DataGridViewAdsUpdate();
		}

		public void DataGridViewAdsUpdate()
		{
			adPresenter.UpdateAdList(dataGridViewAdsList, dataGridViewModerAdsList);
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

		private void buttonFilteringAdsByNumber_Click(object sender, EventArgs e)
		{
			ulong filterAdsByPhone;
			if (!ulong.TryParse(textBoxFilterBySellerNumber.Text, out filterAdsByPhone))
			{
				MessageBox.Show("Не получилось прочитать номер!", "Ошибка!");
				return;
			}

			var filteredAdsByPhone = from query in AdModel.adsList
									 where query.sellerNumber.Equals(filterAdsByPhone)
									 select query;

			if (filteredAdsByPhone.Count() == 0)
			{
				MessageBox.Show("Объявлений не найдено!", "Ошибка!");
				return;
			}
			else
			{
				DataGridViewAdsUpdate();
			}
		}
	}
}
