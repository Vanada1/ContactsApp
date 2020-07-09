using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ContactsApp
{ //TODO: xml(done)
	/// <summary>
	/// Class for working with files
	/// </summary>
	public static class ProjectManager
    { //TODO: xml(done)
	  //TODO: я же вчера говорил, что путь  должен быть не до Моих документов, а до папки AppData с подпапкой для программы(done)
		/// <summary>
		/// File name
		/// </summary>
		private static readonly string _fileName = "ContactsApp.notes";
		/// <summary>
		/// Folder for file
		/// </summary>
		private static readonly string _folder = Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData) +
			"\\ContactsApp\\";

		/// <summary>
		/// The path to the file
		/// </summary>
		private static readonly string _path = _folder + _fileName;

		/// <summary>
		/// Append new contact into the file
		/// </summary>
		/// <param name="contact"> Contact to write to the file </param>
		/// <param name="path">Path to the file.
		/// If <paramref name="path"/> is Null then take defult value
		/// </param>
		public static void AppendNewContact(ref Contact contact, string path)
		{
			if (path == null)
			{
				path = _path;
			}
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			using (StreamWriter file = new StreamWriter(_path,
				true, System.Text.Encoding.Default))
			{
				file.WriteLine(JsonConvert.SerializeObject(contact));
			}
		}

		/// <summary>
		/// Read file along the path
		/// </summary>
		/// <param name="path">Path to the file.
		/// If <paramref name="path"/> is Null then take defult value
		/// </param>
		/// <returns>
		/// Returns all data from file
		/// </returns>
		public static Project ReadFile(string path)
        { //TODO: я же вчера говорил, что в метод загрузки надо передавать путь(done)
		  //TODO: метод должен возвращать обьект проекта, а не список контактов(done)
		  //TODO: я вчера говорил, что в классе должна быть проверка на существование файла, а также обработка ситуации, когда файл не может десериализоваться(done)
			if(path == null)
			{
				path = _path;
			}
			var project = new Project();
			if (!File.Exists(path))
			{
				throw new AccessViolationException("File not found");
			}
			try
			{
				using (StreamReader file = new StreamReader(
					path, System.Text.Encoding.Default))
				{

					string line;
					while ((line = file.ReadLine()) != null)
					{
						project.Contacts.Add(
							JsonConvert.DeserializeObject<Contact>(line));
					}
				}
			}
			catch (SerializationException e)
			{
				throw new AccessViolationException(e.Message);
			}
			return project;
		}

		/// <summary>
		/// Save file
		/// </summary>
		/// <param name="project">
		/// All data of app
		/// </param>
		/// <param name="path">Path to the file.
		/// If <paramref name="path"/> is Null then take defult value
		/// </param>
		public static void SaveProject(Project project, string path)
        { //TODO: не перезапись, а просто СохранитьПроект(done)
		  //TODO: в метод надо передавать путь(done)
		  //TODO: в метод надо передавать объект проекта, вместо списка контактов(done)
			if (path == null)
			{
				path = _path;
			}
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			using (StreamWriter file = new StreamWriter(
				path, false, System.Text.Encoding.Default))
			{
				foreach (Contact contact in project.Contacts)
				{
					file.WriteLine(JsonConvert.SerializeObject(contact));
				}
			}
			
		}
		/// <summary>
		/// Remove element from file
		/// </summary>
		/// <param name="deletedContact"></param>
		/// <param name="path">Path to the file.
		/// If <paramref name="path"/> is Null then take defult value
		/// </param>
		public static void RemoveContact(Contact deletedContact, string path)
		{
			if (path == null)
			{
				path = _path;
			}
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
		/// Creates file along path
		/// </summary>
		/// <param name="path">File location</param>
		/// <param name="fileName">File name</param>
		public static void CreatPath(string path, string fileName)
		{
			if (path == null)
			{
				path = _folder;
			}
			if (fileName == null)
			{
				fileName = _fileName;
			}
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (!File.Exists(path + fileName))
			{
				File.Create(path + fileName).Close();
			}
		}
	}
}
