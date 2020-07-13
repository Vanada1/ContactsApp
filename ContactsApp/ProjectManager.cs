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
{
	/// <summary>
	/// Class for working with files
	/// </summary>
	public static class ProjectManager
    {
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
		/// The folder to the file
		/// </summary>
		private static readonly string _path = _folder + _fileName;

		/// <summary>
		/// Default path for save and read of the file
		/// </summary>
		public static string DefaultPath { get; set; } = _path;

		/// <summary>
		/// Read file along the folder
		/// </summary>
		/// <param name="path">Path to the file.
		/// If <paramref name="path"/> is Null then take defult value
		/// </param>
		/// <returns>
		/// Returns all data from file
		/// </returns>
		public static Project ReadProject()
        {
            //TODO: маловероятно, что метод будет вызываться со значением null, в случае строк это не очевидное решение.(done)
            //TODO: сделай открытое свойство DefaultPath, которое будет возвращать значение поля _path. Клиентский код будет забирать дефолтный путь из свойства менеджера и передавать его в метод чтения/записи
            var project = new Project();
            if (File.Exists(DefaultPath))
            {
	            try
	            {
		            using (StreamReader file = new StreamReader(
			            DefaultPath, System.Text.Encoding.Default))
		            {
			            var projectText = file.ReadLine();
			            if (projectText == "")
			            {
				            projectText = null;
			            }

			            project = JsonConvert.DeserializeObject<Project>(projectText);
		            }
	            }
	            catch (SerializationException e)
	            {
		            //TODO: вернуть пустой проект вместо исключения (done)
		            return project;
	            }
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
		public static void SaveProject(Project project)
        {
			if (!File.Exists(DefaultPath))
			{
				File.Create(DefaultPath).Close();
			}
			using (StreamWriter file = new StreamWriter(
				DefaultPath, false, System.Text.Encoding.Default))
			{
                file.Write(JsonConvert.SerializeObject(project)); //TODO: подчисть не нужные пустые строки (done)
			}
        }

        /// <summary>
        /// Creates file along folder
        /// </summary>
        /// <param name="folder">File location</param>
        /// <param name="fileName">File name</param>
        public static void CreatePath(string folder, string fileName)
		{
			if (folder == null)
			{
				folder = _folder;
			}
			if (fileName == null)
			{
				fileName = _fileName;
			}
			if (!Directory.Exists(folder))
			{
				Directory.CreateDirectory(folder);
			}
			if (!File.Exists(folder + fileName))
			{
				File.Create(folder + fileName).Close();
			}

			DefaultPath = folder + fileName;
		}
	}
}
