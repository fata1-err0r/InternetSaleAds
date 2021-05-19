using System;
using System.Windows.Forms;

namespace WinFormAds
{
	public partial class FormISA : Form
	{
		public FormISA()
		{
			InitializeComponent();
			DataGridViewAdsUpdate();
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
				textBoxSellerNameAdd.Text.Trim() == "")
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
			DataGridViewAdsUpdate();
		}
		private void DataGridViewAdsUpdate()
		{
			dataGridViewAdsList.RowCount = Ad.adsList.Count;
			for (int i = 0; i < dataGridViewAdsList.Rows.Count; i++)
			{
				dataGridViewAdsList.Rows[i].Cells[0].Value = Ad.adsList[i].adName;
				dataGridViewAdsList.Rows[i].Cells[1].Value = Ad.adsList[i].adDescription;
				dataGridViewAdsList.Rows[i].Cells[2].Value = Ad.adsList[i].adPrice;
				dataGridViewAdsList.Rows[i].Cells[3].Value = Ad.adsList[i].sellerNumber;
				dataGridViewAdsList.Rows[i].Cells[4].Value = Ad.adsList[i].sellerName;
				dataGridViewAdsList.Rows[i].Cells[5].Value = Ad.adsList[i].adDate;
			}

			dataGridViewModerAdsList.RowCount = Ad.moderList.Count;
			for (int i = 0; i < dataGridViewModerAdsList.Rows.Count; i++)
			{
				dataGridViewModerAdsList.Rows[i].Cells[0].Value = Ad.moderList[i].adName;
				dataGridViewModerAdsList.Rows[i].Cells[1].Value = Ad.moderList[i].adDescription;
				dataGridViewModerAdsList.Rows[i].Cells[2].Value = Ad.moderList[i].adPrice;
				dataGridViewModerAdsList.Rows[i].Cells[3].Value = Ad.moderList[i].sellerNumber;
				dataGridViewModerAdsList.Rows[i].Cells[4].Value = Ad.moderList[i].sellerName;
				dataGridViewModerAdsList.Rows[i].Cells[5].Value = Ad.moderList[i].adDate;
			}
		}

		private void buttonDelAd_Click(object sender, EventArgs e)
		{
			if (dataGridViewAdsList.SelectedRows == null)
			{
				MessageBox.Show("Выберите объявление для удаления!", "Ошибка выбора!");
				return;
			}
			int delet = dataGridViewAdsList.SelectedCells[0].RowIndex;
			dataGridViewAdsList.Rows.RemoveAt(delet); 
			Ad.adsList.RemoveAt(delet);
			DataGridViewAdsUpdate();
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
	}
}
