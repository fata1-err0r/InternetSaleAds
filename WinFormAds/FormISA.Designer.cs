
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormISA));
			this.buttonAdmin = new System.Windows.Forms.Button();
			this.buttonUser = new System.Windows.Forms.Button();
			this.dataGridViewAdsList = new System.Windows.Forms.DataGridView();
			this.ColumnAdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAdDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSellerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControlAds = new System.Windows.Forms.TabControl();
			this.tabPageAdsList = new System.Windows.Forms.TabPage();
			this.buttonUpdateAdsList = new System.Windows.Forms.Button();
			this.buttonSearchByAdName = new System.Windows.Forms.Button();
			this.textBoxSearchByAdName = new System.Windows.Forms.TextBox();
			this.labelSearchByAdName = new System.Windows.Forms.Label();
			this.buttonFilterBySellerNumber = new System.Windows.Forms.Button();
			this.textBoxFilterBySellerNumber = new System.Windows.Forms.TextBox();
			this.labelFilterBySellerNumber = new System.Windows.Forms.Label();
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
			this.pictureBoxOligarkhMain = new System.Windows.Forms.PictureBox();
			this.buttonAddAd = new System.Windows.Forms.Button();
			this.textBoxSellerNameAdd = new System.Windows.Forms.TextBox();
			this.textBoxAdNameAdd = new System.Windows.Forms.TextBox();
			this.textBoxSellerNumberAdd = new System.Windows.Forms.TextBox();
			this.textBoxAdDescriptionAdd = new System.Windows.Forms.TextBox();
			this.textBoxAdPriceAdd = new System.Windows.Forms.TextBox();
			this.labelChooseProfile = new System.Windows.Forms.Label();
			this.buttonExitToMain = new System.Windows.Forms.Button();
			this.labelAdmin = new System.Windows.Forms.Label();
			this.labelUser = new System.Windows.Forms.Label();
			this.labelAdFields = new System.Windows.Forms.Label();
			this.labelStarsShitAdm = new System.Windows.Forms.Label();
			this.labelStarsShitUsr = new System.Windows.Forms.Label();
			this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdsList)).BeginInit();
			this.tabControlAds.SuspendLayout();
			this.tabPageAdsList.SuspendLayout();
			this.tabPageModerAdsList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewModerAdsList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOligarkhMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAdmin
			// 
			this.buttonAdmin.Location = new System.Drawing.Point(334, 383);
			this.buttonAdmin.Margin = new System.Windows.Forms.Padding(1);
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.Size = new System.Drawing.Size(93, 36);
			this.buttonAdmin.TabIndex = 0;
			this.buttonAdmin.Text = "Admin";
			this.buttonAdmin.UseVisualStyleBackColor = true;
			this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
			// 
			// buttonUser
			// 
			this.buttonUser.Location = new System.Drawing.Point(446, 383);
			this.buttonUser.Margin = new System.Windows.Forms.Padding(1);
			this.buttonUser.Name = "buttonUser";
			this.buttonUser.Size = new System.Drawing.Size(93, 36);
			this.buttonUser.TabIndex = 1;
			this.buttonUser.Text = "User";
			this.buttonUser.UseVisualStyleBackColor = true;
			this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
			// 
			// dataGridViewAdsList
			// 
			this.dataGridViewAdsList.AllowUserToAddRows = false;
			this.dataGridViewAdsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewAdsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewAdsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAdsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAdName,
            this.ColumnAdDescription,
            this.ColumnAdPrice,
            this.ColumnSellerNumber,
            this.ColumnSellerName,
            this.ColumnAdDate});
			this.dataGridViewAdsList.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewAdsList.Margin = new System.Windows.Forms.Padding(1);
			this.dataGridViewAdsList.Name = "dataGridViewAdsList";
			this.dataGridViewAdsList.RowHeadersVisible = false;
			this.dataGridViewAdsList.RowHeadersWidth = 123;
			this.dataGridViewAdsList.RowTemplate.Height = 57;
			this.dataGridViewAdsList.Size = new System.Drawing.Size(674, 397);
			this.dataGridViewAdsList.TabIndex = 2;
			this.dataGridViewAdsList.Visible = false;
			// 
			// ColumnAdName
			// 
			this.ColumnAdName.HeaderText = "Название";
			this.ColumnAdName.MinimumWidth = 15;
			this.ColumnAdName.Name = "ColumnAdName";
			this.ColumnAdName.ReadOnly = true;
			// 
			// ColumnAdDescription
			// 
			this.ColumnAdDescription.HeaderText = "Описание";
			this.ColumnAdDescription.MinimumWidth = 15;
			this.ColumnAdDescription.Name = "ColumnAdDescription";
			this.ColumnAdDescription.ReadOnly = true;
			// 
			// ColumnAdPrice
			// 
			this.ColumnAdPrice.HeaderText = "Цена";
			this.ColumnAdPrice.MinimumWidth = 15;
			this.ColumnAdPrice.Name = "ColumnAdPrice";
			this.ColumnAdPrice.ReadOnly = true;
			// 
			// ColumnSellerNumber
			// 
			this.ColumnSellerNumber.HeaderText = "Телефон";
			this.ColumnSellerNumber.MinimumWidth = 15;
			this.ColumnSellerNumber.Name = "ColumnSellerNumber";
			this.ColumnSellerNumber.ReadOnly = true;
			// 
			// ColumnSellerName
			// 
			this.ColumnSellerName.HeaderText = "Продавец";
			this.ColumnSellerName.MinimumWidth = 15;
			this.ColumnSellerName.Name = "ColumnSellerName";
			this.ColumnSellerName.ReadOnly = true;
			// 
			// ColumnAdDate
			// 
			this.ColumnAdDate.HeaderText = "Размещено";
			this.ColumnAdDate.MinimumWidth = 15;
			this.ColumnAdDate.Name = "ColumnAdDate";
			this.ColumnAdDate.ReadOnly = true;
			// 
			// tabControlAds
			// 
			this.tabControlAds.Controls.Add(this.tabPageAdsList);
			this.tabControlAds.Controls.Add(this.tabPageModerAdsList);
			this.tabControlAds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tabControlAds.Location = new System.Drawing.Point(0, 175);
			this.tabControlAds.Margin = new System.Windows.Forms.Padding(1);
			this.tabControlAds.Name = "tabControlAds";
			this.tabControlAds.SelectedIndex = 0;
			this.tabControlAds.Size = new System.Drawing.Size(873, 426);
			this.tabControlAds.TabIndex = 3;
			this.tabControlAds.Visible = false;
			// 
			// tabPageAdsList
			// 
			this.tabPageAdsList.Controls.Add(this.buttonUpdateAdsList);
			this.tabPageAdsList.Controls.Add(this.buttonSearchByAdName);
			this.tabPageAdsList.Controls.Add(this.textBoxSearchByAdName);
			this.tabPageAdsList.Controls.Add(this.labelSearchByAdName);
			this.tabPageAdsList.Controls.Add(this.buttonFilterBySellerNumber);
			this.tabPageAdsList.Controls.Add(this.textBoxFilterBySellerNumber);
			this.tabPageAdsList.Controls.Add(this.labelFilterBySellerNumber);
			this.tabPageAdsList.Controls.Add(this.buttonDelAd);
			this.tabPageAdsList.Controls.Add(this.dataGridViewAdsList);
			this.tabPageAdsList.Location = new System.Drawing.Point(4, 24);
			this.tabPageAdsList.Margin = new System.Windows.Forms.Padding(1);
			this.tabPageAdsList.Name = "tabPageAdsList";
			this.tabPageAdsList.Padding = new System.Windows.Forms.Padding(1);
			this.tabPageAdsList.Size = new System.Drawing.Size(865, 398);
			this.tabPageAdsList.TabIndex = 0;
			this.tabPageAdsList.Text = "Объявления";
			this.tabPageAdsList.UseVisualStyleBackColor = true;
			// 
			// buttonUpdateAdsList
			// 
			this.buttonUpdateAdsList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonUpdateAdsList.Location = new System.Drawing.Point(687, 306);
			this.buttonUpdateAdsList.Name = "buttonUpdateAdsList";
			this.buttonUpdateAdsList.Size = new System.Drawing.Size(166, 75);
			this.buttonUpdateAdsList.TabIndex = 12;
			this.buttonUpdateAdsList.Text = "Обновить список\r\nобъявлений";
			this.buttonUpdateAdsList.UseVisualStyleBackColor = true;
			this.buttonUpdateAdsList.Click += new System.EventHandler(this.buttonUpdateAdsList_Click);
			// 
			// buttonSearchByAdName
			// 
			this.buttonSearchByAdName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonSearchByAdName.Location = new System.Drawing.Point(687, 128);
			this.buttonSearchByAdName.Margin = new System.Windows.Forms.Padding(1);
			this.buttonSearchByAdName.Name = "buttonSearchByAdName";
			this.buttonSearchByAdName.Size = new System.Drawing.Size(166, 22);
			this.buttonSearchByAdName.TabIndex = 11;
			this.buttonSearchByAdName.Text = "НАЙТИ";
			this.buttonSearchByAdName.UseVisualStyleBackColor = true;
			this.buttonSearchByAdName.Visible = false;
			this.buttonSearchByAdName.Click += new System.EventHandler(this.buttonSearchByAdName_Click);
			// 
			// textBoxSearchByAdName
			// 
			this.textBoxSearchByAdName.Location = new System.Drawing.Point(687, 101);
			this.textBoxSearchByAdName.Margin = new System.Windows.Forms.Padding(1);
			this.textBoxSearchByAdName.Name = "textBoxSearchByAdName";
			this.textBoxSearchByAdName.Size = new System.Drawing.Size(166, 23);
			this.textBoxSearchByAdName.TabIndex = 10;
			this.textBoxSearchByAdName.Text = "Введите название";
			this.textBoxSearchByAdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxSearchByAdName.Visible = false;
			// 
			// labelSearchByAdName
			// 
			this.labelSearchByAdName.AutoSize = true;
			this.labelSearchByAdName.Location = new System.Drawing.Point(719, 62);
			this.labelSearchByAdName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.labelSearchByAdName.Name = "labelSearchByAdName";
			this.labelSearchByAdName.Size = new System.Drawing.Size(110, 30);
			this.labelSearchByAdName.TabIndex = 9;
			this.labelSearchByAdName.Text = "Найти объявление\r\nпо названию:";
			this.labelSearchByAdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelSearchByAdName.Visible = false;
			// 
			// buttonFilterBySellerNumber
			// 
			this.buttonFilterBySellerNumber.Location = new System.Drawing.Point(687, 263);
			this.buttonFilterBySellerNumber.Margin = new System.Windows.Forms.Padding(1);
			this.buttonFilterBySellerNumber.Name = "buttonFilterBySellerNumber";
			this.buttonFilterBySellerNumber.Size = new System.Drawing.Size(166, 22);
			this.buttonFilterBySellerNumber.TabIndex = 8;
			this.buttonFilterBySellerNumber.Text = "Отфильтровать";
			this.buttonFilterBySellerNumber.UseVisualStyleBackColor = true;
			this.buttonFilterBySellerNumber.Visible = false;
			this.buttonFilterBySellerNumber.Click += new System.EventHandler(this.buttonFilteringAdsByNumber_Click);
			// 
			// textBoxFilterBySellerNumber
			// 
			this.textBoxFilterBySellerNumber.Location = new System.Drawing.Point(687, 236);
			this.textBoxFilterBySellerNumber.Margin = new System.Windows.Forms.Padding(1);
			this.textBoxFilterBySellerNumber.Name = "textBoxFilterBySellerNumber";
			this.textBoxFilterBySellerNumber.Size = new System.Drawing.Size(166, 23);
			this.textBoxFilterBySellerNumber.TabIndex = 7;
			this.textBoxFilterBySellerNumber.Text = "Введите номер телефона";
			this.textBoxFilterBySellerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxFilterBySellerNumber.Visible = false;
			// 
			// labelFilterBySellerNumber
			// 
			this.labelFilterBySellerNumber.AutoSize = true;
			this.labelFilterBySellerNumber.Location = new System.Drawing.Point(697, 195);
			this.labelFilterBySellerNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.labelFilterBySellerNumber.Name = "labelFilterBySellerNumber";
			this.labelFilterBySellerNumber.Size = new System.Drawing.Size(147, 30);
			this.labelFilterBySellerNumber.TabIndex = 6;
			this.labelFilterBySellerNumber.Text = "Фильтровать объявления\r\nпо номеру телефона:";
			this.labelFilterBySellerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelFilterBySellerNumber.Visible = false;
			// 
			// buttonDelAd
			// 
			this.buttonDelAd.Location = new System.Drawing.Point(687, 1);
			this.buttonDelAd.Margin = new System.Windows.Forms.Padding(1);
			this.buttonDelAd.Name = "buttonDelAd";
			this.buttonDelAd.Size = new System.Drawing.Size(166, 43);
			this.buttonDelAd.TabIndex = 5;
			this.buttonDelAd.Text = "Удалить объявление";
			this.buttonDelAd.UseVisualStyleBackColor = true;
			this.buttonDelAd.Visible = false;
			this.buttonDelAd.Click += new System.EventHandler(this.buttonDelAd_Click);
			// 
			// tabPageModerAdsList
			// 
			this.tabPageModerAdsList.Controls.Add(this.buttonCancelAd);
			this.tabPageModerAdsList.Controls.Add(this.buttonAllowAd);
			this.tabPageModerAdsList.Controls.Add(this.dataGridViewModerAdsList);
			this.tabPageModerAdsList.Location = new System.Drawing.Point(4, 24);
			this.tabPageModerAdsList.Margin = new System.Windows.Forms.Padding(1);
			this.tabPageModerAdsList.Name = "tabPageModerAdsList";
			this.tabPageModerAdsList.Padding = new System.Windows.Forms.Padding(1);
			this.tabPageModerAdsList.Size = new System.Drawing.Size(865, 398);
			this.tabPageModerAdsList.TabIndex = 1;
			this.tabPageModerAdsList.Text = "На модерации";
			this.tabPageModerAdsList.UseVisualStyleBackColor = true;
			// 
			// buttonCancelAd
			// 
			this.buttonCancelAd.Location = new System.Drawing.Point(687, 1);
			this.buttonCancelAd.Margin = new System.Windows.Forms.Padding(1);
			this.buttonCancelAd.Name = "buttonCancelAd";
			this.buttonCancelAd.Size = new System.Drawing.Size(166, 43);
			this.buttonCancelAd.TabIndex = 7;
			this.buttonCancelAd.Text = "Удалить объявление";
			this.buttonCancelAd.UseVisualStyleBackColor = true;
			this.buttonCancelAd.Click += new System.EventHandler(this.buttonCancelAd_Click);
			// 
			// buttonAllowAd
			// 
			this.buttonAllowAd.Location = new System.Drawing.Point(687, 58);
			this.buttonAllowAd.Margin = new System.Windows.Forms.Padding(1);
			this.buttonAllowAd.Name = "buttonAllowAd";
			this.buttonAllowAd.Size = new System.Drawing.Size(166, 43);
			this.buttonAllowAd.TabIndex = 6;
			this.buttonAllowAd.Text = "Разрешить объявление";
			this.buttonAllowAd.UseVisualStyleBackColor = true;
			this.buttonAllowAd.Click += new System.EventHandler(this.buttonAllowAd_Click);
			// 
			// dataGridViewModerAdsList
			// 
			this.dataGridViewModerAdsList.AllowUserToAddRows = false;
			this.dataGridViewModerAdsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewModerAdsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewModerAdsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewModerAdsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewModerAdsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewModerAdsList.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewModerAdsList.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewModerAdsList.Margin = new System.Windows.Forms.Padding(1);
			this.dataGridViewModerAdsList.Name = "dataGridViewModerAdsList";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewModerAdsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewModerAdsList.RowHeadersVisible = false;
			this.dataGridViewModerAdsList.RowHeadersWidth = 123;
			this.dataGridViewModerAdsList.RowTemplate.Height = 57;
			this.dataGridViewModerAdsList.Size = new System.Drawing.Size(674, 397);
			this.dataGridViewModerAdsList.TabIndex = 3;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Название";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 15;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Описание";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 15;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 15;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Телефон";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 15;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Продавец";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 15;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Размещено";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 15;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// pictureBoxOligarkhMain
			// 
			this.pictureBoxOligarkhMain.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOligarkhMain.Image")));
			this.pictureBoxOligarkhMain.Location = new System.Drawing.Point(177, 99);
			this.pictureBoxOligarkhMain.Margin = new System.Windows.Forms.Padding(1);
			this.pictureBoxOligarkhMain.Name = "pictureBoxOligarkhMain";
			this.pictureBoxOligarkhMain.Size = new System.Drawing.Size(512, 262);
			this.pictureBoxOligarkhMain.TabIndex = 24;
			this.pictureBoxOligarkhMain.TabStop = false;
			// 
			// buttonAddAd
			// 
			this.buttonAddAd.Location = new System.Drawing.Point(691, 130);
			this.buttonAddAd.Margin = new System.Windows.Forms.Padding(1);
			this.buttonAddAd.Name = "buttonAddAd";
			this.buttonAddAd.Size = new System.Drawing.Size(166, 43);
			this.buttonAddAd.TabIndex = 4;
			this.buttonAddAd.Text = "Добавить объявление";
			this.buttonAddAd.UseVisualStyleBackColor = true;
			this.buttonAddAd.Visible = false;
			this.buttonAddAd.Click += new System.EventHandler(this.buttonAddAd_Click);
			// 
			// textBoxSellerNameAdd
			// 
			this.textBoxSellerNameAdd.Location = new System.Drawing.Point(533, 141);
			this.textBoxSellerNameAdd.Margin = new System.Windows.Forms.Padding(1);
			this.textBoxSellerNameAdd.Name = "textBoxSellerNameAdd";
			this.textBoxSellerNameAdd.Size = new System.Drawing.Size(106, 23);
			this.textBoxSellerNameAdd.TabIndex = 18;
			this.textBoxSellerNameAdd.Text = "ваше имя";
			this.textBoxSellerNameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxSellerNameAdd.Visible = false;
			// 
			// textBoxAdNameAdd
			// 
			this.textBoxAdNameAdd.Location = new System.Drawing.Point(22, 141);
			this.textBoxAdNameAdd.Margin = new System.Windows.Forms.Padding(1);
			this.textBoxAdNameAdd.Name = "textBoxAdNameAdd";
			this.textBoxAdNameAdd.Size = new System.Drawing.Size(102, 23);
			this.textBoxAdNameAdd.TabIndex = 14;
			this.textBoxAdNameAdd.Text = "название";
			this.textBoxAdNameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxAdNameAdd.Visible = false;
			// 
			// textBoxSellerNumberAdd
			// 
			this.textBoxSellerNumberAdd.Location = new System.Drawing.Point(405, 141);
			this.textBoxSellerNumberAdd.Margin = new System.Windows.Forms.Padding(1);
			this.textBoxSellerNumberAdd.Name = "textBoxSellerNumberAdd";
			this.textBoxSellerNumberAdd.Size = new System.Drawing.Size(106, 23);
			this.textBoxSellerNumberAdd.TabIndex = 17;
			this.textBoxSellerNumberAdd.Text = "телефон";
			this.textBoxSellerNumberAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxSellerNumberAdd.Visible = false;
			// 
			// textBoxAdDescriptionAdd
			// 
			this.textBoxAdDescriptionAdd.Location = new System.Drawing.Point(148, 141);
			this.textBoxAdDescriptionAdd.Margin = new System.Windows.Forms.Padding(1);
			this.textBoxAdDescriptionAdd.Name = "textBoxAdDescriptionAdd";
			this.textBoxAdDescriptionAdd.Size = new System.Drawing.Size(108, 23);
			this.textBoxAdDescriptionAdd.TabIndex = 15;
			this.textBoxAdDescriptionAdd.Text = "описание";
			this.textBoxAdDescriptionAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxAdDescriptionAdd.Visible = false;
			// 
			// textBoxAdPriceAdd
			// 
			this.textBoxAdPriceAdd.Location = new System.Drawing.Point(281, 141);
			this.textBoxAdPriceAdd.Margin = new System.Windows.Forms.Padding(1);
			this.textBoxAdPriceAdd.Name = "textBoxAdPriceAdd";
			this.textBoxAdPriceAdd.Size = new System.Drawing.Size(103, 23);
			this.textBoxAdPriceAdd.TabIndex = 16;
			this.textBoxAdPriceAdd.Text = "цена";
			this.textBoxAdPriceAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxAdPriceAdd.Visible = false;
			// 
			// labelChooseProfile
			// 
			this.labelChooseProfile.AutoSize = true;
			this.labelChooseProfile.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelChooseProfile.ForeColor = System.Drawing.Color.ForestGreen;
			this.labelChooseProfile.Location = new System.Drawing.Point(303, 437);
			this.labelChooseProfile.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.labelChooseProfile.Name = "labelChooseProfile";
			this.labelChooseProfile.Size = new System.Drawing.Size(275, 37);
			this.labelChooseProfile.TabIndex = 19;
			this.labelChooseProfile.Text = "Выберите профиль";
			this.labelChooseProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonExitToMain
			// 
			this.buttonExitToMain.Location = new System.Drawing.Point(691, 10);
			this.buttonExitToMain.Margin = new System.Windows.Forms.Padding(1);
			this.buttonExitToMain.Name = "buttonExitToMain";
			this.buttonExitToMain.Size = new System.Drawing.Size(166, 43);
			this.buttonExitToMain.TabIndex = 3;
			this.buttonExitToMain.Text = "ВЫХОД";
			this.buttonExitToMain.UseVisualStyleBackColor = true;
			this.buttonExitToMain.Visible = false;
			this.buttonExitToMain.Click += new System.EventHandler(this.buttonExitToMain_Click);
			// 
			// labelAdmin
			// 
			this.labelAdmin.AutoSize = true;
			this.labelAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.labelAdmin.ForeColor = System.Drawing.Color.Crimson;
			this.labelAdmin.Location = new System.Drawing.Point(10, 9);
			this.labelAdmin.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.labelAdmin.Name = "labelAdmin";
			this.labelAdmin.Size = new System.Drawing.Size(185, 30);
			this.labelAdmin.TabIndex = 4;
			this.labelAdmin.Text = "Администратор";
			this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelAdmin.Visible = false;
			// 
			// labelUser
			// 
			this.labelUser.AutoSize = true;
			this.labelUser.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.labelUser.ForeColor = System.Drawing.Color.MediumBlue;
			this.labelUser.Location = new System.Drawing.Point(10, 9);
			this.labelUser.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(161, 30);
			this.labelUser.TabIndex = 5;
			this.labelUser.Text = "Пользователь";
			this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelUser.Visible = false;
			// 
			// labelAdFields
			// 
			this.labelAdFields.AutoSize = true;
			this.labelAdFields.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.labelAdFields.ForeColor = System.Drawing.Color.DarkGreen;
			this.labelAdFields.Location = new System.Drawing.Point(119, 107);
			this.labelAdFields.Name = "labelAdFields";
			this.labelAdFields.Size = new System.Drawing.Size(422, 21);
			this.labelAdFields.TabIndex = 20;
			this.labelAdFields.Text = "Заполните поля, что бы добавить новое объявление:";
			this.labelAdFields.Visible = false;
			// 
			// labelStarsShitAdm
			// 
			this.labelStarsShitAdm.AutoSize = true;
			this.labelStarsShitAdm.ForeColor = System.Drawing.Color.Crimson;
			this.labelStarsShitAdm.Location = new System.Drawing.Point(10, 83);
			this.labelStarsShitAdm.Name = "labelStarsShitAdm";
			this.labelStarsShitAdm.Size = new System.Drawing.Size(853, 15);
			this.labelStarsShitAdm.TabIndex = 22;
			this.labelStarsShitAdm.Text = "…:::★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★" +
    "☆★☆★:::…";
			this.labelStarsShitAdm.Visible = false;
			// 
			// labelStarsShitUsr
			// 
			this.labelStarsShitUsr.AutoSize = true;
			this.labelStarsShitUsr.ForeColor = System.Drawing.Color.MediumBlue;
			this.labelStarsShitUsr.Location = new System.Drawing.Point(10, 83);
			this.labelStarsShitUsr.Name = "labelStarsShitUsr";
			this.labelStarsShitUsr.Size = new System.Drawing.Size(853, 15);
			this.labelStarsShitUsr.TabIndex = 23;
			this.labelStarsShitUsr.Text = "…:::★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★" +
    "☆★☆★:::…";
			this.labelStarsShitUsr.Visible = false;
			// 
			// pictureBoxIcon
			// 
			this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
			this.pictureBoxIcon.Location = new System.Drawing.Point(363, 9);
			this.pictureBoxIcon.Name = "pictureBoxIcon";
			this.pictureBoxIcon.Size = new System.Drawing.Size(130, 67);
			this.pictureBoxIcon.TabIndex = 25;
			this.pictureBoxIcon.TabStop = false;
			this.pictureBoxIcon.Visible = false;
			// 
			// FormISA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(872, 601);
			this.Controls.Add(this.labelStarsShitUsr);
			this.Controls.Add(this.labelStarsShitAdm);
			this.Controls.Add(this.labelAdFields);
			this.Controls.Add(this.tabControlAds);
			this.Controls.Add(this.buttonAddAd);
			this.Controls.Add(this.buttonExitToMain);
			this.Controls.Add(this.textBoxSellerNameAdd);
			this.Controls.Add(this.labelUser);
			this.Controls.Add(this.textBoxAdNameAdd);
			this.Controls.Add(this.labelAdmin);
			this.Controls.Add(this.textBoxSellerNumberAdd);
			this.Controls.Add(this.textBoxAdPriceAdd);
			this.Controls.Add(this.textBoxAdDescriptionAdd);
			this.Controls.Add(this.pictureBoxOligarkhMain);
			this.Controls.Add(this.labelChooseProfile);
			this.Controls.Add(this.buttonAdmin);
			this.Controls.Add(this.buttonUser);
			this.Controls.Add(this.pictureBoxIcon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(1);
			this.Name = "FormISA";
			this.Text = "InternetSaleAds";
			this.Load += new System.EventHandler(this.ISA_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdsList)).EndInit();
			this.tabControlAds.ResumeLayout(false);
			this.tabPageAdsList.ResumeLayout(false);
			this.tabPageAdsList.PerformLayout();
			this.tabPageModerAdsList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewModerAdsList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOligarkhMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAdmin;
		private System.Windows.Forms.Button buttonUser;
		private System.Windows.Forms.TabControl tabControlAds;
		private System.Windows.Forms.DataGridView dataGridViewAdsList;
		private System.Windows.Forms.TabPage tabPageAdsList;
		private System.Windows.Forms.TabPage tabPageModerAdsList;
		private System.Windows.Forms.Button buttonExitToMain;
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
		private System.Windows.Forms.Label labelFilterBySellerNumber;
		private System.Windows.Forms.Button buttonFilterBySellerNumber;
		private System.Windows.Forms.TextBox textBoxFilterBySellerNumber;
		private System.Windows.Forms.TextBox textBoxSellerNameAdd;
		private System.Windows.Forms.TextBox textBoxSellerNumberAdd;
		private System.Windows.Forms.TextBox textBoxAdPriceAdd;
		private System.Windows.Forms.TextBox textBoxAdDescriptionAdd;
		private System.Windows.Forms.TextBox textBoxAdNameAdd;
		private System.Windows.Forms.Label labelAdmin;
		private System.Windows.Forms.Label labelUser;
		private System.Windows.Forms.Label labelChooseProfile;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSellerNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSellerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdDate;
		private System.Windows.Forms.Label labelAdFields;
		private System.Windows.Forms.Label labelStarsShitAdm;
		private System.Windows.Forms.Label labelStarsShitUsr;
		private System.Windows.Forms.PictureBox pictureBoxOligarkhMain;
		private System.Windows.Forms.PictureBox pictureBoxIcon;
		private System.Windows.Forms.Button buttonSearchByAdName;
		private System.Windows.Forms.TextBox textBoxSearchByAdName;
		private System.Windows.Forms.Label labelSearchByAdName;
		private System.Windows.Forms.Button buttonUpdateAdsList;
	}
}

