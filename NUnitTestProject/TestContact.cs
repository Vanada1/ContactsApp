using System;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using ContactsApp;
using NUnit.Framework.Internal;

namespace NUnitTestProject
{
	[TestFixture]
	class TestContact
	{
		private Contact createEmptyContact()
		{
			return new Contact(" ", " ", new PhoneNumber(),
				DateTime.Now, " ", " ");
		}

		//Test Name start
		[Test(Description = "Positive test of the Name getter")]
		public void TestNameGet_CorrectValue()
		{
			var expected = "Name";

			var contact = createEmptyContact();
			contact.Name = expected;

			var actual = contact.Name;

			Assert.AreEqual(expected, actual, "Getter Name returns incorrect value");
		}

		[TestCase("", "An exception should occur if the name is empty",
			TestName = "Assignment of the Name is empty")]
		[TestCase("NameNameNameNameNameNameNameNameNameNameNameNameNameName",
			"An exception should occur if the Name is large of max value",
			TestName = "Assignment of the Name is large of max value")]
		public void TestNameSet_ArgumentException(string wrongValue,
			string message)
		{
			var contact = createEmptyContact();
			Assert.Throws<ArgumentException>(
				() => { contact.Name = wrongValue; },
				message);
		}

		[Test(Description = "Positive test of the Name setter")]
		public void TestNameSet_CorrectValue()
		{
			var contact = createEmptyContact();
			var name = "Name";
			Assert.DoesNotThrow(
				() => { contact.Name = name; },
				"Positive test of the Name setter");
		}
		//Test Name end

		//Test Surname start
		[Test(Description = "Positive test of the Surname getter")]
		public void TestSurnameGet_CorrectValue()
		{
			var expected = "Surname";

			var contact = createEmptyContact();
			contact.Surname = expected;

			var actual = contact.Surname;

			Assert.AreEqual(expected, actual, "Getter Surname returns incorrect value");
		}

		[TestCase("", "An exception should occur if the Surname is empty",
			TestName = "Assignment of the Surname is empty")]
		[TestCase("SurnameSurnameSurnameSurnameSurnameSurnameSurnameSurname",
			"An exception should occur if the Surname is large of max value",
			TestName = "Assignment of the Surname is large of max value")]
		public void TestSurnameSet_ArgumentException(string wrongValue, 
			string message)
		{
			var contact = createEmptyContact();
			Assert.Throws<ArgumentException>(
				() => { contact.Surname = wrongValue; },
				message);
		}

		[Test(Description = "Positive test of the Surname setter")]
		public void TestSurnameSet_CorrectValue()
		{
			var contact = createEmptyContact();
			var surname = "Surname";
			Assert.DoesNotThrow(
				() => { contact.Surname = surname; },
				"Positive test of the Surname setter");
		}
		//Test Surname End

		//Test Email start
		[Test(Description = "Positive test of the Email getter")]
		public void TestEmailGet_CorrectValue()
		{
			var expected = "Email";

			var contact = createEmptyContact();
			contact.Email = expected;

			var actual = contact.Email;

			Assert.AreEqual(expected, actual, "Getter Email returns incorrect value");
		}

		[TestCase("", "An exception should occur if the Email is empty",
			TestName = "Assignment of the Email is empty")]
		[TestCase("EmailEmailEmailEmailEmailEmailEmailEmailEmailEmailEmailEmail",
			"An exception should occur if the Email is large of max value",
			TestName = "Assignment of the Email is large of max value")]
		public void TestEmailSet_ArgumentException(string wrongValue, 
			string message)
		{
			var contact = createEmptyContact();
			Assert.Throws<ArgumentException>(
				() => { contact.Email = wrongValue; },
				message);
		}

		[Test(Description = "Positive test of the Email setter")]
		public void TestEmailSet_CorrectValue()
		{
			var contact = createEmptyContact();
			var email = "Email";
			Assert.DoesNotThrow(
				() => { contact.Email = email; },
				"Positive test of the Email setter");
		}
		//Test Email end

		//Test VkID start
		[Test(Description = "Positive test of the VKID getter")]
		public void TestVKIDGet_CorrectValue()
		{
			var expected = "VKID";

			var contact = createEmptyContact();
			contact.VkId = expected;

			var actual = contact.VkId;

			Assert.AreEqual(expected, actual, "Getter VKID returns incorrect value");
		}

		[TestCase("", "An exception should occur if the VKID is empty",
			TestName = "Assignment of the VKID is empty")]
		[TestCase("1234567890qwertyui",
			"An exception should occur if the VKID is large of max value",
			TestName = "Assignment of the VKID is large of max value")]
		public void TestVKIDSet_ArgumentException(string wrongValue,
			string message)
		{
			var contact = createEmptyContact();
			Assert.Throws<ArgumentException>(
				() => { contact.VkId = wrongValue; },
				message);
		}

