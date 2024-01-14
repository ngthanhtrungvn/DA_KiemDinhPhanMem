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
public class NamNhuanTest {
    

    @Test
    public void testIsLeapYear() {
        // Arrange
        NamNhuan kiemTraNamNhuan = new NamNhuan();
        
        // Act
        boolean isLeapYear = kiemTraNamNhuan.IsLeapYear(2000);
        
        // Assert
        assertTrue(isLeapYear);
    }
    
    @Test
    public void testNonLeapYear() {
        // Arrange
        NamNhuan kiemTraNamNhuan = new NamNhuan();
        
        // Act
        boolean isLeapYear = kiemTraNamNhuan.IsLeapYear(1900);
        
        // Assert
        assertFalse(isLeapYear);
    }
    
    @Test
    public void testCommonLeapYear() {
        // Arrange
        NamNhuan kiemTraNamNhuan = new NamNhuan();
        
        // Act
        boolean isLeapYear = kiemTraNamNhuan.IsLeapYear(2020);
        
        // Assert
        assertTrue(isLeapYear);
    }
    
    @Test
    public void testNegativeYear() {
        // Arrange
        NamNhuan kiemTraNamNhuan = new NamNhuan();
        
        // Act
        boolean isLeapYear = kiemTraNamNhuan.IsLeapYear(-100); // Năm âm không hợp lệ
        
        // Assert
        assertFalse(isLeapYear);
    }
    
    @Test
    public void testRandomNonLeapYear() {
        // Arrange
        NamNhuan kiemTraNamNhuan = new NamNhuan();
        
        // Act
        boolean isLeapYear = kiemTraNamNhuan.IsLeapYear(2019); // Năm không nhuận ngẫu nhiên
        
        // Assert
        assertFalse(isLeapYear);
    }
    
    @Test
    public void testZeroYear() {
        // Arrange
        NamNhuan kiemTraNamNhuan = new NamNhuan();
        
        // Act
        boolean isLeapYear = kiemTraNamNhuan.IsLeapYear(0); // Năm 0 không hợp lệ
        
        // Assert
        assertFalse(isLeapYear);
    }
}
