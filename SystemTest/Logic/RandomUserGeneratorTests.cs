using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_work.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_work.Logic.Tests
{
    [TestClass]
    public class RandomUserGeneratorTests : RandomUserGenerator
    {
        [TestMethod]
        public void TestGenerateEmail()
        {
            // Generate a random email and ensure it's in the correct format
            string email = RandomUserGenerator.generateEmail();
            Assert.IsTrue(email.Contains("@") && email.Contains(".com"));
        }

        [TestMethod]
        public void TestGenerateID()
        {
            // Generate a random ID and ensure it's a 9-digit number
            string id = RandomUserGenerator.generateID();
            Assert.IsTrue(id.Length == 9 && int.TryParse(id, out _));
        }

        [TestMethod]
        public void TestGeneratePhone()
        {
            string phone = genaratePhone();
            if (phone[3] == '-') { phone = phone.Replace("-", ""); }
            bool isValid = phone.Length == 10 && phone.All(char.IsDigit);
            Assert.IsTrue(isValid);
        }







        [TestMethod]
        public void TestGenerateGrade()
        {
            // Generate 1000 grades and ensure they're all valid
            for (int i = 0; i < 1000; i++)
            {
                string grade = RandomUserGenerator.generateGrade();
                Assert.IsTrue(grade == "777" || (int.TryParse(grade, out int result) && result >= 0 && result <= 100));
            }
        }

        [TestMethod]
        public void TestGenerateFirstName()
        {
            // Generate 1000 first names and ensure they're all valid
            for (int i = 0; i < 1000; i++)
            {
                string firstName = RandomUserGenerator.generateFirstName();
                Assert.IsNotNull(firstName);
            }
        }

        [TestMethod]
        public void TestGenerateLastName()
        {
            // Generate 1000 last names and ensure they're all valid
            for (int i = 0; i < 1000; i++)
            {
                string lastName = RandomUserGenerator.generateLastName();
                Assert.IsNotNull(lastName);
            }
        }
    }
}