		[Test(Description = "Positive test of the VKID setter")]
		public void TestVKIDSet_CorrectValue()
		{
			var contact = createEmptyContact();
			var vkid = "VKID";
			Assert.DoesNotThrow(
				() => { contact.Name = vkid; },
				"Positive test of the VKID setter");
		}
		//Test VkId end

		//Test PhoneNumber start
		[Test(Description = "Positive test of the PhoneNumber getter")]
		public void TestPhoneNumberGet_CorrectValue()
		{
			var expected = new PhoneNumber(78005553535);

			var contact = createEmptyContact();
			contact.PhoneNumber = expected;

			var actual = contact.PhoneNumber;

			Assert.AreEqual(expected, actual, "Getter PhoneNumber returns incorrect value");
		}

		[TestCase(88005553535, "An exception should occur if the phone Number does not start at 7",
			TestName = "Assignment of the Number starting not with 7")]
		[TestCase(880055535353, "An exception should occur if the phone Number does not have 11 numbers",
			TestName = "Assignment of the Number has not 11 numbers")]
		public void TestPhoneNumber_ArgumentException(long wrongNumber,
			string message)
		{
			var contact = createEmptyContact();
			Assert.Throws<ArgumentException>(
				() => { contact.PhoneNumber = new PhoneNumber(wrongNumber); },
				message);
		}

		[Test(Description = "Positive test of the PhoneNumber setter")]
		public void TestPhoneNumberSet_CorrectValue()
		{
			var contact = createEmptyContact();
			var phoneNumber = new PhoneNumber(78005553535);
			Assert.DoesNotThrow(
				() => { contact.PhoneNumber = phoneNumber; },
				"Positive test of the PhoneNumber setter");
		}
		//Test PhoneNumber end

		//Test Birthday start
		[Test(Description = "Positive test of the Birthday getter")]
		public void TestBirthdayGet_CorrectValue()
		{
			var expected = new DateTime(2000,12,12);

			var contact = createEmptyContact();
			contact.Birthday = expected;

			var actual = contact.Birthday;

			Assert.AreEqual(expected, actual, "Getter Birthday returns incorrect value");
		}

		[TestCase(1800, 1, 1,
			"An exception should occur if the Birthday is less then min value",
			TestName = "Assignment of the Birthday is less then min value")]
		[TestCase(3000, 1, 1,
			"An exception should occur if the Birthday is large of max value",
			TestName = "Assignment of the Birthday in the future")]
		public void TestBirthdaySet_ArgumentException(int year, int month,
			int day, string message)
		{
			var contact = createEmptyContact();
			var wrongValue = new DateTime(year, month, day);
			Assert.Throws<ArgumentException>(
				() => { contact.Birthday = wrongValue; },
				message);
		}

		[Test(Description = "Positive test of the Birthday setter")]
		public void TestBirthdaySet_CorrectValue()
		{
			var contact = createEmptyContact();
			var dateTime = new DateTime(2000, 12, 21);
			Assert.DoesNotThrow(
				() => { contact.Birthday = dateTime; },
				"Positive test of the PhoneNumber setter");
		}
		//Test Birthday end

		//Test Constructor start
		[TestCase("", "An exception should occur if the name is empty in constructor",
			TestName = "Assignment constructor of the Name is empty")]
		[TestCase("NameNameNameNameNameNameNameNameNameNameNameNameNameName",
			"An exception should occur if the Name is large of max value in constructor",
			TestName = "Assignment constructor of the Name is large of max value")]
		public void TestConstructorContactName_ArgumentException(
			string wrongValue, string message)
		{
			Assert.Throws<ArgumentException>(
				() =>
				{
					var contact = new Contact(wrongValue, "Surname",
						new PhoneNumber(78005553535), 
						new DateTime(2000, 12, 12), 
						"Email", "id1200");
				},
				message);
		}

		[Test(Description = "Positive test of the Constructor Name")]
		public void TestConstructorContactName_CorrectValue()
		{
			var name = "Name";
			Assert.DoesNotThrow(
				() => {
					var contact = new Contact(name, "Surname",
						new PhoneNumber(78005553535),
						new DateTime(2000, 12, 12),
						"Email", "id1200"); },
				"Positive test of the constructor");
		}

		[TestCase("", "An exception should occur if the Surname is empty in constructor",
			TestName = "Assignment constructor of the Surname is empty")]
		[TestCase("SurnameSurnameSurnameSurnameSurnameSurnameSurnameSurname",
			"An exception should occur if the Surname is large of max value in constructor",
			TestName = "Assignment constructor of the Surname is large of max value")]
		public void TestConstructorContactSurname_ArgumentException(
			string wrongValue, string message)
		{
			Assert.Throws<ArgumentException>(
				() =>
				{
					var contact = new Contact("name", wrongValue,
						new PhoneNumber(78005553535),
						new DateTime(2000, 12, 12),
						"Email", "id1200");
				},
				message);
		}

