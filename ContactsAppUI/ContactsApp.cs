using ContactsApp;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;

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
	}
}
