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
    { //TODO: xml
        private long _number;

		/// <summary>
		/// Sets and returns <see cref="Number"> values 
		/// </summary>
		public long Number
		{
			set
			{
                //TODO: константу правильнее сделать полем класса. Это позволит использовать её, например, в пользовательском интерфейсе для ограничения ввода
                const int MAXDIGITCOUNT = 11;
				string numberString = value.ToString();
				if (numberString.Length != MAXDIGITCOUNT)
				{
					throw new ArgumentException("Invalid phone number");
                } //TODO: else не нужны, если предыдущий if заканчивается return или throw
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
        } //TODO: пустые строки между завершением одного члена класса и началом другого
        //TODO: что-то не то с табуляцией комментария ниже
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
