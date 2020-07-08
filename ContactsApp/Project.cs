using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
	public class Project
	{
		public List<Contact> Contacts { set; get; }

		public Project()
		{
			Contacts = null;
		}
		public Project(ref List<Contact> contacts)
		{
			Contacts = contacts;
		}
	}

	
}
