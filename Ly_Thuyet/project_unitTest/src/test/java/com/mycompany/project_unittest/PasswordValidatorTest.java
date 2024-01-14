/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package com.mycompany.project_unittest;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

/**
 *
 * @author admin
 */
public class PasswordValidatorTest {
    
    @Test
    public void testValidPassword() {
        // Arrange
        PasswordValidator passwordValidator = new PasswordValidator();
        String validPassword = "Abcd1234";

        // Act
        boolean isValid = passwordValidator.isValidPassword(validPassword);

        // Assert
        assertTrue(isValid);
    }

    @Test
    public void testInvalidPasswordNoLowercase() {
        // Arrange
        PasswordValidator passwordValidator = new PasswordValidator();
        String invalidPassword = "ABC1234@"; // Mật khẩu không chứa chữ thường

        // Act
        boolean isValid = passwordValidator.isValidPassword(invalidPassword);

        // Assert
        assertFalse(isValid);
    }

    @Test
    public void testInvalidEmptyPassword() {
        // Arrange
        PasswordValidator passwordValidator = new PasswordValidator();
        String invalidPassword = "";

        // Act
        boolean isValid = passwordValidator.isValidPassword(invalidPassword);

        // Assert
        assertFalse(isValid);
    }

    @Test
    public void testInvalidPasswordNoUppercase() {
        // Arrange
        PasswordValidator passwordValidator = new PasswordValidator();
        String invalidPassword = "abcdef1234"; // Mật khẩu không chứa chữ hoa

        // Act
        boolean isValid = passwordValidator.isValidPassword(invalidPassword);

        // Assert
        assertFalse(isValid);
    }

    @Test
    public void testInvalidPasswordNoNumber() {
        // Arrange
        PasswordValidator passwordValidator = new PasswordValidator();
        String invalidPassword = "Abcdefgh"; // Mật khẩu không chứa số

        // Act
        boolean isValid = passwordValidator.isValidPassword(invalidPassword);

        // Assert
        assertFalse(isValid);
    }

    @Test
    public void testInvalidShortPassword() {
        // Arrange
        PasswordValidator passwordValidator = new PasswordValidator();
        String invalidPassword = "Ab1"; // Mật khẩu quá ngắn (ít hơn 8 ký tự)

        // Act
        boolean isValid = passwordValidator.isValidPassword(invalidPassword);

        // Assert
        assertFalse(isValid);
    }
}
