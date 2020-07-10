using ContactsApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;

namespace ContactsAppUI
{
	public partial class ContactsApp : Form
	{
		/// <summary>
		/// Contains all data of app
		/// </summary>
		private Project _project;

		private List<Contact> _contacts;

		public ContactsApp()
		{
			InitializeComponent();
		}

		private void ContactsApp_Load(object sender, EventArgs e)
		{
			try
			{
				_project = ProjectManager.ReadProject(null);
				_project.Contacts = _project.SortContacts();
				_contacts = _project.Contacts;
			}
			catch(AccessViolationException exception)
			{
				MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
				_project = new Project();
				ProjectManager.CreatePath(null, null);
			}

			BirthdayLabel.Text = "Today birthday have:\n";
			var birthdayContacts = _project.FindBirthday(DateTime.Now);
			if (birthdayContacts.Count != 0)
			{
				for (int i = 0; i < birthdayContacts.Count - 1; i++)
				{
					BirthdayLabel.Text += birthdayContacts[i].Surname + ", ";
				}

				BirthdayLabel.Text += birthdayContacts[birthdayContacts.Count - 1].Surname;
			}
			

			UpdatesListBox(null);
		}
		
		private void Edit_Click(object sender, EventArgs e)
		{
			var selectedIndex = ContactsListBox.SelectedIndex;
			if(selectedIndex != -1)
			{
				var selectedContact = _contacts[selectedIndex];
				var editForm = new AddEditContact();
				editForm.Contact = selectedContact;
				editForm.ShowDialog();
				var updateContact = editForm.Contact;
				var selectIndexForProjectContacts = _project.FindtIndex(
					_contacts[selectedIndex]);
				_project.Contacts.RemoveAt(selectIndexForProjectContacts);
				_project.Contacts.Insert(selectIndexForProjectContacts, 
					updateContact);
				_project.Contacts = _project.SortContacts();
			}
			else
			{
				MessageBox.Show("No contact selected", "Error", 
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			SearchContact();
			UpdatesListBox(_contacts);

		}

		private void Add_Click(object sender, EventArgs e)
		{
			var addForm = new AddEditContact();
			addForm.ShowDialog();
			if (addForm.Contact != null)
			{
				var newContact = addForm.Contact;
				_project.Contacts.Add(newContact);
				ProjectManager.AppendNewContact(ref newContact, null);
				_project.Contacts = _project.SortContacts();
			}

			SearchContact();
			UpdatesListBox(_contacts);
		}

		private void Remove_Click(object sender, EventArgs e)
		{
			RemoveElement();
		}

		/// <summary>
		/// Remove the element
		/// </summary>
		private void RemoveElement()
		{
			var selectedIndex = ContactsListBox.SelectedIndex;
			if (selectedIndex != -1)
			{
				var choice = MessageBox.Show("Are you sure you want to delete",
					"To delete", MessageBoxButtons.YesNo);
				if (choice == DialogResult.Yes)
				{
					var selectedContact = _contacts[selectedIndex];
					_project.Contacts.Remove(selectedContact);
					ClearTextBoxes();
				}
			}
			else
			{
				MessageBox.Show("No contact selected", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			SearchContact();
			UpdatesListBox(_contacts);
		}

		private void listBox1_SelectedIndexChanged(object sender,
			EventArgs e)
		{
			var choosenIndex = ContactsListBox.SelectedIndex;
			if (choosenIndex != -1)
			{
				ChangeTextBoxes(_contacts[choosenIndex]);
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

			if (keyData == (Keys.Delete))
			{
				RemoveElement();
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void ContactsApp_FormClosing(Object sender,
			FormClosingEventArgs e)
		{
			ProjectManager.SaveProject(_project, null);
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
		/// Update Contacts list box
		/// </summary>
		private void UpdatesListBox(List<Contact> contacts)
		{
			if (contacts == null)
			{
				contacts = _project.Contacts;
			}
			ContactsListBox.DataSource = null;
			ContactsListBox.DataSource = contacts;
			ContactsListBox.DisplayMember = "Surname";
			ContactsListBox.ValueMember = "PhoneNumber";
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

		private void AddPictureBox_MouseHover(object sender, EventArgs e)
		{
			int imageWidth = addPictureBox.BackgroundImage.Width - (
				(addPictureBox.Width * 20) / 100);
			int imageHeight = addPictureBox.BackgroundImage.Height - (
				(addPictureBox.Height * 20) / 100);
			Bitmap newImage = new Bitmap(imageWidth,
				imageHeight);
			Graphics g = Graphics.FromImage(newImage);
			g.DrawImage(addPictureBox.BackgroundImage, new Rectangle(Point.Empty,
				newImage.Size));
			addPictureBox.BackgroundImage = newImage;
			addPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		}

		private void AddPictureBox_MouseLeave(object sender, EventArgs e)
		{
			addPictureBox.BackgroundImage = Properties.Resources.plus;
		}

		private void EditPictureBox_MouseHover(object sender, EventArgs e)
		{
			int imageWidth = editPictureBox.BackgroundImage.Width - (
				(editPictureBox.Width * 20) / 100);
			int imageHeight = editPictureBox.BackgroundImage.Height - (
				(editPictureBox.Height * 20) / 100);
			Bitmap newImage = new Bitmap(imageWidth,
				imageHeight);
			Graphics g = Graphics.FromImage(newImage);
			g.DrawImage(editPictureBox.BackgroundImage, new Rectangle(Point.Empty,
				newImage.Size));
			editPictureBox.BackgroundImage = newImage;
			editPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		}

		private void EditPictureBox_MouseLeave(object sender, EventArgs e)
		{
			editPictureBox.BackgroundImage = Properties.Resources.edit;
		}

		private void RemovePictureBox_MouseHover(object sender, EventArgs e)
		{
			int imageWidth = removePictureBox.BackgroundImage.Width - (
				(removePictureBox.Width * 20) / 100);
			int imageHeight = removePictureBox.BackgroundImage.Height - (
				(removePictureBox.Height * 20) / 100);
			Bitmap newImage = new Bitmap(imageWidth,
				imageHeight);
			Graphics g = Graphics.FromImage(newImage);
			g.DrawImage(removePictureBox.BackgroundImage, new Rectangle(Point.Empty,
				newImage.Size));
			removePictureBox.BackgroundImage = newImage;
			removePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		}

		private void RemovePictureBox_MouseLeave(object sender, EventArgs e)
		{
			removePictureBox.BackgroundImage = Properties.Resources.minus;
		}

		private void Search_TextChanged(object sender, EventArgs e)
		{
			SearchContact();
		}

		/// <summary>
		/// Looking for all contacts by first and last name
		/// </summary>
		private void SearchContact()
		{
			if (Search.Text.Length == 0)
			{
				_contacts = _project.Contacts;
			}
			else
			{
				_contacts = _project.SortContacts(Search.Text);
			}
			UpdatesListBox(_contacts);
		}
	}
}
