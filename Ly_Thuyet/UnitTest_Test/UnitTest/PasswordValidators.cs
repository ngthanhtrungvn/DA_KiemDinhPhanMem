using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unitest_Code;
namespace UnitTest
{
    [TestClass]
    public class PasswordValidators
    {
        [TestMethod]
        public void TestValidPassword()
        {
            // Arrange
            PasswordValidator passwordValidator = new PasswordValidator();
            string validPassword = "Abcd1234";

            // Act
            bool isValid = passwordValidator.IsValidPassword(validPassword);

            // Assert
            Assert.IsTrue(isValid, "Mật khẩu hợp lệ nhưng hàm trả về sai.");
        }

        [TestMethod]
        public void TestInvalidPasswordNoLowercase()
        {
            // Arrange
            PasswordValidator passwordValidator = new PasswordValidator();
            string invalidPassword = "ABCa1234@"; // Mật khẩu không chứa chữ thường

            // Act
            bool isValid = passwordValidator.IsValidPassword(invalidPassword);

            // Assert
            Assert.IsFalse(isValid, "Mật khẩu không có chữ thường, nhưng hàm trả về true.");
        }

        [TestMethod]
        public void TestInvalidEmptyPassword()
        {
            // Arrange
            PasswordValidator passwordValidator = new PasswordValidator();
            string invalidPassword = "";

            // Act
            bool isValid = passwordValidator.IsValidPassword(invalidPassword);

            // Assert
            Assert.IsFalse(isValid, "Mật khẩu trống không hợp lệ, nhưng hàm trả về true.");
        }
        [TestMethod]
        public void TestInvalidPasswordNoUppercase()
        {
            // Arrange
            PasswordValidator passwordValidator = new PasswordValidator();
            string invalidPassword = "abcdef1234"; // Mật khẩu không chứa chữ hoa

            // Act
            bool isValid = passwordValidator.IsValidPassword(invalidPassword);

            // Assert
            Assert.IsFalse(isValid, "Mật khẩu không có chữ hoa, nhưng hàm trả về true.");
        }

        [TestMethod]
        public void TestInvalidPasswordNoNumber()
        {
            // Arrange
            PasswordValidator passwordValidator = new PasswordValidator();
            string invalidPassword = "Abcdefgh"; // Mật khẩu không chứa số

            // Act
            bool isValid = passwordValidator.IsValidPassword(invalidPassword);

            // Assert
            Assert.IsFalse(isValid, "Mật khẩu không có số, nhưng hàm trả về true.");
        }

        [TestMethod]
        public void TestInvalidShortPassword()
        {
            // Arrange
            PasswordValidator passwordValidator = new PasswordValidator();
            string invalidPassword = "Ab1"; // Mật khẩu quá ngắn (ít hơn 8 ký tự)

            // Act
            bool isValid = passwordValidator.IsValidPassword(invalidPassword);

            // Assert
            Assert.IsFalse(isValid, "Mật khẩu quá ngắn (ít hơn 8 ký tự), nhưng hàm trả về true.");
        }
    }
}
