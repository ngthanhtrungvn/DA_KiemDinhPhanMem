/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.project_unittest;

/**
 *
 * @author admin
 */
public class Project_unitTest {

    public static void main(String[] args) {
        NamNhuan namNhuan = new NamNhuan();
        int yearToCheck = 2024; // Thay đổi năm tại đây
        boolean isLeapYear = namNhuan.IsLeapYear(yearToCheck);

        if (isLeapYear) {
            System.out.println(yearToCheck + " la nam nhuan.");
        } else {
            System.out.println(yearToCheck + " khong phai la nam nhuan.");
        }


        AmLich amlich = new AmLich();
        int namDuongLich = 2022; // Thay đổi năm tại đây
        String namAmLich = amlich.ChuyenNamdDuongSangAmLich(namDuongLich);
        System.out.println("Nam " + namDuongLich + " duong lich tuong ung voi nam am lich: " + namAmLich);


        PasswordValidator passwordValidator = new PasswordValidator();
        
        String passwordToCheck = "MyP@ssw0rd"; // Thay đổi mật khẩu ở đây
        boolean isValid = passwordValidator.isValidPassword(passwordToCheck);
        
        if (isValid) {
            System.out.println("Mat khau hop le.");
        } else {
            System.out.println("Mat khau khong hop le.");
        }
    }
}
