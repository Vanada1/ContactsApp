using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
	/// <summary>
	/// Class <see cref="PhoneNumber"> contains the telephone number of the person
	/// </summary>
	public class PhoneNumber
	{ //TODO: xml(doen)
		/// <summary>
		/// Number phone
		/// </summary>
		private long _number;
		/// <summary>
		/// Max count of <see cref="Number"/>
		/// </summary>
		public const int MAXDIGITCOUNT = 11;

		/// <summary>
		/// Sets and returns <see cref="Number"> values 
		/// </summary>
		public long Number
		{
			get 
			{
				return this._number;
			}
			set
			{
				//TODO: константу правильнее сделать полем класса. Это позволит использовать её, например, в пользовательском интерфейсе для ограничения ввода(done)
				string numberString = value.ToString();
				if (numberString.Length != MAXDIGITCOUNT)
				{
					throw new ArgumentException("Invalid phone number");
				} //TODO: else не нужны, если предыдущий if заканчивается return или throw(done)
				if(numberString[0] != '7')
				{
					throw new ArgumentException(
						"The first digit is not 7");
				}
				this._number = value;
			}
		}

		//TODO: пустые строки между завершением одного члена класса и началом другого(done)
		//TODO: что-то не то с табуляцией комментария ниже(done)
		/// <summary>
		/// <see cref="PhoneNumber"/> constructor
		/// </summary>
		/// <param name="number">
		/// Gets a phone number
		/// </param>
		public PhoneNumber(long number)
		{
			this.Number = number;
		}
	}
}
