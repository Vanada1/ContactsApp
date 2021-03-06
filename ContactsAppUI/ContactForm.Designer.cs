﻿namespace ContactsAppUI
{
	partial class ContactForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// PhoneMaskedTextBox
			// 
			this.PhoneMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.PhoneMaskedTextBox.Location = new System.Drawing.Point(66, 78);
			this.PhoneMaskedTextBox.Mask = "7 (999) 000-0000";
			this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
			this.PhoneMaskedTextBox.Size = new System.Drawing.Size(302, 20);
			this.PhoneMaskedTextBox.TabIndex = 4;
			this.PhoneMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PhoneMaskedTextBox_MaskInputRejected);
			// 
			// BirthdayDateTimePicker
			// 
			this.BirthdayDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BirthdayDateTimePicker.CalendarForeColor = System.Drawing.Color.Black;
			this.BirthdayDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
			this.BirthdayDateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.BirthdayDateTimePicker.CustomFormat = "";
			this.BirthdayDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.BirthdayDateTimePicker.Location = new System.Drawing.Point(66, 53);
			this.BirthdayDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
			this.BirthdayDateTimePicker.Size = new System.Drawing.Size(163, 20);
			this.BirthdayDateTimePicker.TabIndex = 3;
			this.BirthdayDateTimePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.BirthdayDateTimePicker.ValueChanged += new System.EventHandler(this.BirthdayDateTimePicker_ValueChanged);
			// 
			// VkTextBox
			// 
			this.VkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.VkTextBox.Location = new System.Drawing.Point(66, 130);
			this.VkTextBox.Name = "VkTextBox";
			this.VkTextBox.Size = new System.Drawing.Size(302, 20);
			this.VkTextBox.TabIndex = 6;
			this.VkTextBox.TextChanged += new System.EventHandler(this.VkTextBox_TextChanged);
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.EmailTextBox.Location = new System.Drawing.Point(66, 103);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(302, 20);
			this.EmailTextBox.TabIndex = 5;
			this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
			// 
			// NameTextBox
			// 
			this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.NameTextBox.Location = new System.Drawing.Point(66, 28);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(302, 20);
			this.NameTextBox.TabIndex = 2;
			this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.SurnameTextBox.Location = new System.Drawing.Point(66, 3);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.Size = new System.Drawing.Size(302, 20);
			this.SurnameTextBox.TabIndex = 1;
			this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
			// 
			// vkId
			// 
			this.vkId.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.vkId.AutoSize = true;
			this.vkId.Location = new System.Drawing.Point(15, 133);
			this.vkId.Name = "vkId";
			this.vkId.Size = new System.Drawing.Size(45, 13);
			this.vkId.TabIndex = 26;
			this.vkId.Text = "vk.com:";
			// 
			// Email
			// 
			this.Email.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Email.AutoSize = true;
			this.Email.Location = new System.Drawing.Point(22, 106);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(38, 13);
			this.Email.TabIndex = 25;
			this.Email.Text = "E-mail:";
			// 
			// Phone
			// 
			this.Phone.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Phone.AutoSize = true;
			this.Phone.Location = new System.Drawing.Point(19, 81);
			this.Phone.Name = "Phone";
			this.Phone.Size = new System.Drawing.Size(41, 13);
			this.Phone.TabIndex = 24;
			this.Phone.Text = "Phone:";
			// 
			// Birthday
			// 
			this.Birthday.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Birthday.AutoSize = true;
			this.Birthday.Location = new System.Drawing.Point(12, 56);
			this.Birthday.Name = "Birthday";
			this.Birthday.Size = new System.Drawing.Size(48, 13);
			this.Birthday.TabIndex = 23;
			this.Birthday.Text = "Birthday:";
			// 
			// NamePerson
			// 
			this.NamePerson.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.NamePerson.AutoSize = true;
			this.NamePerson.Location = new System.Drawing.Point(22, 31);
			this.NamePerson.Name = "NamePerson";
			this.NamePerson.Size = new System.Drawing.Size(38, 13);
			this.NamePerson.TabIndex = 22;
			this.NamePerson.Text = "Name:";
			// 
			// Surname
			// 
			this.Surname.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Surname.AutoSize = true;
			this.Surname.Location = new System.Drawing.Point(8, 6);
			this.Surname.Name = "Surname";
			this.Surname.Size = new System.Drawing.Size(52, 13);
			this.Surname.TabIndex = 21;
			this.Surname.Text = "Surname:";
			// 
			// OKButton
			// 
			this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OKButton.Location = new System.Drawing.Point(3, 3);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(94, 24);
			this.OKButton.TabIndex = 7;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OK_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(103, 3);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(94, 24);
			this.CancelButton.TabIndex = 8;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.Surname, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Birthday, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.Phone, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.VkTextBox, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.Email, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.EmailTextBox, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.vkId, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.BirthdayDateTimePicker, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.SurnameTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.NamePerson, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.PhoneMaskedTextBox, 1, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 155);
			this.tableLayoutPanel1.TabIndex = 35;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.CancelButton, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.OKButton, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(108, 173);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 30);
			this.tableLayoutPanel2.TabIndex = 36;
			// 
			// ContactForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 212);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(409, 251);
			this.Name = "ContactForm";
			this.Text = "Add/Edit Contact";
			this.Load += new System.EventHandler(this.ContactForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

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
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button OKButton;
	}
}