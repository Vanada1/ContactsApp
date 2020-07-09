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
		public List<Contact> Contacts { set; get; }
        //TODO: xml
        public Project()
        { //TODO: вместо двух конструкторов лучше сделать значение для свойства по умолчанию в виде нового списка, а конструкторы убрать
            Contacts = null;
        } //TODO: пустые строки между членами класса
        public Project(ref List<Contact> contacts)
		{
			Contacts = contacts;
		}
	}

	
}
