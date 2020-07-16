using ContactsApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;

namespace ContactsAppUI
{
    //TODO: Плашка с днём рождения висит всегда, а должна только тогда, когда у кого есть день рождения(done)
    //TODO: Под главным меню какая-то белая полоса. Проверь верстку(done)
    //TODO: Плашка с днём рождения сверстана криво - пиктограмма имеет разные поля от границ плашки, смотрится не аккуратно. И вообще, смотрится мрачновато(done)
    //TODO: текстбокс поиска не выровнен по размеру листбокса(done)
    //TODO: иконки для кнопок разношерстные - найти одинаковые по стилю(done)
    //TODO: после добавления/редактирования заметки почему-то сбрасывается текущая выбранная заметка. Надо менять фокус на новую заметку(done)
    //TODO: создал три заметки на русском языке, закрыл программу. Запустил еще раз - вместо русских символов показываются знаки вопроса(done)
    //TODO: у второго окна очень странная логика при растяжении - увеличивается расстояние между строчками, почему-то увеличиваются кнопки.(done)
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
				_project.Contacts = _project.SearchContacts();
				_contacts = _project.Contacts;
			}
			catch(AccessViolationException exception)
			{
				MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
				_project = new Project();
				ProjectManager.CreatePath(null, null);
			}

			BirthdayLabel.Text = "Today birthday have:\n";
			var birthdayContacts = _project.FindBirthdayContacts(DateTime.Now);
			if (birthdayContacts.Count != 0)
			{
				for (int i = 0; i < birthdayContacts.Count - 1; i++)
				{
					BirthdayLabel.Text += birthdayContacts[i].Surname + ", ";
				}

				BirthdayLabel.Text += birthdayContacts[birthdayContacts.Count - 1].Surname;
			}
			else
			{
				this.Controls.Remove(birthdayTableLayoutPanel);
			}
            UpdatesListBox(_contacts);
            ContactsListBox.ClearSelected();
		}
		
		private void Edit_Click(object sender, EventArgs e)
		{
			var selectedIndex = ContactsListBox.SelectedIndex;
			if(selectedIndex != -1)
			{
				var selectedContact = _contacts[selectedIndex];
				var editForm = new ContactForm()
				{
					Contact = selectedContact
				};
				editForm.ShowDialog();
				var updateContact = editForm.Contact;
				if (editForm.DialogResult == DialogResult.OK)
				{
					
					var selectIndexForProjectContacts = _project.FindIndex(
						selectedContact);
					_project.Contacts.RemoveAt(selectIndexForProjectContacts);
					_project.Contacts.Insert(selectIndexForProjectContacts,
						updateContact);
					_project.Contacts = _project.SearchContacts();
					
				}

				ProjectManager.SaveProject(_project);
				SearchContact();
				UpdatesListBox(_contacts);
				ChangeTextBoxes(updateContact);
				var selectContact = _project.FindIndex(updateContact);
				ContactsListBox.ClearSelected();
				ContactsListBox.SetSelected(selectContact, true);
			}
			else
			{
				MessageBox.Show("No contact selected", "Error", 
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void Add_Click(object sender, EventArgs e)
		{
			var addForm = new ContactForm();
			addForm.ShowDialog();
			if (addForm.DialogResult == DialogResult.OK)
			{
				var newContact = addForm.Contact;
				_project.Contacts.Add(newContact);
				ProjectManager.SaveProject(_project);
				_project.Contacts = _project.SearchContacts();
				SearchContact();
				UpdatesListBox(_contacts);
				ChangeTextBoxes(newContact);
				var selectContact = _project.FindIndex(newContact);
				ContactsListBox.ClearSelected();
				ContactsListBox.SetSelected(selectContact, true);
			}
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
					ProjectManager.SaveProject(_project);
					SearchContact();
					UpdatesListBox(_contacts);
					ContactsListBox.ClearSelected();
					ClearTextBoxes();
				}
			}
			else
			{
				MessageBox.Show("No contact selected", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void ListBox1_SelectedIndexChanged(object sender,
			EventArgs e)
		{
            //TODO: не надо менять термины. Если называется selected - оставляй selected(done)
            var selectedIndex = ContactsListBox.SelectedIndex;
			if (selectedIndex == -1) return;
			ChangeTextBoxes(_contacts[selectedIndex]);
			
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
				_contacts = _project.SearchContacts();
			}
			else
			{
				_contacts = _project.SearchContacts(Search.Text);
			}
			UpdatesListBox(_contacts);
		}
	}
}
