using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
	/// <summary>
	/// Support of work with strings
	/// </summary>
	public static class StringValidator
	{
		/// <summary>
		/// Throws an error if the line does not fit the range
		/// </summary>
		public static void AssertStringLength(ref string checkedString,
			int maxLength, string name)
		{
			if (checkedString.Length > maxLength || checkedString.Length == 0)
			{
				throw new ArgumentException(name + " is wrong");
			}
		}

        //TODO: грамошибка в названии переменной(done)
        /// <summary>
        /// Returns only digits of a number
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static string GetClearPhoneNumber(string phoneNumber)
		{
			string clearPhoneNumber = "";
			foreach(var i in phoneNumber)
			{
				if(i >= '0' && i<='9')
				{
					clearPhoneNumber += i;
				}
			}
			return clearPhoneNumber;
		}
	}
}
