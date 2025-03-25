using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void ValidatePasswordTest()
        {
            // Arrange
            string password = "Aseivf23*";
            bool expected = true;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_7Symbols_ReturnsFalse()
        {
            // Arrange
            string password = "sdDsD1*";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_WithoutSpecialSymbols_ReturnsFalse()
        {
            // Arrange
            string password = "Aseivf23F";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_21Symbols_ReturnsFalse()
        {
            // Arrange
            string password = "Aseivf23F%%seivf23FeR";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_WithoutUpperCaseLetter_ReturnsFalse()
        {
            // Arrange
            string password = "wejbf124&&";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_WithoutLowerCaseLetter_ReturnsFalse()
        {
            // Arrange
            string password = "FUSEF77*(*";
            bool expected = false;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_ConsiderAllTheRequirements_ReturnsTrue()
        {
            // Arrange
            string password = "GHFWhdw127&&";
            bool expected = true;

            // Act
            bool actual = PasswordChecker.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}