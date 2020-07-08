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
		private const string PATH = @"..\My Documents\";
		private const string FILENAME = "ContactsApp.notes";
		/// <summary>
		/// Append new contact into the file
		/// </summary>
		/// <param name="contact"></param>
		public static void AppendNewContact(ref Contact contact)
		{
			if(!Directory.Exists(PATH))
			{
				Directory.CreateDirectory(PATH);
			}
			if(!File.Exists(PATH + FILENAME))
			{
				File.Create(FILENAME);
			}
			using (StreamWriter file = new StreamWriter(PATH + FILENAME,
				true, System.Text.Encoding.Default))
			{
				file.WriteLine(JsonConvert.SerializeObject(contact));
			}
		}

		/// <summary>
		/// Read all contacts from file
		/// </summary>
		/// <returns></returns>
		public static List<Contact> ReadFile()
		{
			List<Contact> contacts = new List<Contact>();
			using (StreamReader file = new StreamReader(
				PATH + FILENAME, System.Text.Encoding.Default))
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
		/// <param name="contacts"></param>
		public static void OverwriteFile(List<Contact> contacts)
		{
			if (!Directory.Exists(PATH))
			{
				Directory.CreateDirectory(PATH);
			}
			if (!File.Exists(PATH + FILENAME))
			{
				File.Create(FILENAME);
			}
			using (StreamWriter file = new StreamWriter(
				PATH + FILENAME, false, System.Text.Encoding.Default))
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
		/// <param name="deletedString"></param>
		public static void RemoveContact(ref string deletedString)
		{
			using (var reader = new StreamReader(PATH + FILENAME))
			{
				using (var writer = new StreamWriter(PATH + FILENAME))
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

		}
	}
}
