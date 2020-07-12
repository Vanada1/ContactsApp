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

		[SetUp]
		public void InitPhoneNumber()
		{
			_phoneNumber = new PhoneNumber();
		}
		
		[Test(Description = "Positive test of the Number getter")]
		public void TestNumberGet_CorrectValue()
		{
			var expected = 78005553535;

			_phoneNumber.Number = expected;

			var actual = _phoneNumber.Number;

			Assert.AreEqual(expected, actual, "Getter Number returns incorrect value");
		}

		[TestCase(88005553535, "An exception should occur if the phone Number does not start at 7",
			TestName = "Assignment of the Number starting not with 7")]
		[TestCase(780055535353, "An exception should occur if the phone Number does not have 11 numbers",
			TestName = "Assignment of the Number has not 11 numbers")]
		public void TestNumberSet_ArgumentException(long wrongNumber, string message)
		{

			Assert.Throws<ArgumentException>(
				() => { _phoneNumber.Number = wrongNumber; },
				message);
		}

		[Test(Description = "Positive test of the Number setter")]
		public void TestNumberSet_CorrectValue()
		{
			var expected = 78005553535;
			Assert.DoesNotThrow(
				()=> { _phoneNumber.Number = expected; },
				"Positive test of the Number setter");
		}

		[TestCase(88005553535, "An exception should occur if the phone Number does not start at 7",
			TestName = "Assignment of the Number starting not with 7")]
		[TestCase(780055535353, "An exception should occur if the phone Number does not have 11 numbers",
			TestName = "Assignment of the Number has not 11 numbers")]
		public void TestConstructorPhoneNumber_ArgumentException(long wrongNumber,
			string message)
		{
			Assert.Throws<ArgumentException>(
				() => { _phoneNumber = new PhoneNumber(wrongNumber); },
				message);
		}

		[Test(Description = "Positive test of the Constructor")]
		public void TestConstructorPhoneNumber_CorrectValue()
		{
			var number = 78005553535;
			Assert.DoesNotThrow(
				() => { _phoneNumber = new PhoneNumber(number); },
				"Positive test of the constructor");
		}
	}
}