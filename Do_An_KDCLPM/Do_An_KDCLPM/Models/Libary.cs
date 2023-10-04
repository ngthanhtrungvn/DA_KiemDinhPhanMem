﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Do_An_KDCLPM.Models
{
    public class Libary
    {
        private static Libary instances;

        public static Libary Instances
        {
            get
            {
                if (instances == null)
                    instances = new Libary();
                return instances;
            }
        }
        public string EncodeMD5(string pass)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(pass));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public string convertVND(string money)
        {
            var format = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string value = String.Format(format, "{0:c0}", Convert.ToUInt32(money));
            return value;
        }
        public string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            string unsigned = regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
            unsigned = Regex.Replace(unsigned, "[^a-zA-Z0-9 ]+", "");
            return unsigned.Replace(" ", "-");
        }
        public string randCode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[4];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return new String(stringChars);
        }
        public bool sendMail(string mailTo,string title, string body)
        {
            // //đăng nhập mail để gửi
            string email = ConfigurationManager.AppSettings["mail"].ToString();
            string pass = ConfigurationManager.AppSettings["pass"].ToString();

            //gán thông tin
            var mess = new MailMessage(email, mailTo);
            mess.Subject = title;
            mess.Body = body;
            //cho gửi định dạng html
            mess.IsBodyHtml = true;
            //cấu hình mail
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            //gửi mail đi
            NetworkCredential net = new NetworkCredential(email, pass);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = net;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(mess);

            try
            {
            }
            catch (SmtpException ex)
            {
                return false;
            }
            return true;

        }

    }
}