﻿using ContactsApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;

namespace ContactsAppUI
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// Contains all data of app
		/// </summary>
		private Project _project;

        /// <summary>
        /// Support list for search 
        /// </summary>
        private List<Contact> _contacts;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				_project = ProjectManager.ReadProject();
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
            //TODO: здесь же метод можно было тоже вызвать с _contacts и не городить костылей с проверкой на null(done)
            UpdatesListBox(_contacts);
		}
		
		private void Edit_Click(object sender, EventArgs e)
		{
			var selectedIndex = ContactsListBox.SelectedIndex;
			if(selectedIndex != -1)
			{
				var selectedContact = _contacts[selectedIndex];
				var editForm = new ContactForm();
				editForm.Contact = selectedContact;
				editForm.ShowDialog(); //TODO: проверка DialogResult(done)
				if (editForm.DialogResult == DialogResult.OK)
				{
					var updateContact = editForm.Contact;
					var selectIndexForProjectContacts = _project.FindIndex(
						_contacts[selectedIndex]);
					_project.Contacts.RemoveAt(selectIndexForProjectContacts);
					_project.Contacts.Insert(selectIndexForProjectContacts,
						updateContact);
					_project.Contacts = _project.SortContacts();
				}

				ProjectManager.SaveProject(_project);
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
			var addForm = new ContactForm();
			addForm.ShowDialog();
            //TODO: надо проверять не по null, а по DialogResult, вернувшемуся из метода ShowDialog. Вторая форма соответственно при закрытии должна присваивать какое-то значение в DialogResult для кнопки Ok и Cancel(done)
            if (addForm.DialogResult == DialogResult.OK)
			{
				var newContact = addForm.Contact;
				_project.Contacts.Add(newContact);
				ProjectManager.SaveProject(_project);
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
					ProjectManager.SaveProject(_project);
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
			var chosenIndex = ContactsListBox.SelectedIndex;
			if (chosenIndex == -1) return;
			ChangeTextBoxes(_contacts[chosenIndex]);
			
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
			ProjectManager.SaveProject(_project);
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
            //TODO: зачем эти неочевидные костыли с null? Почему не передавать везде вместо null существующий список контактов? А внутри не делать таких проверок(done)
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
			int imageWidth = AddButton.BackgroundImage.Width - (
				(AddButton.Width * 20) / 100);
			int imageHeight = AddButton.BackgroundImage.Height - (
				(AddButton.Height * 20) / 100);
			Bitmap newImage = new Bitmap(imageWidth,
				imageHeight);
			Graphics g = Graphics.FromImage(newImage);
			g.DrawImage(AddButton.BackgroundImage, new Rectangle(Point.Empty,
				newImage.Size));
			AddButton.BackgroundImage = newImage;
			AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		}

		private void AddPictureBox_MouseLeave(object sender, EventArgs e)
		{
			AddButton.BackgroundImage = Properties.Resources.plus;
		}

		private void EditPictureBox_MouseHover(object sender, EventArgs e)
		{
			int imageWidth = EditButton.BackgroundImage.Width - (
				(EditButton.Width * 20) / 100);
			int imageHeight = EditButton.BackgroundImage.Height - (
				(EditButton.Height * 20) / 100);
			Bitmap newImage = new Bitmap(imageWidth,
				imageHeight);
			Graphics g = Graphics.FromImage(newImage);
			g.DrawImage(EditButton.BackgroundImage, new Rectangle(Point.Empty,
				newImage.Size));
			EditButton.BackgroundImage = newImage;
			EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		}

		private void EditPictureBox_MouseLeave(object sender, EventArgs e)
		{
			EditButton.BackgroundImage = Properties.Resources.edit;
		}

		private void RemovePictureBox_MouseHover(object sender, EventArgs e)
		{
			int imageWidth = RemoveButton.BackgroundImage.Width - (
				(RemoveButton.Width * 20) / 100);
			int imageHeight = RemoveButton.BackgroundImage.Height - (
				(RemoveButton.Height * 20) / 100);
			Bitmap newImage = new Bitmap(imageWidth,
				imageHeight);
			Graphics g = Graphics.FromImage(newImage);
			g.DrawImage(RemoveButton.BackgroundImage, new Rectangle(Point.Empty,
				newImage.Size));
			RemoveButton.BackgroundImage = newImage;
			RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		}

		private void RemovePictureBox_MouseLeave(object sender, EventArgs e)
		{
			RemoveButton.BackgroundImage = Properties.Resources.bin;
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
