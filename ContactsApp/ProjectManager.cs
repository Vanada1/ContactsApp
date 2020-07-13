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
		/// Read file along the folder
		/// </summary>
		/// <param name="path">Path to the file.
		/// If <paramref name="path"/> is Null then take defult value
		/// </param>
		/// <returns>
		/// Returns all data from file
		/// </returns>
		public static Project ReadProject(string path)
        {
            //TODO: маловероятно, что метод будет вызываться со значением null, в случае строк это не очевидное решение.
            //TODO: сделай открытое свойство DefaultPath, которое будет возвращать значение поля _path. Клиентский код будет забирать дефолтный путь из свойства менеджера и передавать его в метод чтения/записи
            if (path == null)
			{
				path = _path;
			}
			var project = new Project();
			if (!File.Exists(path))
			{
                //TODO: не надо кидать исключения. Эта ситуация может быть разрулена здесь же в методе - надо просто вернуть пустой проект
                throw new AccessViolationException("File not found");
			}
			try
			{
				using (StreamReader file = new StreamReader(
					path, System.Text.Encoding.Default))
				{
					var projectText = file.ReadLine();
					if(projectText == "")
					{
						projectText = null;
					}
                    project = JsonConvert.DeserializeObject<Project>(projectText);
				}
			}
			catch (SerializationException e)
			{
                //TODO: вернуть пустой проект вместо исключения
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
        {
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
                file.Write(JsonConvert.SerializeObject(project)); //TODO: подчисть не нужные пустые строки

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
		}
	}
}
