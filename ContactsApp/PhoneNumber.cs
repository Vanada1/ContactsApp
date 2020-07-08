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
	{
		private long _number;

		/// <summary>
		/// Sets and returns <see cref="Number"> values 
		/// </summary>
		public long Number
		{
			set
			{
				const int MAXDIGITCOUNT = 11;
				string numberString = value.ToString();
				if (numberString.Length != MAXDIGITCOUNT)
				{
					throw new ArgumentException("Invalid phone number");
				}
				else if(numberString[0] != '7')
				{
					throw new ArgumentException(
						"The first digit is not 7");
				}
				else 
				{
					this._number = value;
				}
			}

			get { return this._number; }
		}
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
