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

		/// <summary>
		/// Returns a string with an uppercase first letter
		/// </summary>
		/// <param name="variableString"></param>
		/// <returns></returns>
		public static string IncreaseFirstLetter(ref string variableString)
		{
			return (variableString.Substring(0, 1).ToUpper() +
					variableString.Substring(1));
		}

		/// <summary>
		/// Returns only digits of a number
		/// </summary>
		/// <param name="phomeNumber"></param>
		/// <returns></returns>
		public static string GetClearPhoneNumber(string phomeNumber)
		{
			string clearPhoneNumber = "";
			foreach(var i in phomeNumber)
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
