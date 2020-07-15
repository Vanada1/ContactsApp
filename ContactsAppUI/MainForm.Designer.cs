namespace ContactsAppUI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Search = new System.Windows.Forms.TextBox();
			this.Find = new System.Windows.Forms.Label();
			this.Surname = new System.Windows.Forms.Label();
			this.NamePerson = new System.Windows.Forms.Label();
			this.Birthday = new System.Windows.Forms.Label();
			this.Phone = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.Label();
			this.vkId = new System.Windows.Forms.Label();
			this.SurnameTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.VkTextBox = new System.Windows.Forms.TextBox();
			this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.ContactsListBox = new System.Windows.Forms.ListBox();
			this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BirthdayLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// Search
			// 
			this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.Search.Location = new System.Drawing.Point(37, 3);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(213, 20);
			this.Search.TabIndex = 1;
			this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
			// 
			// Find
			// 
			this.Find.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Find.AutoSize = true;
			this.Find.Location = new System.Drawing.Point(4, 6);
			this.Find.Name = "Find";
			this.Find.Size = new System.Drawing.Size(27, 13);
			this.Find.TabIndex = 2;
			this.Find.Text = "Find";
			this.Find.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Surname
			// 
			this.Surname.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Surname.AutoSize = true;
			this.Surname.Location = new System.Drawing.Point(5, 9);
			this.Surname.Name = "Surname";
			this.Surname.Size = new System.Drawing.Size(52, 13);
			this.Surname.TabIndex = 6;
			this.Surname.Text = "Surname:";
			this.Surname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NamePerson
			// 
			this.NamePerson.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.NamePerson.AutoSize = true;
			this.NamePerson.Location = new System.Drawing.Point(19, 41);
			this.NamePerson.Name = "NamePerson";
			this.NamePerson.Size = new System.Drawing.Size(38, 13);
			this.NamePerson.TabIndex = 7;
			this.NamePerson.Text = "Name:";
			this.NamePerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Birthday
			// 
			this.Birthday.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Birthday.AutoSize = true;
			this.Birthday.Location = new System.Drawing.Point(9, 73);
			this.Birthday.Name = "Birthday";
			this.Birthday.Size = new System.Drawing.Size(48, 13);
			this.Birthday.TabIndex = 8;
			this.Birthday.Text = "Birthday:";
			this.Birthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Phone
			// 
			this.Phone.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Phone.AutoSize = true;
			this.Phone.Location = new System.Drawing.Point(16, 105);
			this.Phone.Name = "Phone";
			this.Phone.Size = new System.Drawing.Size(41, 13);
			this.Phone.TabIndex = 9;
			this.Phone.Text = "Phone:";
			this.Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Email
			// 
			this.Email.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Email.AutoSize = true;
			this.Email.Location = new System.Drawing.Point(19, 137);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(38, 13);
			this.Email.TabIndex = 10;
			this.Email.Text = "E-mail:";
			this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// vkId
			// 
			this.vkId.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.vkId.AutoSize = true;
			this.vkId.Location = new System.Drawing.Point(12, 170);
			this.vkId.Name = "vkId";
			this.vkId.Size = new System.Drawing.Size(45, 13);
			this.vkId.TabIndex = 11;
			this.vkId.Text = "vk.com:";
			this.vkId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.SurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SurnameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.SurnameTextBox.Location = new System.Drawing.Point(63, 6);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.ReadOnly = true;
			this.SurnameTextBox.ShortcutsEnabled = false;
			this.SurnameTextBox.Size = new System.Drawing.Size(260, 20);
			this.SurnameTextBox.TabIndex = 6;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NameTextBox.Location = new System.Drawing.Point(63, 38);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.ReadOnly = true;
			this.NameTextBox.Size = new System.Drawing.Size(260, 20);
			this.NameTextBox.TabIndex = 7;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EmailTextBox.Location = new System.Drawing.Point(63, 134);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.ReadOnly = true;
			this.EmailTextBox.Size = new System.Drawing.Size(260, 20);
			this.EmailTextBox.TabIndex = 10;
			// 
			// VkTextBox
			// 
			this.VkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.VkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.VkTextBox.Location = new System.Drawing.Point(63, 167);
			this.VkTextBox.Name = "VkTextBox";
			this.VkTextBox.ReadOnly = true;
			this.VkTextBox.Size = new System.Drawing.Size(260, 20);
			this.VkTextBox.TabIndex = 11;
			// 
			// BirthdayDateTimePicker
			// 
			this.BirthdayDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BirthdayDateTimePicker.CustomFormat = "";
			this.BirthdayDateTimePicker.Enabled = false;
			this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.BirthdayDateTimePicker.Location = new System.Drawing.Point(63, 70);
			this.BirthdayDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
			this.BirthdayDateTimePicker.Size = new System.Drawing.Size(85, 20);
			this.BirthdayDateTimePicker.TabIndex = 8;
			this.BirthdayDateTimePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			// 
			// ContactsListBox
			// 
			this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.ContactsListBox.FormattingEnabled = true;
			this.ContactsListBox.Location = new System.Drawing.Point(6, 71);
			this.ContactsListBox.Name = "ContactsListBox";
			this.ContactsListBox.ScrollAlwaysVisible = true;
			this.ContactsListBox.Size = new System.Drawing.Size(247, 303);
			this.ContactsListBox.TabIndex = 2;
			this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// PhoneMaskedTextBox
			// 
			this.PhoneMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.PhoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PhoneMaskedTextBox.Location = new System.Drawing.Point(63, 102);
			this.PhoneMaskedTextBox.Mask = "7 (999) 000-0000";
			this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
			this.PhoneMaskedTextBox.ReadOnly = true;
			this.PhoneMaskedTextBox.Size = new System.Drawing.Size(260, 20);
			this.PhoneMaskedTextBox.TabIndex = 9;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.Size = new System.Drawing.Size(597, 24);
			this.menuStrip1.TabIndex = 21;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.exitToolStripMenuItem.Text = "Exit (ALT + F4)";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.removeToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.addToolStripMenuItem.Text = "Add";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.Add_Click);
			// 
			// editContactToolStripMenuItem
			// 
			this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
			this.editContactToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.editContactToolStripMenuItem.Text = "Edit Contact";
			this.editContactToolStripMenuItem.Click += new System.EventHandler(this.Edit_Click);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new System.EventHandler(this.Remove_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.aboutToolStripMenuItem.Text = "About (F1)";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.Surname, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.NamePerson, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.Birthday, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.Phone, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.PhoneMaskedTextBox, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.Email, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.EmailTextBox, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.vkId, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.BirthdayDateTimePicker, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.VkTextBox, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.SurnameTextBox, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(259, 39);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(326, 194);
			this.tableLayoutPanel1.TabIndex = 25;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.43874F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.56126F));
			this.tableLayoutPanel2.Controls.Add(this.Search, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.Find, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 39);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(253, 26);
			this.tableLayoutPanel2.TabIndex = 26;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.BirthdayLabel, 1, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(259, 322);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(326, 104);
			this.tableLayoutPanel3.TabIndex = 27;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::ContactsAppUI.Properties.Resources.unnamed;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(99, 98);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// BirthdayLabel
			// 
			this.BirthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BirthdayLabel.AutoSize = true;
			this.BirthdayLabel.Location = new System.Drawing.Point(108, 0);
			this.BirthdayLabel.Name = "BirthdayLabel";
			this.BirthdayLabel.Size = new System.Drawing.Size(215, 104);
			this.BirthdayLabel.TabIndex = 1;
			this.BirthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.Controls.Add(this.RemoveButton, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.AddButton, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.EditButton, 1, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 395);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(105, 31);
			this.tableLayoutPanel4.TabIndex = 31;
			// 
			// RemoveButton
			// 
			this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.bin;
			this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveButton.ForeColor = System.Drawing.SystemColors.Control;
			this.RemoveButton.Location = new System.Drawing.Point(73, 3);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(29, 25);
			this.RemoveButton.TabIndex = 5;
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.Remove_Click);
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.plus;
			this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
			this.AddButton.Location = new System.Drawing.Point(3, 3);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(29, 25);
			this.AddButton.TabIndex = 3;
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.Add_Click);
			// 
			// EditButton
			// 
			this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EditButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.edit;
			this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditButton.ForeColor = System.Drawing.SystemColors.Control;
			this.EditButton.Location = new System.Drawing.Point(38, 3);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(29, 25);
			this.EditButton.TabIndex = 4;
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.Edit_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 438);
			this.Controls.Add(this.tableLayoutPanel4);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.ContactsListBox);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(613, 477);
			this.Name = "MainForm";
			this.Text = "ContactApp";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactsApp_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Search;
		private System.Windows.Forms.Label Find;
		private System.Windows.Forms.Label Surname;
		private System.Windows.Forms.Label NamePerson;
		private System.Windows.Forms.Label Birthday;
		private System.Windows.Forms.Label Phone;
		private System.Windows.Forms.Label Email;
		private System.Windows.Forms.Label vkId;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.TextBox VkTextBox;
		private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
		private System.Windows.Forms.ListBox ContactsListBox;
		private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TextBox SurnameTextBox;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label BirthdayLabel;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
	}
}

