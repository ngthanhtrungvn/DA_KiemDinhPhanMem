/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.project_unittest;

/**
 *
 * @author admin
 */
public class AmLich {
    private static String[] can = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
    private static String[] chi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };

    public static String ChuyenNamdDuongSangAmLich(int namDuongLich) {
        int canIndex = namDuongLich % 10;
        int chiIndex = namDuongLich % 12;

        String canChiAmLich = can[canIndex] + " " + chi[chiIndex];
        return canChiAmLich;
    }
}
