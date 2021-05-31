using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormAdsLibrary
{
	class FormQustion : Form
	{
		Label lblQuestion;
		Button btnOk;
		Button btnNo;

		public FormQustion()
		{
			lblQuestion = new Label();
			btnOk = new Button();
			btnNo = new Button();

			lblQuestion.AutoSize = true;
			lblQuestion.Text = "Вы действительно хотите удалить объявление?";

			Size = new Size(900, 600);
			MaximizeBox = false;
			StartPosition = FormStartPosition.CenterScreen;
			Controls.Add(lblQuestion);
			Controls.Add(btnOk);
			Controls.Add(btnNo);

			btnOk.Size = new Size(300, 150);
			btnOk.Text = "Да";
			btnOk.Location = new Point(50, 300);

			btnNo.Size = new Size(300, 150);
			btnNo.Text = "Нет";
			btnNo.Location = new Point(500, 300);

			btnOk.Click += new EventHandler(OkBtnClk);
			btnNo.Click += new EventHandler(NoBtnClk);
		}

		public void OkBtnClk(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		public void NoBtnClk(object sender, EventArgs e)
		{
			DialogResult = DialogResult.No;
			Close();
		}
	}
}
