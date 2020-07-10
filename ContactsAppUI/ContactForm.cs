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
	public partial class ContactForm : Form
	{
		public Contact Contact { set; get; }

		private Contact _oldContact = null;
		public ContactForm()
		{
			InitializeComponent();
		}

		private void ContactForm_Load(object sender, EventArgs e)
		{
			if(Contact != null)
			{
				SurnameTextBox.Text = Contact.Surname;
				NameTextBox.Text = Contact.Name;
				BirthdayDateTimePicker.Value = Contact.Birthday;
				PhoneMaskedTextBox.Text = Contact.PhoneNumber.Number.ToString();
				EmailTextBox.Text = Contact.Email;
				VkTextBox.Text = Contact.VkId;
				_oldContact = new Contact(Contact.Name, Contact.Surname,
					Contact.PhoneNumber, Contact.Birthday,  Contact.Email,
					Contact.VkId);
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
			Contact = _oldContact;
			this.Close();
		}

		private void SurnameTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				StringValidator.AssertStringLength(SurnameTextBox.Text,
					Contact.MAXLETTERCOUNT, null);
				SurnameTextBox.ForeColor = Color.Black;
			}
			catch (ArgumentException exception)
			{
				SurnameTextBox.ForeColor = Color.LightSalmon;
			}
		}

		private void NameTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				StringValidator.AssertStringLength(NameTextBox.Text,
					Contact.MAXLETTERCOUNT, null);
				NameTextBox.ForeColor = Color.Black;
			}
			catch (ArgumentException exception)
			{
				NameTextBox.ForeColor = Color.LightSalmon;
			}
		}

		private void BirthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				DateValidator.AssertDate(BirthdayDateTimePicker.Value);
				BirthdayDateTimePicker.CalendarForeColor = Color.Black;
			}
			catch (ArgumentException exception)
			{
				BirthdayDateTimePicker.CalendarForeColor = Color.LightSalmon;
			}
		}

		private void EmailTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				StringValidator.AssertStringLength(EmailTextBox.Text,
					Contact.MAXLETTERCOUNT, null);
				EmailTextBox.ForeColor = Color.Black;
			}
			catch (ArgumentException exception)
			{
				EmailTextBox.ForeColor = Color.LightSalmon;
			}
		}

		private void VkTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				StringValidator.AssertStringLength(VkTextBox.Text,
					Contact.MAXVKLETTERCOUNT, null);
				VkTextBox.ForeColor = Color.Black;
			}
			catch (ArgumentException exception)
			{
				VkTextBox.ForeColor = Color.LightSalmon;
			}
		}
	}
}
