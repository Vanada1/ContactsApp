namespace ContactsAppUI
{
	partial class ContactsApp
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
			this.editPictureBox = new System.Windows.Forms.PictureBox();
			this.removePictureBox = new System.Windows.Forms.PictureBox();
			this.addPictureBox = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.editPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.removePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
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
			// 
			// Find
			// 
			this.Find.AutoSize = true;
			this.Find.Location = new System.Drawing.Point(3, 0);
			this.Find.Name = "Find";
			this.Find.Size = new System.Drawing.Size(27, 13);
			this.Find.TabIndex = 2;
			this.Find.Text = "Find";
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
			this.SurnameTextBox.TabIndex = 12;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NameTextBox.Location = new System.Drawing.Point(63, 38);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.ReadOnly = true;
			this.NameTextBox.Size = new System.Drawing.Size(260, 20);
			this.NameTextBox.TabIndex = 13;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EmailTextBox.Location = new System.Drawing.Point(63, 134);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.ReadOnly = true;
			this.EmailTextBox.Size = new System.Drawing.Size(260, 20);
			this.EmailTextBox.TabIndex = 16;
			// 
			// VkTextBox
			// 
			this.VkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.VkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.VkTextBox.Location = new System.Drawing.Point(63, 167);
			this.VkTextBox.Name = "VkTextBox";
			this.VkTextBox.ReadOnly = true;
			this.VkTextBox.Size = new System.Drawing.Size(260, 20);
			this.VkTextBox.TabIndex = 17;
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
			this.BirthdayDateTimePicker.TabIndex = 18;
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
			this.ContactsListBox.TabIndex = 19;
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
			this.PhoneMaskedTextBox.TabIndex = 20;
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
			// editPictureBox
			// 
			this.editPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.editPictureBox.BackgroundImage = global::ContactsAppUI.Properties.Resources.edit;
			this.editPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.editPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.editPictureBox.Location = new System.Drawing.Point(114, 390);
			this.editPictureBox.Name = "editPictureBox";
			this.editPictureBox.Size = new System.Drawing.Size(36, 36);
			this.editPictureBox.TabIndex = 24;
			this.editPictureBox.TabStop = false;
			this.editPictureBox.Click += new System.EventHandler(this.Edit_Click);
			this.editPictureBox.MouseLeave += new System.EventHandler(this.EditPictureBox_MouseLeave);
			this.editPictureBox.MouseHover += new System.EventHandler(this.EditPictureBox_MouseHover);
			// 
			// removePictureBox
			// 
			this.removePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.removePictureBox.BackgroundImage = global::ContactsAppUI.Properties.Resources.minus;
			this.removePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.removePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.removePictureBox.Location = new System.Drawing.Point(198, 390);
			this.removePictureBox.Name = "removePictureBox";
			this.removePictureBox.Size = new System.Drawing.Size(36, 36);
			this.removePictureBox.TabIndex = 23;
			this.removePictureBox.TabStop = false;
			this.removePictureBox.Click += new System.EventHandler(this.Remove_Click);
			this.removePictureBox.MouseLeave += new System.EventHandler(this.RemovePictureBox_MouseLeave);
			this.removePictureBox.MouseHover += new System.EventHandler(this.RemovePictureBox_MouseHover);
			// 
			// addPictureBox
			// 
			this.addPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addPictureBox.BackgroundImage = global::ContactsAppUI.Properties.Resources.plus;
			this.addPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.addPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addPictureBox.Location = new System.Drawing.Point(30, 390);
			this.addPictureBox.Name = "addPictureBox";
			this.addPictureBox.Size = new System.Drawing.Size(36, 36);
			this.addPictureBox.TabIndex = 22;
			this.addPictureBox.TabStop = false;
			this.addPictureBox.Click += new System.EventHandler(this.Add_Click);
			this.addPictureBox.MouseLeave += new System.EventHandler(this.AddPictureBox_MouseLeave);
			this.addPictureBox.MouseHover += new System.EventHandler(this.AddPictureBox_MouseHover);
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
			// ContactsApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 438);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.ContactsListBox);
			this.Controls.Add(this.editPictureBox);
			this.Controls.Add(this.removePictureBox);
			this.Controls.Add(this.addPictureBox);
			this.Controls.Add(this.menuStrip1);
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(613, 477);
			this.Name = "ContactsApp";
			this.Text = "ContactApp";
			this.Load += new System.EventHandler(this.ContactsApp_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.editPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.removePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
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
		private System.Windows.Forms.PictureBox editPictureBox;
		private System.Windows.Forms.PictureBox removePictureBox;
		private System.Windows.Forms.PictureBox addPictureBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
	}
}

