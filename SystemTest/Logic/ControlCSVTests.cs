using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_work.Tests
{
    [TestClass()]
    public class ControlCSVTests
    {
        [TestMethod()]
        public void AverageGradeOfFiveTest()
        {
            // Arrange
            string first = "80";
            string second = "90";
            string third = "70";
            string fourth = "85";
            string fifth = "77";

            // Act
            string result = ControlCSV.AverageGradeOfFive(first, second, third, fourth, fifth);

            // Assert
            Assert.AreEqual("80", result);
        }

        [TestMethod()]
        public void getUserTest()
        {

            // Arrange
            // Create a sample user data and add it to the file
            var sampleData = new List<UserData> {
        new UserData {
            FirstName = "John",
            LastName = "Doe",
            ID = "12345",
            Email = "johndoe@example.com",
            PhoneNumber = "555-5555",
            Physics = "90",
            Calculus = "85",
            ComputerScience = "80",
            History = "95",
            IndustrialEngineering = "75",
            AverageGrade = "85"
        }
    };
            ControlCSV.AdduserList(sampleData);

            // Act
            // Call the getUser method to get the list of user data
            var result = ControlCSV.getUser();

            // Assert
            // Verify that the returned list is not empty
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

        }




        [TestMethod()]
        public void AddUserListTest()
        {
            // Arrange
            var existingData = ControlCSV.getUser(); // Get existing data from CSV file
            var newUsers = new List<UserData>
    {
        new UserData
        {
            FirstName = "John",
            LastName = "Doe",
            ID = "12345",
            Email = "john.doe@example.com",
            PhoneNumber = "555-5555",
            Physics = "90",
            Calculus = "80",
            ComputerScience = "85",
            History = "75",
            IndustrialEngineering = "70",
            AverageGrade = ControlCSV.AverageGradeOfFive("90", "80", "85", "75", "70")
        },
        new UserData
        {
            FirstName = "Jane",
            LastName = "Doe",
            ID = "67890",
            Email = "jane.doe@example.com",
            PhoneNumber = "555-5555",
            Physics = "85",
            Calculus = "90",
            ComputerScience = "80",
            History = "70",
            IndustrialEngineering = "75",
            AverageGrade = ControlCSV.AverageGradeOfFive("85", "90", "80", "70", "75")
        }
    };

            // Act
            ControlCSV.AdduserList(newUsers);

            // Assert
            var updatedData = ControlCSV.getUser(); // Get updated data from CSV file
            var expectedCount = existingData.Count + newUsers.Count;
            Assert.AreEqual(expectedCount, updatedData.Count, "The number of records in the CSV file was not updated correctly.");

            // Check if new users are present in the updated data
            foreach (var newUser in newUsers)
            {
                var foundUser = updatedData.FirstOrDefault(u => u.ID == newUser.ID);
                Assert.IsNotNull(foundUser, $"New user with ID '{newUser.ID}' was not added to the CSV file.");
            }
        }

        [TestMethod()]
        public void AddUserTest()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";
            string id = "12345";
            string email = "johndoe@example.com";
            string phone = "555-1234";
            string physics = "95";
            string calculus = "87";
            string computerScience = "92";
            string history = "79";
            string industrialEngineering = "85";

            // Act
            ControlCSV.AddUser(firstName, lastName, id, email, phone, physics, calculus, computerScience, history, industrialEngineering);
            var actual = ControlCSV.getUser().Last();

            // Assert
            Assert.AreEqual(firstName, actual.FirstName);
            Assert.AreEqual(lastName, actual.LastName);
            Assert.AreEqual(id, actual.ID);
            Assert.AreEqual(email, actual.Email);
            Assert.AreEqual(phone, actual.PhoneNumber);
            Assert.AreEqual(physics, actual.Physics);
            Assert.AreEqual(calculus, actual.Calculus);
            Assert.AreEqual(computerScience, actual.ComputerScience);
            Assert.AreEqual(history, actual.History);
            Assert.AreEqual(industrialEngineering, actual.IndustrialEngineering);
            Assert.AreEqual(ControlCSV.AverageGradeOfFive(physics, calculus, computerScience, history, industrialEngineering), actual.AverageGrade);
        }

    }
}