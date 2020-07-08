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
			this.AddButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
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
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Search
			// 
			this.Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.Search.Location = new System.Drawing.Point(36, 39);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(229, 20);
			this.Search.TabIndex = 1;
			// 
			// Find
			// 
			this.Find.AutoSize = true;
			this.Find.Location = new System.Drawing.Point(3, 42);
			this.Find.Name = "Find";
			this.Find.Size = new System.Drawing.Size(27, 13);
			this.Find.TabIndex = 2;
			this.Find.Text = "Find";
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(20, 397);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(36, 33);
			this.AddButton.TabIndex = 3;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.Add_Click);
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(62, 397);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(36, 33);
			this.EditButton.TabIndex = 4;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.Edit_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(104, 397);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(36, 33);
			this.RemoveButton.TabIndex = 5;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			// 
			// Surname
			// 
			this.Surname.AutoSize = true;
			this.Surname.Location = new System.Drawing.Point(294, 42);
			this.Surname.Name = "Surname";
			this.Surname.Size = new System.Drawing.Size(52, 13);
			this.Surname.TabIndex = 6;
			this.Surname.Text = "Surname:";
			// 
			// NamePerson
			// 
			this.NamePerson.AutoSize = true;
			this.NamePerson.Location = new System.Drawing.Point(308, 65);
			this.NamePerson.Name = "NamePerson";
			this.NamePerson.Size = new System.Drawing.Size(38, 13);
			this.NamePerson.TabIndex = 7;
			this.NamePerson.Text = "Name:";
			// 
			// Birthday
			// 
			this.Birthday.AutoSize = true;
			this.Birthday.Location = new System.Drawing.Point(298, 91);
			this.Birthday.Name = "Birthday";
			this.Birthday.Size = new System.Drawing.Size(48, 13);
			this.Birthday.TabIndex = 8;
			this.Birthday.Text = "Birthday:";
			// 
			// Phone
			// 
			this.Phone.AutoSize = true;
			this.Phone.Location = new System.Drawing.Point(305, 120);
			this.Phone.Name = "Phone";
			this.Phone.Size = new System.Drawing.Size(41, 13);
			this.Phone.TabIndex = 9;
			this.Phone.Text = "Phone:";
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Location = new System.Drawing.Point(308, 146);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(38, 13);
			this.Email.TabIndex = 10;
			this.Email.Text = "E-mail:";
			// 
			// vkId
			// 
			this.vkId.AutoSize = true;
			this.vkId.Location = new System.Drawing.Point(301, 172);
			this.vkId.Name = "vkId";
			this.vkId.Size = new System.Drawing.Size(45, 13);
			this.vkId.TabIndex = 11;
			this.vkId.Text = "vk.com:";
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SurnameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.SurnameTextBox.Location = new System.Drawing.Point(352, 39);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.ReadOnly = true;
			this.SurnameTextBox.ShortcutsEnabled = false;
			this.SurnameTextBox.Size = new System.Drawing.Size(229, 20);
			this.SurnameTextBox.TabIndex = 12;
			// 
			// NameTextBox
			// 
			this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NameTextBox.Location = new System.Drawing.Point(352, 65);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.ReadOnly = true;
			this.NameTextBox.Size = new System.Drawing.Size(229, 20);
			this.NameTextBox.TabIndex = 13;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EmailTextBox.Location = new System.Drawing.Point(352, 143);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.ReadOnly = true;
			this.EmailTextBox.Size = new System.Drawing.Size(229, 20);
			this.EmailTextBox.TabIndex = 16;
			// 
			// VkTextBox
			// 
			this.VkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.VkTextBox.Location = new System.Drawing.Point(352, 169);
			this.VkTextBox.Name = "VkTextBox";
			this.VkTextBox.ReadOnly = true;
			this.VkTextBox.Size = new System.Drawing.Size(229, 20);
			this.VkTextBox.TabIndex = 17;
			// 
			// BirthdayDateTimePicker
			// 
			this.BirthdayDateTimePicker.CustomFormat = "";
			this.BirthdayDateTimePicker.Enabled = false;
			this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.BirthdayDateTimePicker.Location = new System.Drawing.Point(352, 91);
			this.BirthdayDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
			this.BirthdayDateTimePicker.Size = new System.Drawing.Size(93, 20);
			this.BirthdayDateTimePicker.TabIndex = 18;
			this.BirthdayDateTimePicker.Value = new System.DateTime(2020, 7, 6, 17, 14, 22, 0);
			// 
			// ContactsListBox
			// 
			this.ContactsListBox.FormattingEnabled = true;
			this.ContactsListBox.Location = new System.Drawing.Point(6, 68);
			this.ContactsListBox.Name = "ContactsListBox";
			this.ContactsListBox.ScrollAlwaysVisible = true;
			this.ContactsListBox.Size = new System.Drawing.Size(259, 316);
			this.ContactsListBox.TabIndex = 19;
			this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// PhoneMaskedTextBox
			// 
			this.PhoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PhoneMaskedTextBox.Location = new System.Drawing.Point(352, 117);
			this.PhoneMaskedTextBox.Mask = "7 (999) 000-0000";
			this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
			this.PhoneMaskedTextBox.ReadOnly = true;
			this.PhoneMaskedTextBox.Size = new System.Drawing.Size(229, 20);
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
			// 
			// editContactToolStripMenuItem
			// 
			this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
			this.editContactToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.editContactToolStripMenuItem.Text = "Edit Contact";
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.removeToolStripMenuItem.Text = "Remove";
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
			// 
			// ContactsApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(597, 438);
			this.Controls.Add(this.PhoneMaskedTextBox);
			this.Controls.Add(this.ContactsListBox);
			this.Controls.Add(this.BirthdayDateTimePicker);
			this.Controls.Add(this.VkTextBox);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.SurnameTextBox);
			this.Controls.Add(this.vkId);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.Phone);
			this.Controls.Add(this.Birthday);
			this.Controls.Add(this.NamePerson);
			this.Controls.Add(this.Surname);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.Find);
			this.Controls.Add(this.Search);
			this.Controls.Add(this.menuStrip1);
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ContactsApp";
			this.Text = "ContactApp";
			this.Load += new System.EventHandler(this.ContactsApp_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Search;
		private System.Windows.Forms.Label Find;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button RemoveButton;
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
	}
}

