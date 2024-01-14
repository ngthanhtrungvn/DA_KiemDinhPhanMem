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
public class AmLichTest {
   

    @Test
    public void TC1_TestNam2000() {
        String amLich = AmLich.ChuyenNamdDuongSangAmLich(2000);
        assertEquals("Canh Thìn", amLich);
    }

    @Test
    public void TC2_TestNam2023() {
        String amLich = AmLich.ChuyenNamdDuongSangAmLich(2023);
        assertEquals("Quý Mão", amLich);
    }

    @Test
    public void TC3_TestNam2020() {
        String amLich = AmLich.ChuyenNamdDuongSangAmLich(2020);
        assertEquals("Canh Tý", amLich);
    }

    @Test
    public void TC4_TestNam2023() {
        String amLich = AmLich.ChuyenNamdDuongSangAmLich(2023);
        assertEquals("Quý Mão", amLich);
    }

    @Test
    public void TC5_TestNam2000() {
        String amLich = AmLich.ChuyenNamdDuongSangAmLich(2000);
        assertEquals("Canh Thìn", amLich);
    }
    
}
