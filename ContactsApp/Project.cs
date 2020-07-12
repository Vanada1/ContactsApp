using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace ContactsApp
{
	/// <summary>
	/// contains all the data about the <see cref="Project"/>
	/// </summary>
	public class Project
	{
		/// <summary>
		/// Contains all <see cref="Contacts"/> at the moment
		/// </summary>
		public List<Contact> Contacts { set; get; } = new List<Contact>();

		/// <summary>
		/// Sort contacts list
		/// </summary>
		/// <returns>All sorted contacts</returns>
		public List<Contact> SortContacts()
		{
			var query = Contacts.OrderBy(
				contact => contact.Surname);
			var contacts = new List<Contact>();
			foreach (var i in query)
			{
				contacts.Add(i);
			}

			return contacts;
		}

		/// <summary>
		/// Sorting all contacts
		/// </summary>
		/// <param name="substring">
		/// looking for a substring
		/// </param>
		/// <returns>
		/// Returns all contacts that have a <paramref name="substring"/>
		/// </returns>
		public List<Contact> SortContacts(string substring)
		{
			var query = Contacts.OrderBy(
				contact => contact.Surname);
			var contacts = new List<Contact>();
			foreach (var i in query)
			{
				if (i.Surname.Contains(substring))
				{
					contacts.Add(i);
				}
				else if (i.Name.Contains(substring))
				{
					contacts.Add(i);
				}
			}

			return contacts;
		}

		public List<Contact> FindBirthday(DateTime date)
		{
			var birthdayContacts = new List<Contact>();
			foreach (var contact in Contacts)
			{
				if (contact.Birthday.Day == date.Day &&
				    contact.Birthday.Month == date.Month)
				{
					birthdayContacts.Add(contact);
				}
			}

			return birthdayContacts;
		}

		public int FindIndex(Contact contact)
		{
			for (int i = 0; i < Contacts.Count; i++)
			{
				if (Contacts[i] == contact)
				{
					return i;
				}
			}

			return -1;
		}
	}

	
}
