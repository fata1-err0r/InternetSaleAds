
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.buttonAdmin.Location = new System.Drawing.Point(954, 1226);
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.Size = new System.Drawing.Size(266, 115);
			this.buttonAdmin.TabIndex = 0;
			this.buttonAdmin.Text = "Admin";
			this.buttonAdmin.UseVisualStyleBackColor = true;
			this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
			// 
			// buttonUser
			// 
			this.buttonUser.Location = new System.Drawing.Point(1274, 1226);
			this.buttonUser.Name = "buttonUser";
			this.buttonUser.Size = new System.Drawing.Size(266, 115);
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
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewAdsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridViewAdsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAdsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAdName,
            this.ColumnAdDescription,
            this.ColumnAdPrice,
            this.ColumnSellerNumber,
            this.ColumnSellerName,
            this.ColumnAdDate});
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewAdsList.DefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridViewAdsList.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewAdsList.Name = "dataGridViewAdsList";
			this.dataGridViewAdsList.RowHeadersVisible = false;
			this.dataGridViewAdsList.RowHeadersWidth = 123;
			this.dataGridViewAdsList.RowTemplate.Height = 57;
			this.dataGridViewAdsList.Size = new System.Drawing.Size(1926, 1270);
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
			this.tabControlAds.Location = new System.Drawing.Point(0, 560);
			this.tabControlAds.Name = "tabControlAds";
			this.tabControlAds.SelectedIndex = 0;
			this.tabControlAds.Size = new System.Drawing.Size(2494, 1363);
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
			this.tabPageAdsList.Location = new System.Drawing.Point(12, 69);
			this.tabPageAdsList.Name = "tabPageAdsList";
			this.tabPageAdsList.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAdsList.Size = new System.Drawing.Size(2470, 1282);
			this.tabPageAdsList.TabIndex = 0;
			this.tabPageAdsList.Text = "Объявления";
			this.tabPageAdsList.UseVisualStyleBackColor = true;
			// 
			// buttonUpdateAdsList
			// 
			this.buttonUpdateAdsList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonUpdateAdsList.Location = new System.Drawing.Point(1963, 979);
			this.buttonUpdateAdsList.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
			this.buttonUpdateAdsList.Name = "buttonUpdateAdsList";
			this.buttonUpdateAdsList.Size = new System.Drawing.Size(474, 240);
			this.buttonUpdateAdsList.TabIndex = 12;
			this.buttonUpdateAdsList.Text = "Обновить список\r\nобъявлений";
			this.buttonUpdateAdsList.UseVisualStyleBackColor = true;
			this.buttonUpdateAdsList.Click += new System.EventHandler(this.buttonUpdateAdsList_Click);
			// 
			// buttonSearchByAdName
			// 
			this.buttonSearchByAdName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonSearchByAdName.Location = new System.Drawing.Point(1963, 438);
			this.buttonSearchByAdName.Name = "buttonSearchByAdName";
			this.buttonSearchByAdName.Size = new System.Drawing.Size(474, 70);
			this.buttonSearchByAdName.TabIndex = 11;
			this.buttonSearchByAdName.Text = "НАЙТИ";
			this.buttonSearchByAdName.UseVisualStyleBackColor = true;
			this.buttonSearchByAdName.Visible = false;
			this.buttonSearchByAdName.Click += new System.EventHandler(this.buttonSearchByAdName_Click);
			// 
			// textBoxSearchByAdName
			// 
			this.textBoxSearchByAdName.Location = new System.Drawing.Point(1963, 352);
			this.textBoxSearchByAdName.Name = "textBoxSearchByAdName";
			this.textBoxSearchByAdName.PlaceholderText = "Введите название";
			this.textBoxSearchByAdName.Size = new System.Drawing.Size(467, 55);
			this.textBoxSearchByAdName.TabIndex = 10;
			this.textBoxSearchByAdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxSearchByAdName.Visible = false;
			// 
			// labelSearchByAdName
			// 
			this.labelSearchByAdName.AutoSize = true;
			this.labelSearchByAdName.Location = new System.Drawing.Point(2054, 227);
			this.labelSearchByAdName.Name = "labelSearchByAdName";
			this.labelSearchByAdName.Size = new System.Drawing.Size(330, 96);
			this.labelSearchByAdName.TabIndex = 9;
			this.labelSearchByAdName.Text = "Найти объявление\r\nпо названию:";
			this.labelSearchByAdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelSearchByAdName.Visible = false;
			// 
			// buttonFilterBySellerNumber
			// 
			this.buttonFilterBySellerNumber.Location = new System.Drawing.Point(1963, 797);
			this.buttonFilterBySellerNumber.Name = "buttonFilterBySellerNumber";
			this.buttonFilterBySellerNumber.Size = new System.Drawing.Size(474, 70);
			this.buttonFilterBySellerNumber.TabIndex = 8;
			this.buttonFilterBySellerNumber.Text = "Отфильтровать";
			this.buttonFilterBySellerNumber.UseVisualStyleBackColor = true;
			this.buttonFilterBySellerNumber.Visible = false;
			this.buttonFilterBySellerNumber.Click += new System.EventHandler(this.buttonFilteringAdsByNumber_Click);
			// 
			// textBoxFilterBySellerNumber
			// 
			this.textBoxFilterBySellerNumber.Location = new System.Drawing.Point(1963, 710);
			this.textBoxFilterBySellerNumber.Name = "textBoxFilterBySellerNumber";
			this.textBoxFilterBySellerNumber.PlaceholderText = "Введите номер телефона";
			this.textBoxFilterBySellerNumber.Size = new System.Drawing.Size(467, 55);
			this.textBoxFilterBySellerNumber.TabIndex = 7;
			this.textBoxFilterBySellerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxFilterBySellerNumber.Visible = false;
			// 
			// labelFilterBySellerNumber
			// 
			this.labelFilterBySellerNumber.AutoSize = true;
			this.labelFilterBySellerNumber.Location = new System.Drawing.Point(1991, 579);
			this.labelFilterBySellerNumber.Name = "labelFilterBySellerNumber";
			this.labelFilterBySellerNumber.Size = new System.Drawing.Size(439, 96);
			this.labelFilterBySellerNumber.TabIndex = 6;
			this.labelFilterBySellerNumber.Text = "Фильтровать объявления\r\nпо номеру телефона:";
			this.labelFilterBySellerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelFilterBySellerNumber.Visible = false;
			// 
			// buttonDelAd
			// 
			this.buttonDelAd.Location = new System.Drawing.Point(1963, 3);
			this.buttonDelAd.Name = "buttonDelAd";
			this.buttonDelAd.Size = new System.Drawing.Size(474, 138);
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
			this.tabPageModerAdsList.Location = new System.Drawing.Point(12, 69);
			this.tabPageModerAdsList.Name = "tabPageModerAdsList";
			this.tabPageModerAdsList.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageModerAdsList.Size = new System.Drawing.Size(2470, 1282);
			this.tabPageModerAdsList.TabIndex = 1;
			this.tabPageModerAdsList.Text = "На модерации";
			this.tabPageModerAdsList.UseVisualStyleBackColor = true;
			// 
			// buttonCancelAd
			// 
			this.buttonCancelAd.Location = new System.Drawing.Point(1963, 3);
			this.buttonCancelAd.Name = "buttonCancelAd";
			this.buttonCancelAd.Size = new System.Drawing.Size(474, 138);
			this.buttonCancelAd.TabIndex = 7;
			this.buttonCancelAd.Text = "Удалить объявление";
			this.buttonCancelAd.UseVisualStyleBackColor = true;
			this.buttonCancelAd.Click += new System.EventHandler(this.buttonCancelAd_Click);
			// 
			// buttonAllowAd
			// 
			this.buttonAllowAd.Location = new System.Drawing.Point(1963, 186);
			this.buttonAllowAd.Name = "buttonAllowAd";
			this.buttonAllowAd.Size = new System.Drawing.Size(474, 138);
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
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewModerAdsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
			this.dataGridViewModerAdsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewModerAdsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewModerAdsList.DefaultCellStyle = dataGridViewCellStyle14;
			this.dataGridViewModerAdsList.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewModerAdsList.Name = "dataGridViewModerAdsList";
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewModerAdsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
			this.dataGridViewModerAdsList.RowHeadersVisible = false;
			this.dataGridViewModerAdsList.RowHeadersWidth = 123;
			this.dataGridViewModerAdsList.RowTemplate.Height = 57;
			this.dataGridViewModerAdsList.Size = new System.Drawing.Size(1926, 1270);
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
			this.pictureBoxOligarkhMain.Location = new System.Drawing.Point(506, 317);
			this.pictureBoxOligarkhMain.Name = "pictureBoxOligarkhMain";
			this.pictureBoxOligarkhMain.Size = new System.Drawing.Size(1463, 838);
			this.pictureBoxOligarkhMain.TabIndex = 24;
			this.pictureBoxOligarkhMain.TabStop = false;
			// 
			// buttonAddAd
			// 
			this.buttonAddAd.Location = new System.Drawing.Point(1974, 416);
			this.buttonAddAd.Name = "buttonAddAd";
			this.buttonAddAd.Size = new System.Drawing.Size(474, 138);
			this.buttonAddAd.TabIndex = 4;
			this.buttonAddAd.Text = "Добавить объявление";
			this.buttonAddAd.UseVisualStyleBackColor = true;
			this.buttonAddAd.Visible = false;
			this.buttonAddAd.Click += new System.EventHandler(this.buttonAddAd_Click);
			// 
			// textBoxSellerNameAdd
			// 
			this.textBoxSellerNameAdd.Location = new System.Drawing.Point(1523, 451);
			this.textBoxSellerNameAdd.Name = "textBoxSellerNameAdd";
			this.textBoxSellerNameAdd.PlaceholderText = "ваше имя";
			this.textBoxSellerNameAdd.Size = new System.Drawing.Size(295, 55);
			this.textBoxSellerNameAdd.TabIndex = 18;
			this.textBoxSellerNameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxSellerNameAdd.Visible = false;
			// 
			// textBoxAdNameAdd
			// 
			this.textBoxAdNameAdd.Location = new System.Drawing.Point(63, 451);
			this.textBoxAdNameAdd.Name = "textBoxAdNameAdd";
			this.textBoxAdNameAdd.PlaceholderText = "название";
			this.textBoxAdNameAdd.Size = new System.Drawing.Size(284, 55);
			this.textBoxAdNameAdd.TabIndex = 14;
			this.textBoxAdNameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxAdNameAdd.Visible = false;
			// 
			// textBoxSellerNumberAdd
			// 
			this.textBoxSellerNumberAdd.Location = new System.Drawing.Point(1157, 451);
			this.textBoxSellerNumberAdd.Name = "textBoxSellerNumberAdd";
			this.textBoxSellerNumberAdd.PlaceholderText = "телефон";
			this.textBoxSellerNumberAdd.Size = new System.Drawing.Size(295, 55);
			this.textBoxSellerNumberAdd.TabIndex = 17;
			this.textBoxSellerNumberAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxSellerNumberAdd.Visible = false;
			// 
			// textBoxAdDescriptionAdd
			// 
			this.textBoxAdDescriptionAdd.Location = new System.Drawing.Point(423, 451);
			this.textBoxAdDescriptionAdd.Name = "textBoxAdDescriptionAdd";
			this.textBoxAdDescriptionAdd.PlaceholderText = "описание";
			this.textBoxAdDescriptionAdd.Size = new System.Drawing.Size(301, 55);
			this.textBoxAdDescriptionAdd.TabIndex = 15;
			this.textBoxAdDescriptionAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxAdDescriptionAdd.Visible = false;
			// 
			// textBoxAdPriceAdd
			// 
			this.textBoxAdPriceAdd.Location = new System.Drawing.Point(803, 451);
			this.textBoxAdPriceAdd.Name = "textBoxAdPriceAdd";
			this.textBoxAdPriceAdd.PlaceholderText = "цена";
			this.textBoxAdPriceAdd.Size = new System.Drawing.Size(287, 55);
			this.textBoxAdPriceAdd.TabIndex = 16;
			this.textBoxAdPriceAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxAdPriceAdd.Visible = false;
			// 
			// labelChooseProfile
			// 
			this.labelChooseProfile.AutoSize = true;
			this.labelChooseProfile.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelChooseProfile.ForeColor = System.Drawing.Color.ForestGreen;
			this.labelChooseProfile.Location = new System.Drawing.Point(866, 1398);
			this.labelChooseProfile.Name = "labelChooseProfile";
			this.labelChooseProfile.Size = new System.Drawing.Size(807, 106);
			this.labelChooseProfile.TabIndex = 19;
			this.labelChooseProfile.Text = "Выберите профиль";
			this.labelChooseProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonExitToMain
			// 
			this.buttonExitToMain.Location = new System.Drawing.Point(1974, 32);
			this.buttonExitToMain.Name = "buttonExitToMain";
			this.buttonExitToMain.Size = new System.Drawing.Size(474, 138);
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
			this.labelAdmin.Location = new System.Drawing.Point(29, 29);
			this.labelAdmin.Name = "labelAdmin";
			this.labelAdmin.Size = new System.Drawing.Size(553, 85);
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
			this.labelUser.Location = new System.Drawing.Point(29, 29);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(477, 85);
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
			this.labelAdFields.Location = new System.Drawing.Point(340, 342);
			this.labelAdFields.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.labelAdFields.Name = "labelAdFields";
			this.labelAdFields.Size = new System.Drawing.Size(1279, 65);
			this.labelAdFields.TabIndex = 20;
			this.labelAdFields.Text = "Заполните поля, что бы добавить новое объявление:";
			this.labelAdFields.Visible = false;
			// 
			// labelStarsShitAdm
			// 
			this.labelStarsShitAdm.AutoSize = true;
			this.labelStarsShitAdm.ForeColor = System.Drawing.Color.Crimson;
			this.labelStarsShitAdm.Location = new System.Drawing.Point(29, 266);
			this.labelStarsShitAdm.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.labelStarsShitAdm.Name = "labelStarsShitAdm";
			this.labelStarsShitAdm.Size = new System.Drawing.Size(2550, 48);
			this.labelStarsShitAdm.TabIndex = 22;
			this.labelStarsShitAdm.Text = "…:::★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★" +
    "☆★☆★:::…";
			this.labelStarsShitAdm.Visible = false;
			// 
			// labelStarsShitUsr
			// 
			this.labelStarsShitUsr.AutoSize = true;
			this.labelStarsShitUsr.ForeColor = System.Drawing.Color.MediumBlue;
			this.labelStarsShitUsr.Location = new System.Drawing.Point(29, 266);
			this.labelStarsShitUsr.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
			this.labelStarsShitUsr.Name = "labelStarsShitUsr";
			this.labelStarsShitUsr.Size = new System.Drawing.Size(2550, 48);
			this.labelStarsShitUsr.TabIndex = 23;
			this.labelStarsShitUsr.Text = "…:::★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★" +
    "☆★☆★:::…";
			this.labelStarsShitUsr.Visible = false;
			// 
			// pictureBoxIcon
			// 
			this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
			this.pictureBoxIcon.Location = new System.Drawing.Point(1037, 29);
			this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
			this.pictureBoxIcon.Name = "pictureBoxIcon";
			this.pictureBoxIcon.Size = new System.Drawing.Size(371, 214);
			this.pictureBoxIcon.TabIndex = 25;
			this.pictureBoxIcon.TabStop = false;
			this.pictureBoxIcon.Visible = false;
			// 
			// FormISA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2491, 1923);
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
			this.MaximizeBox = false;
			this.Name = "FormISA";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

