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
			lblQuestion.Location = new Point(70, 30);

			Size = new Size(400, 200);
			MaximizeBox = false;
			StartPosition = FormStartPosition.CenterScreen;
			Controls.Add(lblQuestion);
			Controls.Add(btnOk);
			Controls.Add(btnNo);

			btnOk.Size = new Size(100, 50);
			btnOk.Text = "Да";
			btnOk.Location = new Point(50, 70);

			btnNo.Size = new Size(100, 50);
			btnNo.Text = "Нет";
			btnNo.Location = new Point(250, 70);

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
