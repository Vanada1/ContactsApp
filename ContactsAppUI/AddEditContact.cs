using ContactsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsAppUI
{
	public partial class AddEditContact : Form
	{
		public Contact Contact { set; get; }
		public AddEditContact()
		{
			InitializeComponent();
			OKButton.Click += OK_Click;
			CancelButton.Click += Cancel_Click;
		}

		private void AddEditContact_Load(object sender, EventArgs e)
		{
			if(Contact != null)
			{
				SurnameTextBox.Text = Contact.Surname;
				NameTextBox.Text = Contact.Name;
				BirthdayDateTimePicker.Value = Contact.Birthday;
				PhoneMaskedTextBox.Text = Contact.PhoneNumber.Number.ToString();
				EmailTextBox.Text = Contact.Email;
				VkTextBox.Text = Contact.VkId;
			}
		}

		private void OK_Click(object sender, EventArgs e)
		{
			try
			{
				if(Contact != null)
				{
					Contact.Surname = SurnameTextBox.Text;
					Contact.Name = NameTextBox.Text;
					Contact.PhoneNumber.Number = Convert.ToInt64(
						StringValidator.GetClearPhoneNumber(
							PhoneMaskedTextBox.Text));
					Contact.Birthday = BirthdayDateTimePicker.Value;
					Contact.Email = EmailTextBox.Text;
					Contact.VkId = VkTextBox.Text;
				}
				else
				{
					var phoneNumber = new PhoneNumber(
						Convert.ToInt64(StringValidator.GetClearPhoneNumber(
							PhoneMaskedTextBox.Text)));
					Contact = new Contact(SurnameTextBox.Text,
						NameTextBox.Text, phoneNumber, 
						BirthdayDateTimePicker.Value, EmailTextBox.Text,
						VkTextBox.Text);
				}

				this.Close();
			}
			catch(ArgumentException exception)
			{
				MessageBox.Show("Incorrect value: \n" +
					exception.Message, "Error", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
