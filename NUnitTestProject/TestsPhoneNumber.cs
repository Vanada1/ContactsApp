using System;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using ContactsApp;

namespace NUnitTestProject
{
	[TestFixture]
	public class TestsPhoneNumber
	{
		private PhoneNumber _phoneNumber;
		
		[Test(Description = "Positive test of the Number getter")]
		public void TestNumberGet_CorrectValue()
		{
			var expected = 78005553535;
			var phoneNumber = new PhoneNumber(expected);
			var actual = phoneNumber.Number;
			Assert.AreEqual(expected, actual, "Getter Number returns incorrect value");
		}

		[TestCase(88005553535, "An exception should occur if the phone number does not start at 7",
			TestName = "Assignment of a number starting not with 7")]
		[TestCase(880055535353, "An exception should occur if the phone number does not have 11 numbers",
			TestName = "Assignment of a number has not 11 numbers")]
		public void TestNumberSet_ArgumentException(long number, string messege)
		{
			Assert.Throws<ArgumentException>(
				() => { var phoneNumber = new PhoneNumber(number); },
				messege);
		}

		[Test(Description = "Positive test of the Number setter")]
		public void TestNumberSet_CorrectValue()
		{
			var number = 78005553535;
			Assert.DoesNotThrow(
				()=> { var phoneNumber = new PhoneNumber(number); },
				"Positive test of the Number setter");
		}
	}
}