
namespace WinFormAds
{
	partial class FormISA
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.buttonAdmin = new System.Windows.Forms.Button();
			this.buttonUser = new System.Windows.Forms.Button();
			this.dataGridViewAdsList = new System.Windows.Forms.DataGridView();
			this.ColumnAdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAdDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSellerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControlAdmin = new System.Windows.Forms.TabControl();
			this.tabPageAdsList = new System.Windows.Forms.TabPage();
			this.buttonFilterBySellerNumber = new System.Windows.Forms.Button();
			this.textBoxFilterBySellerNumber = new System.Windows.Forms.TextBox();
			this.labelFilteringAds = new System.Windows.Forms.Label();
			this.buttonDelAd = new System.Windows.Forms.Button();
			this.tabPageModerAdsList = new System.Windows.Forms.TabPage();
			this.buttonCancelAd = new System.Windows.Forms.Button();
			this.buttonAllowAd = new System.Windows.Forms.Button();
			this.dataGridViewModerAdsList = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxSellerNameAdd = new System.Windows.Forms.TextBox();
			this.textBoxSellerNumberAdd = new System.Windows.Forms.TextBox();
			this.textBoxAdPriceAdd = new System.Windows.Forms.TextBox();
			this.textBoxAdDescriptionAdd = new System.Windows.Forms.TextBox();
			this.textBoxAdNameAdd = new System.Windows.Forms.TextBox();
			this.buttonAddAd = new System.Windows.Forms.Button();
			this.buttonPrintAdsList = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdsList)).BeginInit();
			this.tabControlAdmin.SuspendLayout();
			this.tabPageAdsList.SuspendLayout();
			this.tabPageModerAdsList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewModerAdsList)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAdmin
			// 
			this.buttonAdmin.Location = new System.Drawing.Point(33, 33);
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.Size = new System.Drawing.Size(267, 116);
			this.buttonAdmin.TabIndex = 0;
			this.buttonAdmin.Text = "Admin";
			this.buttonAdmin.UseVisualStyleBackColor = true;
			this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
			// 
			// buttonUser
			// 
			this.buttonUser.Location = new System.Drawing.Point(343, 33);
			this.buttonUser.Name = "buttonUser";
			this.buttonUser.Size = new System.Drawing.Size(267, 116);
			this.buttonUser.TabIndex = 1;
			this.buttonUser.Text = "User";
			this.buttonUser.UseVisualStyleBackColor = true;
			this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
			// 
			// dataGridViewAdsList
			// 
			this.dataGridViewAdsList.AllowUserToAddRows = false;
			this.dataGridViewAdsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAdsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAdName,
            this.ColumnAdDescription,
            this.ColumnAdPrice,
            this.ColumnSellerNumber,
            this.ColumnSellerName,
            this.ColumnAdDate});
			this.dataGridViewAdsList.Location = new System.Drawing.Point(3, 0);
			this.dataGridViewAdsList.Name = "dataGridViewAdsList";
			this.dataGridViewAdsList.RowHeadersWidth = 123;
			this.dataGridViewAdsList.RowTemplate.Height = 57;
			this.dataGridViewAdsList.Size = new System.Drawing.Size(1926, 969);
			this.dataGridViewAdsList.TabIndex = 2;
			this.dataGridViewAdsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdsList_CellContentClick);
			// 
			// ColumnAdName
			// 
			this.ColumnAdName.HeaderText = "Название";
			this.ColumnAdName.MinimumWidth = 15;
			this.ColumnAdName.Name = "ColumnAdName";
			this.ColumnAdName.ReadOnly = true;
			this.ColumnAdName.Width = 300;
			// 
			// ColumnAdDescription
			// 
			this.ColumnAdDescription.HeaderText = "Описание";
			this.ColumnAdDescription.MinimumWidth = 15;
			this.ColumnAdDescription.Name = "ColumnAdDescription";
			this.ColumnAdDescription.ReadOnly = true;
			this.ColumnAdDescription.Width = 300;
			// 
			// ColumnAdPrice
			// 
			this.ColumnAdPrice.HeaderText = "Цена";
			this.ColumnAdPrice.MinimumWidth = 15;
			this.ColumnAdPrice.Name = "ColumnAdPrice";
			this.ColumnAdPrice.ReadOnly = true;
			this.ColumnAdPrice.Width = 300;
			// 
			// ColumnSellerNumber
			// 
			this.ColumnSellerNumber.HeaderText = "Телефон";
			this.ColumnSellerNumber.MinimumWidth = 15;
			this.ColumnSellerNumber.Name = "ColumnSellerNumber";
			this.ColumnSellerNumber.ReadOnly = true;
			this.ColumnSellerNumber.Width = 300;
			// 
			// ColumnSellerName
			// 
			this.ColumnSellerName.HeaderText = "Продавец";
			this.ColumnSellerName.MinimumWidth = 15;
			this.ColumnSellerName.Name = "ColumnSellerName";
			this.ColumnSellerName.ReadOnly = true;
			this.ColumnSellerName.Width = 300;
			// 
			// ColumnAdDate
			// 
			this.ColumnAdDate.HeaderText = "Размещено";
			this.ColumnAdDate.MinimumWidth = 15;
			this.ColumnAdDate.Name = "ColumnAdDate";
			this.ColumnAdDate.ReadOnly = true;
			this.ColumnAdDate.Width = 300;
			// 
			// tabControlAdmin
			// 
			this.tabControlAdmin.Controls.Add(this.tabPageAdsList);
			this.tabControlAdmin.Controls.Add(this.tabPageModerAdsList);
			this.tabControlAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tabControlAdmin.Location = new System.Drawing.Point(-1, 192);
			this.tabControlAdmin.Name = "tabControlAdmin";
			this.tabControlAdmin.SelectedIndex = 0;
			this.tabControlAdmin.Size = new System.Drawing.Size(2495, 1193);
			this.tabControlAdmin.TabIndex = 3;
			// 
			// tabPageAdsList
			// 
			this.tabPageAdsList.Controls.Add(this.buttonFilterBySellerNumber);
			this.tabPageAdsList.Controls.Add(this.textBoxFilterBySellerNumber);
			this.tabPageAdsList.Controls.Add(this.buttonAddAd);
			this.tabPageAdsList.Controls.Add(this.labelFilteringAds);
			this.tabPageAdsList.Controls.Add(this.buttonDelAd);
			this.tabPageAdsList.Controls.Add(this.dataGridViewAdsList);
			this.tabPageAdsList.Controls.Add(this.textBoxSellerNameAdd);
			this.tabPageAdsList.Controls.Add(this.textBoxAdNameAdd);
			this.tabPageAdsList.Controls.Add(this.textBoxSellerNumberAdd);
			this.tabPageAdsList.Controls.Add(this.textBoxAdDescriptionAdd);
			this.tabPageAdsList.Controls.Add(this.textBoxAdPriceAdd);
			this.tabPageAdsList.Location = new System.Drawing.Point(12, 69);
			this.tabPageAdsList.Name = "tabPageAdsList";
			this.tabPageAdsList.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAdsList.Size = new System.Drawing.Size(2471, 1112);
			this.tabPageAdsList.TabIndex = 0;
			this.tabPageAdsList.Text = "Объявления";
			this.tabPageAdsList.UseVisualStyleBackColor = true;
			// 
			// buttonFilterBySellerNumber
			// 
			this.buttonFilterBySellerNumber.Location = new System.Drawing.Point(1964, 355);
			this.buttonFilterBySellerNumber.Name = "buttonFilterBySellerNumber";
			this.buttonFilterBySellerNumber.Size = new System.Drawing.Size(473, 69);
			this.buttonFilterBySellerNumber.TabIndex = 8;
			this.buttonFilterBySellerNumber.Text = "Отфильтровать";
			this.buttonFilterBySellerNumber.UseVisualStyleBackColor = true;
			this.buttonFilterBySellerNumber.Click += new System.EventHandler(this.buttonFilteringAdsByNumber_Click);
			// 
			// textBoxFilterBySellerNumber
			// 
			this.textBoxFilterBySellerNumber.Location = new System.Drawing.Point(1964, 269);
			this.textBoxFilterBySellerNumber.Name = "textBoxFilterBySellerNumber";
			this.textBoxFilterBySellerNumber.Size = new System.Drawing.Size(473, 55);
			this.textBoxFilterBySellerNumber.TabIndex = 7;
			this.textBoxFilterBySellerNumber.Text = "Введите номер телефона";
			// 
			// labelFilteringAds
			// 
			this.labelFilteringAds.AutoSize = true;
			this.labelFilteringAds.Location = new System.Drawing.Point(1964, 135);
			this.labelFilteringAds.Name = "labelFilteringAds";
			this.labelFilteringAds.Size = new System.Drawing.Size(439, 96);
			this.labelFilteringAds.TabIndex = 6;
			this.labelFilteringAds.Text = "Фильтровать объявления\r\nпо номеру телефона:";
			this.labelFilteringAds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelFilteringAds.Click += new System.EventHandler(this.labelFilteringAds_Click);
			// 
			// buttonDelAd
			// 
			this.buttonDelAd.Location = new System.Drawing.Point(1964, 15);
			this.buttonDelAd.Name = "buttonDelAd";
			this.buttonDelAd.Size = new System.Drawing.Size(473, 69);
			this.buttonDelAd.TabIndex = 5;
			this.buttonDelAd.Text = "Удалить объявление";
			this.buttonDelAd.UseVisualStyleBackColor = true;
			this.buttonDelAd.Click += new System.EventHandler(this.buttonDelAd_Click);
			// 
			// tabPageModerAdsList
			// 
			this.tabPageModerAdsList.Controls.Add(this.buttonCancelAd);
			this.tabPageModerAdsList.Controls.Add(this.buttonAllowAd);
			this.tabPageModerAdsList.Controls.Add(this.dataGridViewModerAdsList);
			this.tabPageModerAdsList.Location = new System.Drawing.Point(12, 69);
			this.tabPageModerAdsList.Name = "tabPageModerAdsList";
			this.tabPageModerAdsList.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageModerAdsList.Size = new System.Drawing.Size(2471, 1027);
			this.tabPageModerAdsList.TabIndex = 1;
			this.tabPageModerAdsList.Text = "На модерации";
			this.tabPageModerAdsList.UseVisualStyleBackColor = true;
			// 
			// buttonCancelAd
			// 
			this.buttonCancelAd.Location = new System.Drawing.Point(1942, 104);
			this.buttonCancelAd.Name = "buttonCancelAd";
			this.buttonCancelAd.Size = new System.Drawing.Size(475, 69);
			this.buttonCancelAd.TabIndex = 7;
			this.buttonCancelAd.Text = "Удалить объявление";
			this.buttonCancelAd.UseVisualStyleBackColor = true;
			// 
			// buttonAllowAd
			// 
			this.buttonAllowAd.Location = new System.Drawing.Point(1942, 15);
			this.buttonAllowAd.Name = "buttonAllowAd";
			this.buttonAllowAd.Size = new System.Drawing.Size(475, 69);
			this.buttonAllowAd.TabIndex = 6;
			this.buttonAllowAd.Text = "Разрешить объявление";
			this.buttonAllowAd.UseVisualStyleBackColor = true;
			// 
			// dataGridViewModerAdsList
			// 
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewModerAdsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.dataGridViewModerAdsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewModerAdsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewModerAdsList.DefaultCellStyle = dataGridViewCellStyle17;
			this.dataGridViewModerAdsList.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewModerAdsList.Name = "dataGridViewModerAdsList";
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewModerAdsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
			this.dataGridViewModerAdsList.RowHeadersWidth = 123;
			this.dataGridViewModerAdsList.RowTemplate.Height = 57;
			this.dataGridViewModerAdsList.Size = new System.Drawing.Size(1926, 1134);
			this.dataGridViewModerAdsList.TabIndex = 3;
			this.dataGridViewModerAdsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModerAdsList_CellContentClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Название";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 15;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 300;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Описание";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 15;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 300;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 15;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 300;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Телефон";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 15;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 300;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Продавец";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 15;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 300;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Размещено";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 15;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 300;
			// 
			// textBoxSellerNameAdd
			// 
			this.textBoxSellerNameAdd.Location = new System.Drawing.Point(1376, 1005);
			this.textBoxSellerNameAdd.Name = "textBoxSellerNameAdd";
			this.textBoxSellerNameAdd.Size = new System.Drawing.Size(294, 55);
			this.textBoxSellerNameAdd.TabIndex = 18;
			this.textBoxSellerNameAdd.Text = "ваше имя";
			this.textBoxSellerNameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxSellerNumberAdd
			// 
			this.textBoxSellerNumberAdd.Location = new System.Drawing.Point(1076, 1005);
			this.textBoxSellerNumberAdd.Name = "textBoxSellerNumberAdd";
			this.textBoxSellerNumberAdd.Size = new System.Drawing.Size(294, 55);
			this.textBoxSellerNumberAdd.TabIndex = 17;
			this.textBoxSellerNumberAdd.Text = "телефон";
			this.textBoxSellerNumberAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxAdPriceAdd
			// 
			this.textBoxAdPriceAdd.Location = new System.Drawing.Point(782, 1005);
			this.textBoxAdPriceAdd.Name = "textBoxAdPriceAdd";
			this.textBoxAdPriceAdd.Size = new System.Drawing.Size(288, 55);
			this.textBoxAdPriceAdd.TabIndex = 16;
			this.textBoxAdPriceAdd.Text = "цена";
			this.textBoxAdPriceAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxAdPriceAdd.TextChanged += new System.EventHandler(this.textBoxAdPriceAdd_TextChanged);
			// 
			// textBoxAdDescriptionAdd
			// 
			this.textBoxAdDescriptionAdd.Location = new System.Drawing.Point(476, 1005);
			this.textBoxAdDescriptionAdd.Name = "textBoxAdDescriptionAdd";
			this.textBoxAdDescriptionAdd.Size = new System.Drawing.Size(300, 55);
			this.textBoxAdDescriptionAdd.TabIndex = 15;
			this.textBoxAdDescriptionAdd.Text = "описание";
			this.textBoxAdDescriptionAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxAdDescriptionAdd.TextChanged += new System.EventHandler(this.textBoxAdDescriptionAdd_TextChanged);
			// 
			// textBoxAdNameAdd
			// 
			this.textBoxAdNameAdd.Location = new System.Drawing.Point(186, 1005);
			this.textBoxAdNameAdd.Name = "textBoxAdNameAdd";
			this.textBoxAdNameAdd.Size = new System.Drawing.Size(284, 55);
			this.textBoxAdNameAdd.TabIndex = 14;
			this.textBoxAdNameAdd.Text = "название";
			this.textBoxAdNameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxAdNameAdd.TextChanged += new System.EventHandler(this.textBoxAdNameAdd_TextChanged);
			// 
			// buttonAddAd
			// 
			this.buttonAddAd.Location = new System.Drawing.Point(1964, 998);
			this.buttonAddAd.Name = "buttonAddAd";
			this.buttonAddAd.Size = new System.Drawing.Size(473, 69);
			this.buttonAddAd.TabIndex = 4;
			this.buttonAddAd.Text = "Добавить объявление";
			this.buttonAddAd.UseVisualStyleBackColor = true;
			this.buttonAddAd.Click += new System.EventHandler(this.buttonAddAd_Click);
			// 
			// buttonPrintAdsList
			// 
			this.buttonPrintAdsList.Location = new System.Drawing.Point(1975, 33);
			this.buttonPrintAdsList.Name = "buttonPrintAdsList";
			this.buttonPrintAdsList.Size = new System.Drawing.Size(473, 137);
			this.buttonPrintAdsList.TabIndex = 3;
			this.buttonPrintAdsList.Text = "Обновить список\r\nобъявлений\r\n";
			this.buttonPrintAdsList.UseVisualStyleBackColor = true;
			this.buttonPrintAdsList.Click += new System.EventHandler(this.buttonPrintAdsList_Click);
			this.buttonPrintAdsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonPrintAdsList_MouseClick);
			// 
			// FormISA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2495, 1385);
			this.Controls.Add(this.tabControlAdmin);
			this.Controls.Add(this.buttonUser);
			this.Controls.Add(this.buttonAdmin);
			this.Controls.Add(this.buttonPrintAdsList);
			this.Name = "FormISA";
			this.Text = "InternetSaleAds";
			this.Load += new System.EventHandler(this.ISA_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdsList)).EndInit();
			this.tabControlAdmin.ResumeLayout(false);
			this.tabPageAdsList.ResumeLayout(false);
			this.tabPageAdsList.PerformLayout();
			this.tabPageModerAdsList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewModerAdsList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAdmin;
		private System.Windows.Forms.Button buttonUser;
		private System.Windows.Forms.TabControl tabControlAdmin;
		private System.Windows.Forms.DataGridView dataGridViewAdsList;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSellerNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSellerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdDate;
		private System.Windows.Forms.TabPage tabPageAdsList;
		private System.Windows.Forms.TabPage tabPageModerAdsList;
		private System.Windows.Forms.Button buttonPrintAdsList;
		private System.Windows.Forms.Button buttonDelAd;
		private System.Windows.Forms.Button buttonAddAd;
		private System.Windows.Forms.Button buttonAllowAd;
		private System.Windows.Forms.DataGridView dataGridViewModerAdsList;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.Button buttonCancelAd;
		private System.Windows.Forms.Label labelFilteringAds;
		private System.Windows.Forms.Button buttonFilterBySellerNumber;
		private System.Windows.Forms.TextBox textBoxFilterBySellerNumber;
		private System.Windows.Forms.TextBox textBoxSellerNameAdd;
		private System.Windows.Forms.TextBox textBoxSellerNumberAdd;
		private System.Windows.Forms.TextBox textBoxAdPriceAdd;
		private System.Windows.Forms.TextBox textBoxAdDescriptionAdd;
		private System.Windows.Forms.TextBox textBoxAdNameAdd;
	}
}

