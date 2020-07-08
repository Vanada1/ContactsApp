using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Class PhoneNumber contains the telephone number of the person
/// </summary>
namespace ContactsApp
{
	/// <summary>
	/// Class containing phone number
	/// </summary>
	public class PhoneNumber
	{
		private long _number;

		/// <summary>
		/// Sets and returns Phone Number values 
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
					throw new ArgumentException("The first digit is not 7");
				}
				else 
				{
					this._number = value;
				}
			}

			get { return this._number; }
		}
		/// <summary>
		/// PhoneNumber constructor
		/// </summary>
		/// <param name="number"></param>
		public PhoneNumber(long number)
		{
			this.Number = number;
		}
	}
}
