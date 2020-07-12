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
		/// The path to the file
		/// </summary>
		private static readonly string _path = _folder + _fileName;

		/// <summary>
		/// Read file along the path
		/// </summary>
		/// <param name="path">Path to the file.
		/// If <paramref name="path"/> is Null then take defult value
		/// </param>
		/// <returns>
		/// Returns all data from file
		/// </returns>
		public static Project ReadProject(string path)
        {
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
					var projectText = file.ReadLine();
					if(projectText == "")
					{
						projectText = null;
					}
					//TODO: зачем считывать по отдельным строкам? записывай и считывай весь Prokect целиком(done)
					project = JsonConvert.DeserializeObject<Project>(projectText);
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
        {
            //TODO: SaveProject, но ReadProject - сделать именование(done)
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
				//TODO: записывай проект целиком, а не по одному контакт(Done)
				file.Write(JsonConvert.SerializeObject(project));
               
			}
			
		}

        //TODO: грамошибка(done)
        /// <summary>
        /// Creates file along path
        /// </summary>
        /// <param name="path">File location</param>
        /// <param name="fileName">File name</param>
        public static void CreatePath(string path, string fileName)
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
