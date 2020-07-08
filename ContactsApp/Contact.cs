using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
	/// <summary>
	/// The <see cref="Contact"> class contains information about the contact: 
	/// <see cref="Name">, <see cref="Surname">, <see cref="PhoneNumber">,
	/// <see cref="Birthday">, <see cref="Email">, <see cref="VkId">
	/// </summary>
	public class Contact : ICloneable
	{
		private const int MAXLETTERCOUNT = 50;
		private const int MAXVKLETTERCOUNT = 15;
		private string _name;
		private string _surname;
		private DateTime _birthday;
		private string _email;
		private string _vkId;

		/// <summary>
		/// Sets and returns <see cref="Name"> values 
		/// </summary>
		public string Name
		{
			set
			{
				StringValidator.AssertStringLength(ref value,
					MAXLETTERCOUNT, "Name");
				this._name = StringValidator.IncreaseFirstLetter(
					ref value);
			}
			get { return _name; }
		}
		/// <summary>
		/// Sets and returns <see cref="Surname"> values
		/// </summary>
		public string Surname
		{
			set
			{
				StringValidator.AssertStringLength(ref value,
					MAXLETTERCOUNT, "Surname");
				this._surname = StringValidator.IncreaseFirstLetter(
					ref value);
			}
			get { return this._surname; }
		}
		/// <summary>
		/// Sets and returns <see cref="Email"> values 
		/// </summary>
		public string Email
		{
			set
			{
				StringValidator.AssertStringLength(ref value,
					MAXLETTERCOUNT, "Email");
				this._email = value;
			}
			get { return this._email; }
		}
		/// <summary>
		/// Sets and returns <see cref="PhoneNumber"> values 
		/// </summary>
		public PhoneNumber PhoneNumber { set; get; }
		/// <summary>
		/// Sets and returns <see cref="VkId"> values 
		/// </summary>
		public string VkId
		{
			set
			{
				StringValidator.AssertStringLength(ref value,
					MAXVKLETTERCOUNT, "VkId");
				this._vkId = value;
			}
			get { return this._vkId; }
		}
		/// <summary>
		/// Sets and returns <see cref="Birthday"> values 
		/// </summary>
		public DateTime Birthday
		{
			set
			{
				if (value.Year < 1900)
				{
					throw new ArgumentException(
						"This year is less than 1900");
				}
				else if (value > DateTime.Today)
				{
					throw new ArgumentException(
						"This date is more than today");
				}
				else
				{
					this._birthday = value;
				}
			}
			get { return this._birthday; }
		}
		/// <summary>
		/// <see cref="Contact"> object constructor
		/// </summary>
		/// <param name="surname"><see cref="Surname"></param>
		/// <param name="name"><see cref="Name"/></param>
		/// <param name="phoneNumber"><see cref="PhoneNumber"/></param>
		/// <param name="birthday"><see cref="Birthday"/></param>
		/// <param name="email"><see cref="Email"/></param>
		/// <param name="vkId"><see cref="VkId"/></param>
		public Contact(string name, string surname,
			 PhoneNumber phoneNumber, DateTime birthday,
			 string email, string vkId)
		{
			this.Surname = surname;
			this.Name = name;
			this.PhoneNumber = phoneNumber;
			this.Birthday = birthday;
			this.Email = email;
			this.VkId = vkId;
		}
		/// <summary>
		/// Creates a <see cref="Contact"/> clone
		/// </summary>
		/// <returns>Returns a clone of the <see cref="Contact"/> object</returns>
		public object Clone()
		{
			return new Contact(this.Name, this.Surname,
				 this.PhoneNumber,  this.Birthday,  this.Email,
				 this.VkId);
		}
	}
}