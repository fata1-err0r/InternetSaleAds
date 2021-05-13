using System;
using System.Windows.Forms;

namespace WinFormAds
{
	public partial class FormISA : Form
	{
		public FormISA()
		{
			InitializeComponent();
			ListBoxAdsUpdate();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void ISA_Load(object sender, EventArgs e)
		{

		}

		private void buttonUser_Click(object sender, EventArgs e)
		{

		}

		private void buttonAdmin_Click(object sender, EventArgs e)
		{

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

		private void buttonPrintAdsList_Click(object sender, EventArgs e)
		{
			listBoxAdsList.Items.Clear();
			foreach (var ads in Ad.adsList)
				listBoxAdsList.Items.Add(ads);
		}

		private void dataGridViewAdsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void buttonPrintAdsList_MouseClick(object sender, MouseEventArgs e)
		{

		}

		private void buttonAddAd_Click(object sender, EventArgs e)
		{
			string adName = textBoxAdNameAdd.Text.Trim();
			string adDescription = textBoxAdDescriptionAdd.Text.Trim();
			string sellerName = textBoxSellerNameAdd.Text.Trim();

			if (textBoxAdNameAdd.Text.Trim() == "" || 
				textBoxAdDescriptionAdd.Text.Trim() == "" ||
				textBoxAdPriceAdd.Text.Trim() == "" ||
				textBoxSellerNumberAdd.Text.Trim() == "" ||
				textBoxSellerNameAdd.Text.Trim() == "" )
			{
				MessageBox.Show("Не все поля заполнены!", "Ошибка!");
				return;
			}

			uint adPrice;
			if (!uint.TryParse(textBoxAdPriceAdd.Text, out adPrice))
			{
				MessageBox.Show("Не получилось прочесть цену!", "Ошибка!");
				return;
			}
			ulong sellerNumber;
			if (!ulong.TryParse(textBoxSellerNumberAdd.Text, out sellerNumber))
			{
				MessageBox.Show("Не получилось прочесть номер!", "Ошибка!");
				return;
			}
			DateTime adDate = DateTime.Now;
			Ad.adsList.Add(new Ad(adName, adDescription, adPrice, sellerNumber, sellerName, adDate));
			ListBoxAdsUpdate();
		}
		private void ListBoxAdsUpdate()
		{
			listBoxAdsList.Items.Clear();
			foreach (var ads in Ad.adsList)
				listBoxAdsList.Items.Add(ads);
		}

		private void buttonDelAd_Click(object sender, EventArgs e)
		{
			if ((Ad)listBoxAdsList.SelectedItem == null)
			{
				MessageBox.Show("Выберите объявление для удаления!", "Ошибка выбора!");
				return;
			}
			Ad.adsList.Remove((Ad)listBoxAdsList.SelectedItem);
			ListBoxAdsUpdate();
		}
	}
}
