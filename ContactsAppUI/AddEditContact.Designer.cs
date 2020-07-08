namespace ContactsAppUI
{
	partial class AddEditContact
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
			this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.VkTextBox = new System.Windows.Forms.TextBox();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.SurnameTextBox = new System.Windows.Forms.TextBox();
			this.vkId = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.Label();
			this.Phone = new System.Windows.Forms.Label();
			this.Birthday = new System.Windows.Forms.Label();
			this.NamePerson = new System.Windows.Forms.Label();
			this.Surname = new System.Windows.Forms.Label();
			this.OKButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PhoneMaskedTextBox
			// 
			this.PhoneMaskedTextBox.Location = new System.Drawing.Point(70, 91);
			this.PhoneMaskedTextBox.Mask = "7 (999) 000-0000";
			this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
			this.PhoneMaskedTextBox.Size = new System.Drawing.Size(299, 20);
			this.PhoneMaskedTextBox.TabIndex = 32;
			// 
			// BirthdayDateTimePicker
			// 
			this.BirthdayDateTimePicker.CustomFormat = "";
			this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.BirthdayDateTimePicker.Location = new System.Drawing.Point(70, 65);
			this.BirthdayDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
			this.BirthdayDateTimePicker.Size = new System.Drawing.Size(163, 20);
			this.BirthdayDateTimePicker.TabIndex = 31;
			this.BirthdayDateTimePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			// 
			// VkTextBox
			// 
			this.VkTextBox.Location = new System.Drawing.Point(70, 143);
			this.VkTextBox.Name = "VkTextBox";
			this.VkTextBox.Size = new System.Drawing.Size(299, 20);
			this.VkTextBox.TabIndex = 30;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(70, 117);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(299, 20);
			this.EmailTextBox.TabIndex = 29;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(70, 39);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(299, 20);
			this.NameTextBox.TabIndex = 28;
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.Location = new System.Drawing.Point(70, 13);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.Size = new System.Drawing.Size(299, 20);
			this.SurnameTextBox.TabIndex = 27;
			// 
			// vkId
			// 
			this.vkId.AutoSize = true;
			this.vkId.Location = new System.Drawing.Point(19, 146);
			this.vkId.Name = "vkId";
			this.vkId.Size = new System.Drawing.Size(45, 13);
			this.vkId.TabIndex = 26;
			this.vkId.Text = "vk.com:";
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Location = new System.Drawing.Point(26, 120);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(38, 13);
			this.Email.TabIndex = 25;
			this.Email.Text = "E-mail:";
			// 
			// Phone
			// 
			this.Phone.AutoSize = true;
			this.Phone.Location = new System.Drawing.Point(23, 94);
			this.Phone.Name = "Phone";
			this.Phone.Size = new System.Drawing.Size(41, 13);
			this.Phone.TabIndex = 24;
			this.Phone.Text = "Phone:";
			// 
			// Birthday
			// 
			this.Birthday.AutoSize = true;
			this.Birthday.Location = new System.Drawing.Point(16, 68);
			this.Birthday.Name = "Birthday";
			this.Birthday.Size = new System.Drawing.Size(48, 13);
			this.Birthday.TabIndex = 23;
			this.Birthday.Text = "Birthday:";
			// 
			// NamePerson
			// 
			this.NamePerson.AutoSize = true;
			this.NamePerson.Location = new System.Drawing.Point(26, 42);
			this.NamePerson.Name = "NamePerson";
			this.NamePerson.Size = new System.Drawing.Size(38, 13);
			this.NamePerson.TabIndex = 22;
			this.NamePerson.Text = "Name:";
			// 
			// Surname
			// 
			this.Surname.AutoSize = true;
			this.Surname.Location = new System.Drawing.Point(12, 16);
			this.Surname.Name = "Surname";
			this.Surname.Size = new System.Drawing.Size(52, 13);
			this.Surname.TabIndex = 21;
			this.Surname.Text = "Surname:";
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(237, 173);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(70, 27);
			this.OKButton.TabIndex = 33;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OK_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(313, 173);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(70, 27);
			this.CancelButton.TabIndex = 34;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// AddEditContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(393, 212);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.PhoneMaskedTextBox);
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
			this.Name = "AddEditContact";
			this.Text = "Add/Edit Contact";
			this.Load += new System.EventHandler(this.AddEditContact_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
		private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
		private System.Windows.Forms.TextBox VkTextBox;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox SurnameTextBox;
		private System.Windows.Forms.Label vkId;
		private System.Windows.Forms.Label Email;
		private System.Windows.Forms.Label Phone;
		private System.Windows.Forms.Label Birthday;
		private System.Windows.Forms.Label NamePerson;
		private System.Windows.Forms.Label Surname;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Button CancelButton;
	}
}