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
				var phoneNumber = new PhoneNumber(
					Convert.ToInt64(StringValidator.GetClearPhoneNumber(
						PhoneMaskedTextBox.Text)));
				Contact = new Contact(NameTextBox.Text,
					SurnameTextBox.Text, phoneNumber, 
					BirthdayDateTimePicker.Value, EmailTextBox.Text,
					VkTextBox.Text);
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
