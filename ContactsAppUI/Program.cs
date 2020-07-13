using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//string firstName = "sergey";
			//string lastName = "artemov";
			//PhoneNumber phoneNumber = new PhoneNumber("78005553535");
			//DateTime birthday = new DateTime(2000, 12, 12);
			//string email = "superg@mail.ru";
			//string vkId = "ya123";
			//Contact contact = new Contact(firstName, lastName,
			//	phoneNumber, birthday, email, vkId);

			//ProjectManager.AppendNewContact(ref contact);
			//ProjectManager.AppendNewContact(ref contact);
			//ProjectManager.AppendNewContact(ref contact);
			//List<Contact> contacts = ProjectManager.ReadFile();
			//foreach (Contact i in contacts)
			//{
			//	Console.WriteLine(i.Surname + ' ' + i.Name);
			//}

			//string firstName1 = "dmity";
			//string lastName1 = "ivan";
			//PhoneNumber phoneNumber1 = new PhoneNumber("78005553535");
			//DateTime birthday1 = new DateTime(2000, 12, 12);
			//string email1 = "superg@mail.ru";
			//string vkId1 = "ya123";
			//Contact contact1 = new Contact(firstName1, lastName1,
			//	 phoneNumber1, birthday1, email1, vkId1);
			//List<Contact> contacts1 = new List<Contact>();
			//contacts1.Add(contact1);
			//contacts1.Add(contact1);
			//contacts1.Add(contact1);
			//contacts1.Add(contact1);
			//ProjectManager.OverwriteFile(contacts1);
			//contacts = ProjectManager.ReadFile();
			//Console.WriteLine("New result");
			//foreach (Contact i in contacts)
			//{
			//	Console.WriteLine(i.LastName + ' ' + i.FirstName);
			//}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);
			Application.Run(new MainForm());
		}
	}
}
