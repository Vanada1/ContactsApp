using System;
using System.Runtime.InteropServices.ComTypes;
using System.IO;
using NUnit.Framework;
using ContactsApp;
using NUnit.Framework.Internal;
using Newtonsoft.Json;

namespace NUnitTestProject
{
	[TestFixture]
	public class TestProjectManager
	{
		/// <summary>
		/// File name for tests
		/// </summary>
		private static readonly string _fileName = "TestFile.notes";

		/// <summary>
		/// Folder for tests
		/// </summary>
		private static readonly string _folder = @"..\bin";

		/// <summary>
		/// All path for tests
		/// </summary>
		private static readonly string _path = _folder + _fileName;

		/// <summary>
		/// Reference path file for tests
		/// </summary>
		private static readonly string _referencePath = @"..\..\..\Reference.notes";

		/// <summary>
		/// Reference path broken file for tests
		/// </summary>
		private static readonly string _referenceBrokenPath = @"..\..\..\ReferenceBroken.notes";

		private static readonly string _nonexistentFile = @"..\..\..\NonexistentFile.notes";

		[TearDown]
		public void DeleteFile()
		{
			if (File.Exists(_path))
			{
				File.Delete(_path);
			}
		}

		[Test(Description = "Read correct file")]
		public void TestFileReadWrite_CorrectData()
		{
			ProjectManager.DefaultPath = _path;
			var expectedString = File.ReadAllText(_referencePath);
			var expected = JsonConvert.DeserializeObject<Project>(
				expectedString);
			if (File.Exists(_path))
			{
				File.Delete(_path);
			}
			File.Create(_path).Close();
			ProjectManager.SaveProject(expected);
			if (File.Exists(_path))
			{
				var actual = ProjectManager.ReadProject();
				var actualString = File.ReadAllText(_path);
				Assert.AreEqual(expectedString, actualString,
					"Values are not the same");
			}
		}

		[Test(Description = "Read broken  file")]
		public void TestFileReadWrite_BrokenData()
		{
			Assert.Throws<JsonReaderException>(() =>
				{
					ProjectManager.DefaultPath = _referenceBrokenPath;
					var project = ProjectManager.ReadProject();
				},
				"Can read the file");
		}

		[Test(Description = "Try to read nonexistent file")]
		public void TestFileReadWrite_NonexistentFile()
		{
			var expected = new Project();

			ProjectManager.DefaultPath = _nonexistentFile;
			var actual = ProjectManager.ReadProject();

			Assert.AreEqual(expected.Contacts, actual.Contacts,
				"Actual project is existent");
		}
	}
}