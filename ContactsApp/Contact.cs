using System;
using System.Collections.Generic;
using System.Globalization;
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
    { //TODO: xml у каждого члена класса(done)
		/// <summary>
		/// Max count of letters for <see cref="Name"/>, 
		/// <see cref="Surname"/>, <see cref="Email"/>
		/// </summary>
        private const int MAXLETTERCOUNT = 50;
		/// <summary>
		/// Max count of letters for <see cref="VkId"/>
		/// </summary>
		private const int MAXVKLETTERCOUNT = 15;
		/// <summary>
		/// Contact <see cref="Name"/>
		/// </summary>
		private string _name;
		/// <summary>
		/// Contact <see cref="Surname"/>
		/// </summary>
		private string _surname;
		/// <summary>
		/// Contact <see cref="Birthday"/>
		/// </summary>
		private DateTime _birthday;
		/// <summary>
		/// Contact <see cref="Email"/>
		/// </summary>
		private string _email;
		/// <summary>
		/// Contact <see cref="VkId"/>
		/// </summary>
		private string _vkId;

		/// <summary>
		/// Sets and returns <see cref="Name"> values 
		/// </summary>
		public string Name
		{
			get 
			{
				return _name; 
			}
			set
			{
				StringValidator.AssertStringLength(ref value,
					MAXLETTERCOUNT, nameof(Name)); //TODO: интересно, что ты увечил первую букву, но не стал уменьшать остальные(Done)
												   //TODO: здесь и далее, вместо передачи строки "Name", можно передавать nameof(Name). nameof() метод, который получает строку для членов классов, переменных, классов и т.д. (done)
				this._name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
			}
			
		}

		/// <summary>
		/// Sets and returns <see cref="Surname"> values
		/// </summary>
		public string Surname
		{
			get 
			{ 
				return this._surname; 
			}
			set
			{
				StringValidator.AssertStringLength(ref value,
					MAXLETTERCOUNT, nameof(Surname));
				this._surname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value); ;
			}
		}

		/// <summary>
		/// Sets and returns <see cref="Email"> values 
		/// </summary>
		public string Email
		{
			get 
			{ 
				return this._email;
			}
			set
			{
				StringValidator.AssertStringLength(ref value,
					MAXLETTERCOUNT, nameof(Email));
				this._email = value;
			}
			
		}

		/// <summary>
		/// Sets and returns <see cref="PhoneNumber"> values 
		/// </summary>
		public PhoneNumber PhoneNumber { get; set; }

		/// <summary>
		/// Sets and returns <see cref="VkId"> values 
		/// </summary>
		public string VkId
		{
			get
			{ 
				return this._vkId;
			}
			set
			{
				StringValidator.AssertStringLength(ref value,
					MAXVKLETTERCOUNT, nameof(VkId));
				this._vkId = value;
			}
			
		}

		/// <summary>
		/// Sets and returns <see cref="Birthday"> values 
		/// </summary>
		public DateTime Birthday
		{
			get
			{
				return this._birthday;
			}
			set
			{
				if (value.Year < 1900)
				{
					throw new ArgumentException(
						"This year is less than 1900");
                } //TODO: else не нужны //TODO: вместо Today лучше использовать Now(done)
                if (value > DateTime.Now)
				{
					throw new ArgumentException(
						"This date is more than today");
				}
				this._birthday = value;
            } //TODO: если в set скобки перенесены на следующие строки, то в get надо тоже //TODO: обычно сначала идет get, потом set(done)
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
		/// <returns>Returns a clone of the <see cref="Contact"/>
		/// object</returns>
		public object Clone()
        { //TODO: PhoneNumber ссылочный объект. Один и тот же объект хранится в обоих экземплярах контакта. В итоге, если у тебя  в склонированном контакте поменяется номер телефона, то он поменяется в обоих контактах.(done)
            return new Contact(this.Name, this.Surname,
				 new PhoneNumber(this.PhoneNumber.Number),  
				 this.Birthday,  this.Email, this.VkId);
		}
	}
}