		[Test(Description = "Positive test of the Constructor Surname")]
		public void TestConstructorContactSurname_CorrectValue()
		{
			var surname = "Surname";
			Assert.DoesNotThrow(
				() => {
					var contact = new Contact("Name", surname,
						new PhoneNumber(78005553535),
						new DateTime(2000, 12, 12),
						"Email", "id1200");
				},
				"Positive test of the constructor");
		}

		[TestCase(88005553535, "An exception should occur if the phone Number does not start at 7 in constructor",
			TestName = "Assignment constructor of the Number starting not with 7")]
		[TestCase(780055535353, "An exception should occur if the phone Number does not have 11 numbers in constructor",
			TestName = "Assignment constructor of the Number has not 11 numbers")]
		public void TestConstructorContactPhoneNumber_ArgumentException(
			long wrongNumber, string message)
		{
			Assert.Throws<ArgumentException>(
				() => 
				{ 
					var contact =new Contact("Name", "Surname",
						new PhoneNumber(wrongNumber),
					new DateTime(2000, 12, 12),
					"Email", "id1200");
				},
				message);
		}

		[Test(Description = "Positive test of the Constructor PhoneNumber")]
		public void TestConstructorContactPhoneNumber_CorrectValue()
		{
			var phoneNumber = new PhoneNumber(78005553535);
			Assert.DoesNotThrow(
				() => 
				{
					var contact = new Contact("Name", "Surname",
						phoneNumber, 
						new DateTime(2000, 12, 12),
						"Email", "id1200");
				},
				"Positive test of the Constructor");
		}

		[TestCase(1800, 1, 1,
			"An exception should occur if the Birthday is less then min value in constructor",
			TestName = "Assignment constructor of the Birthday is less then min value")]
		[TestCase(3000, 1, 1,
			"An exception should occur if the Birthday is large of max value in constructor",
			TestName = "Assignment constructor of the Birthday in the future")]
		public void TestConstructorContactBirthday_ArgumentException(int year,
			int month, int day, string message)
		{
			var wrongValue = new DateTime(year, month, day);
			Assert.Throws<ArgumentException>(
				() => 
				{
					var contact = new Contact("Name", "Surname",
						new PhoneNumber(78005553535),
						wrongValue, "Email", "id1200");
				},
				message);
		}

		[Test(Description = "Positive test of the Constructor Birthday")]
		public void TestConstructorContactBirthday_CorrectValue()
		{
			var dateTime = new DateTime(2000, 12, 21);
			Assert.DoesNotThrow(
				() =>
				{
					var contact = new Contact("Name", "Surname",
						new PhoneNumber(78005553535),
						dateTime, "Email", "id1200");
				},
				"Positive test of the PhoneNumber setter");
		}

		[TestCase("", "An exception should occur if the Email is empty in constructor",
			TestName = "Assignment constructor of the Email is empty")]
		[TestCase("EmailEmailEmailEmailEmailEmailEmailEmailEmailEmailEmailEmail",
			"An exception should occur if the Email is large of max value in constructor",
			TestName = "Assignment constructor of the Email is large of max value")]
		public void TestConstructorContactEmail_ArgumentException(
			string wrongValue, string message)
		{

			Assert.Throws<ArgumentException>(
				() => {
					var contact = new Contact("Name", "Surname",
						new PhoneNumber(78005553535),
						new DateTime(2000,12, 12),
						wrongValue, "id1200");
				},
				message);
		}

		[Test(Description = "Positive test of the Constructor Email")]
		public void TestConstructorContactEmail_CorrectValue()
		{
			var email = "Email";
			Assert.DoesNotThrow(
				() => 
				{
					var contact = new Contact("Name", "Surname",
						new PhoneNumber(78005553535),
						new DateTime(2000, 12, 12),
						email, "id1200");
				},
				"Positive test of the Constructor");
		}

		[TestCase("", "An exception should occur if the VKID is empty in constructor",
			TestName = "Assignment constructor of the VKID is empty")]
		[TestCase("1234567890qwertyui",
			"An exception should occur if the VKID is large of max value in constructor",
			TestName = "Assignment constructor of the VKID is large of max value")]
		public void TestConstructorContactVKID_ArgumentException(
			string wrongValue, string message)
		{

			Assert.Throws<ArgumentException>(
				() => 
				{
					var contact = new Contact("Name", "Surname",
						new PhoneNumber(78005553535),
						new DateTime(2000, 12, 12),
						"Email", wrongValue);
				},
				message);
		}

		[Test(Description = "Positive test of the Constructor VKID")]
		public void TestConstructorContactVKIDt_CorrectValue()
		{
			var vkid = "VKID";
			Assert.DoesNotThrow(
				() => 
				{
					var contact = new Contact("Name", "Surname",
						new PhoneNumber(78005553535),
						new DateTime(2000, 12, 12),
						"Email", vkid);
				},
				"Positive test of the Constructor");
		}
		//Test Constructor end
	}
}
