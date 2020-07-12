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

		[Test]
		public void TestFileReadWrite()
		{
			var expected = File.ReadAllText(_referencePath);
			if (File.Exists(_path))
			{
				File.Delete(_path);
			}
			File.Create(_path).Close();
			File.WriteAllText(_path, expected);
			if (File.Exists(_path))
			{
				var actual = File.ReadAllText(_path);
				Assert.AreEqual(expected, actual, "Files are not the same");
			}
		}
	}
}