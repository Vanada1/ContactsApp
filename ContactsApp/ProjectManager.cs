using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
	public static class ProjectManager
	{
		private static readonly string _path = @"..\My Documents\ContactsApp.notes";
		/// <summary>
		/// Append new contact into the file
		/// </summary>
		/// <param name="contact"> Contact to write to the file </param>
		public static void AppendNewContact(ref Contact contact)
		{
			if(!File.Exists(_path))
			{
				File.Create(_path);
			}
			using (StreamWriter file = new StreamWriter(_path,
				true, System.Text.Encoding.Default))
			{
				file.WriteLine(JsonConvert.SerializeObject(contact));
			}
		}

		/// <summary>
		/// Read all contacts from file
		/// </summary>
		/// <returns>Returns all contacts from file</returns>
		public static List<Contact> ReadFile()
		{
			if (!File.Exists(_path))
			{
				File.Create(_path).Close();
			}
			List<Contact> contacts = new List<Contact>();
			using (StreamReader file = new StreamReader(
				_path, System.Text.Encoding.Default))
			{
				string line;
				while ((line = file.ReadLine()) != null)
				{
					contacts.Add(
						JsonConvert.DeserializeObject<Contact>(line));
				}
			}
			return contacts;
		}

		/// <summary>
		/// Overwrite file
		/// </summary>
		/// <param name="contacts">
		/// Contacts list to write to the file
		/// </param>
		public static void OverwriteFile(List<Contact> contacts)
		{
			if (!File.Exists(_path))
			{
				File.Create(_path);
			}
			using (StreamWriter file = new StreamWriter(
				_path, false, System.Text.Encoding.Default))
			{
				foreach (Contact contact in contacts)
				{
					file.WriteLine(JsonConvert.SerializeObject(contact));
				}
			}
			
		}

		/// <summary>
		/// Remove selected contact from file
		/// </summary>
		/// <param name="deletedContact">
		/// Gets a delete contact
		/// </param>
		public static void RemoveContact(Contact deletedContact)
		{
			if (!File.Exists(_path))
			{
				throw new ArgumentException("None file");
			}
			string deletedString = JsonConvert.SerializeObject(deletedContact);
			string tempFile = Path.GetTempFileName();
			using (var reader = new StreamReader(_path))
			{
				using (var writer = new StreamWriter(tempFile))
				{
					string line;
					while ((line = reader.ReadLine()) != null)
					{
						if (String.Compare(line, deletedString) == 0)
						{ 
							continue; 
						}
						writer.WriteLine(line);
					}
				}
			}
			File.Delete(_path);
			File.Move(tempFile, _path);

		}

		/// <summary>
		/// Searches for the specified contact
		/// </summary>
		/// <param name="searchedContact"></param>
		/// <returns>
		/// Returns the number of duplicate contacts.
		/// Returns Zero if <see cref="Contact"> is not found.
		/// </returns>
		public static int SearchContact(Contact searchedContact)
		{
			int contactsCount = 0;
			string jsonSearchedContact = JsonConvert.SerializeObject(
				searchedContact);
			using (var reader = new StreamReader(_path))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					if (String.Compare(line, jsonSearchedContact) == 0)
					{
						contactsCount++;
					}
				}
			}
			return contactsCount;
		}
	}
}
