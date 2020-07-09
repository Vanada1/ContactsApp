using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{ //TODO: xml
    public static class ProjectManager
    { //TODO: xml
        //TODO: я же вчера говорил, что путь  должен быть не до Моих документов, а до папки AppData с подпапкой для программы
        private const string PATH = @"..\My Documents\";
		private const string FILENAME = "ContactsApp.notes";
		/// <summary>
		/// Append new contact into the file
		/// </summary>
		/// <param name="contact"> Contact to write to the file </param>
		public static void AppendNewContact(ref Contact contact)
        { //TODO: этот метод не нужен.
            if (!Directory.Exists(PATH))
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
		/// <returns>Returns all contacts from file</returns>
		public static List<Contact> ReadFile()
        { //TODO: я же вчера говорил, что в метод загрузки надо передавать путь
            //TODO: метод должен возвращать обьект проекта, а не список контактов
            //TODO: я вчера говорил, что в классе должна быть проверка на существование файла, а также обработка ситуации, когда файл не может десериализоваться
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
		/// <param name="contacts">
		/// Contacts list to write to the file
		/// </param>
		public static void OverwriteFile(List<Contact> contacts)
        { //TODO: не перезапись, а просто СохранитьПроект()
            //TODO: в метод надо передавать путь
            //TODO: в метод надо передавать объект проекта, вместо списка контактов
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
		/// <param name="deletedContact">
		/// Gets a delete contact
		/// </param>
		public static void RemoveContact(Contact deletedContact)
        { //TODO: этот метод не нужен
            string deletedString = JsonConvert.SerializeObject(deletedContact);
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
