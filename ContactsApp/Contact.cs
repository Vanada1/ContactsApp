using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
	/// <summary>
	/// The Contact class contains information about the contact: 
	/// First name, Last name, Phone number, Birthday, Email, vkID
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
		/// Sets and returns FirstName values 
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
		/// Sets and returns LastName values
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
		/// Sets and returns Email values 
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
		/// Sets and returns Phone Number values 
		/// </summary>
		public PhoneNumber PhoneNumber { set; get; }

		/// <summary>
		/// Sets and returns VKid values 
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
		/// Sets and returns Birthday values 
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
		/// Contact object constructor
		/// </summary>
		/// <param name="surname"></param>
		/// <param name="name"></param>
		/// <param name="phoneNumber"></param>
		/// <param name="birthday"></param>
		/// <param name="email"></param>
		/// <param name="vkId"></param>
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
		/// Returns a clone of the Contact object
		/// </summary>
		/// <returns></returns>
		public object Clone()
		{
			return new Contact(this.Name, this.Surname,
				 this.PhoneNumber,  this.Birthday,  this.Email,
				 this.VkId);
		}
	}
}