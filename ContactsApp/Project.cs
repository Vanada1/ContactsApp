using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
	/// <summary>
	/// contains all the data about the <see cref="Project"/>
	/// </summary>
	public class Project
	{
		/// <summary>
		/// Contains all <see cref="Contacts"/> at the moment
		/// </summary>
		public List<Contact> Contacts { set; get; } = new List<Contact>();
	}

	
}
