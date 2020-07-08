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
	public partial class ContactsApp : Form
	{
		private Project _project = new Project();

		public ContactsApp()
		{
			InitializeComponent();
		}

		private void ContactsApp_Load(object sender, EventArgs e)
		{
			_project.Contacts = ProjectManager.ReadFile();
			foreach (var i in _project.Contacts)
			{
				ContactsListBox.Items.Add(i.Surname.ToString() + ' ' +
					i.Name.ToString());
			}
		}

		private void Edit_Click(object sender, EventArgs e)
		{
			var selectedIndex = ContactsListBox.SelectedIndex;
			if(selectedIndex != -1)
			{
				var selectedContact = _project.Contacts[selectedIndex];
				var editForm = new AddEditContact();
				editForm.Contact = selectedContact;
				editForm.ShowDialog();
				var updateContact = editForm.Contact;

				ContactsListBox.Items.RemoveAt(selectedIndex);
				_project.Contacts.RemoveAt(selectedIndex);
				_project.Contacts.Insert(selectedIndex, updateContact);
				var name = updateContact.Name;
				var surname = updateContact.Surname;
				ContactsListBox.Items.Insert(selectedIndex,
					surname + ' ' + name);
				ChangeTextBoxes(updateContact);
			}
			else
			{
				MessageBox.Show("No contact selected", "Error", 
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		private void Add_Click(object sender, EventArgs e)
		{
			var addForm = new AddEditContact();
			addForm.ShowDialog();
			if (addForm.Contact != null)
			{
				var newContact = addForm.Contact;
				_project.Contacts.Add(newContact);
				ProjectManager.AppendNewContact(ref newContact);
				var name = newContact.Name;
				var surname = newContact.Surname;
				ContactsListBox.Items.Add(surname + ' ' + name);
			}
		}

		private void Remove_Click(object sender, EventArgs e)
		{
			var selectedIndex = ContactsListBox.SelectedIndex;
			if (selectedIndex != -1)
			{
				var choose = MessageBox.Show("Are you sure you want to delete",
					"To delete", MessageBoxButtons.YesNo);
				if (choose == DialogResult.Yes)
				{
					var selectedContact = _project.Contacts[selectedIndex];
					_project.Contacts.Remove(selectedContact);
					ProjectManager.RemoveContact(selectedContact);
					ContactsListBox.Items.RemoveAt(selectedIndex);
					ClearTextBoxes();
				}
			}
			else
			{
				MessageBox.Show("No contact selected", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void listBox1_SelectedIndexChanged(object sender,
			EventArgs e)
		{
			var choosenIndex = ContactsListBox.SelectedIndex;
			if (choosenIndex != -1)
			{
				ChangeTextBoxes(_project.Contacts[choosenIndex]);
			}

		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void About_Click(object sender, EventArgs e)
		{
			var about = new About();
			about.ShowDialog();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys.F1))
			{
				var about = new About();
				about.ShowDialog();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void ContactsApp_FormClosing(Object sender,
			FormClosingEventArgs e)
		{
			ProjectManager.OverwriteFile(_project.Contacts);
		}

		/// <summary>
		/// Clears all Text boxes
		/// </summary>
		private void ClearTextBoxes()
		{
			SurnameTextBox.Clear();
			NameTextBox.Clear();
			BirthdayDateTimePicker.Value = BirthdayDateTimePicker.MinDate;
			PhoneMaskedTextBox.Clear();
			EmailTextBox.Clear();
			VkTextBox.Clear();
		}

		/// <summary>
		/// Changes Text Boxes
		/// </summary>
		/// <param name="contact">
		/// Contact to add to Text Boxes
		/// </param>
		private void ChangeTextBoxes(Contact contact)
		{
			SurnameTextBox.Text = contact.Surname;
			NameTextBox.Text = contact.Name;
			BirthdayDateTimePicker.Value = contact.Birthday;
			PhoneMaskedTextBox.Text = contact.PhoneNumber.Number.ToString();
			EmailTextBox.Text = contact.Email;
			VkTextBox.Text = contact.VkId;
		}
	}
}
