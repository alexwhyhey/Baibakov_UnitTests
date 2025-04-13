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

        [TestMethod()]
        public void Check_lessOr7Symbols_ReturnsFalse()
        {
            // Arrange
            string password1 = "qsd$Kl2"; // 7 symbols
            string password2 = "3D!k_A"; // 6 symbols
            string password3 = "Lk!43"; // 5 symbols
            bool expected = false;

            // Act
            bool actual1 = PasswordChecker.ValidatePassword(password1);
            bool actual2 = PasswordChecker.ValidatePassword(password2);
            bool actual3 = PasswordChecker.ValidatePassword(password3);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);
        }

        [TestMethod()]
        public void Check_21orMoreSymbols_ReturnsFalse()
        {
            // Arrange
            string password1 = "KL123!_canGO__45AbFpp"; // 21 symbols
            string password2 = "TrueOrFalse4567___!NOT"; // 22 symbols
            string password3 = "!GOTOORP2425$$guess??Not"; // 23 symbols
            bool expected = false;

            // Act
            bool actual1 = PasswordChecker.ValidatePassword(password1);
            bool actual2 = PasswordChecker.ValidatePassword(password2);
            bool actual3 = PasswordChecker.ValidatePassword(password3);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);
        }

        [TestMethod()]
        public void Check_WithoutSpecialSymbols_ReturnsFalse()
        {
            // Arrange
            string password1 = "TrieD56times";
            string password2 = "ShEEt4page";
            string password3 = "FALLasleep7";
            bool expected = false;

            // Act
            bool actual1 = PasswordChecker.ValidatePassword(password1);
            bool actual2 = PasswordChecker.ValidatePassword(password2);
            bool actual3 = PasswordChecker.ValidatePassword(password3);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);
        }

        [TestMethod()]
        public void Check_WithoutUpperLetter_ReturnsFalse()
        {
            // Arrange
            string password1 = "this$is11cash";
            string password2 = "ab_fg_cnt_wall12";
            string password3 = "apr$sssgk__4";
            bool expected = false;

            // Act
            bool actual1 = PasswordChecker.ValidatePassword(password1);
            bool actual2 = PasswordChecker.ValidatePassword(password2);
            bool actual3 = PasswordChecker.ValidatePassword(password3);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);
        }

        [TestMethod()]
        public void Check_WithoutLowerLetter_ReturnsFalse()
        {
            // Arrange
            string password1 = "GO_GO$GO1TOPAR";
            string password2 = "KRLBFOG!_OOPS8";
            string password3 = "7FASSHOLE???_";
            bool expected = false;

            // Act
            bool actual1 = PasswordChecker.ValidatePassword(password1);
            bool actual2 = PasswordChecker.ValidatePassword(password2);
            bool actual3 = PasswordChecker.ValidatePassword(password3);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);
        }

        [TestMethod()]
        public void Check_AllRequirements_ReturnsTrue()
        {
            // Arrange
            string password1 = "That!sGoodPass8";
            string password2 = "There_s8";
            string password3 = "!THEREis_20$SymbolsS";
            bool expected = true;

            // Act
            bool actual1 = PasswordChecker.ValidatePassword(password1);
            bool actual2 = PasswordChecker.ValidatePassword(password2);
            bool actual3 = PasswordChecker.ValidatePassword(password3);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);
        }
    }
}
