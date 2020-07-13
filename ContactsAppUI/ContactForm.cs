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
		/// <summary>
		/// Contact for add or edit the list
		/// </summary>
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
					Contact.VkId); //TODO: Clone()
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
				SurnameTextBox.BackColor = Color.White;
			}
			catch (ArgumentException exception)
			{
				if (SurnameTextBox.Text.Length != 0)
				{
					SurnameTextBox.BackColor = Color.LightSalmon;
				}
				
			}
		}

		private void NameTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				StringValidator.AssertStringLength(NameTextBox.Text,
					Contact.MAXLETTERCOUNT, null);
				NameTextBox.BackColor = Color.White;
			}
			catch (ArgumentException exception)
			{
				if (NameTextBox.Text.Length != 0)
				{
					NameTextBox.BackColor = Color.LightSalmon;
				}

			}
		}

		private void BirthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				DateValidator.AssertDate(BirthdayDateTimePicker.Value);
				BirthdayDateTimePicker.CalendarTitleBackColor = Color.White;
			}
			catch (ArgumentException exception)
			{
				BirthdayDateTimePicker.CalendarTitleBackColor = Color.LightSalmon;
			}
		}

		private void EmailTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				StringValidator.AssertStringLength(EmailTextBox.Text,
					Contact.MAXLETTERCOUNT, null);
				EmailTextBox.BackColor = Color.White;
			}
			catch (ArgumentException exception)
			{
				if (EmailTextBox.Text.Length != 0)
				{
					EmailTextBox.BackColor = Color.LightSalmon;
				}
			}
		}

		private void VkTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				StringValidator.AssertStringLength(VkTextBox.Text,
					Contact.MAXVKLETTERCOUNT, null);
				VkTextBox.BackColor = Color.White;
			}
			catch (ArgumentException exception)
			{
				if (VkTextBox.Text.Length != 0)
				{
					VkTextBox.BackColor = Color.LightSalmon;
				}
				
			}
		}
	}
}
