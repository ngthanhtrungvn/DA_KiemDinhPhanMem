﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Do_An_KDCLPM.Models;
using System.IO;
using System.Data.Entity;

namespace Do_An_KDCLPM.Controllers
{
    public class AccountController : Controller
    {
        QL_LINHKIENDIENTU_WEBEntities db = new QL_LINHKIENDIENTU_WEBEntities();
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return Redirect("/dang-nhap-dang-ki");
        }
        [HttpPost]
        public JsonResult UploadImg()
        {
            if (Request.Files.Count > 0)
            {
                var files = Request.Files;

                //iterating through multiple file collection   
                foreach (string str in files)
                {
                    HttpPostedFileBase file = Request.Files[str] as HttpPostedFileBase;
                    //Checking file is available to save.  
                    if (file != null)
                    {
                        var InputFileName = Path.GetFileName(file.FileName);
                        var ServerSavePath = Path.Combine(Server.MapPath("~/Assets/Client/img/") + InputFileName);
                        //Save file to server folder  
                        file.SaveAs(ServerSavePath);

                    }

                }
                return Json("File Uploaded Successfully!");
            }
            else
            {
                return Json("No files to upload");
            }
        }
        [HttpPost]
        public JsonResult Register(accounts acc)
        {
            try
            {
                if (db.accounts.SingleOrDefault(x => x.username.Equals(acc.username)) != null)
                    return Json(new
                    {
                        status = -1,
                        message = "Tài khoản đã được sử dụng."
                    });
                if (db.accounts.SingleOrDefault(x => x.email.Equals(acc.email)) != null)
                    return Json(new
                    {
                        status = -2,
                        message = "Email đã được sử dụng."
                    });
                if (acc.image != null&&acc.image.Length!=0)
                    acc.image = "Assets/Client/img/" + acc.image;
                else
                    acc.image = "";
                acc.status = true;
                acc.idrole = 2;
                acc.password = Libary.Instances.EncodeMD5(acc.password);
                db.accounts.Add(acc);
                db.SaveChanges();
                return Json(new
                {
                    status = 1,
                    message = "Đăng kí thành công."
                });
            }
            catch (Exception ex)
            {
            }
            return Json(new
            {
                status = 0,
                message = "Đăng kí thất bại."
            });

        }
        [HttpPost]
        public JsonResult ForgetPass(string email)
        {
            try
            {
                var acc = db.accounts.SingleOrDefault(x => x.email.Equals(email));
                if (acc == null)
                    return Json(new
                    {
                        status = 0,
                        message = "Không tồn tại email này."
                    });
                #region mã xác nhận email
                Session["code"] = Libary.Instances.randCode();
                string body = @"<!DOCTYPE html>
<html lang='en'>

<head>
    <meta charset='UTF-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Document</title>
    <style>
        * {
            padding: 0;
            margin: 0;
            box-sizing: border-box;
        }

        body {
            padding: 16px;
        }

        .body {
            border: 1px solid #ccc;
            width: 100%;
            margin: auto;
        }

        .code {
            text-align: center;
            margin: 0 auto;
            background: #8bc34a;
            border-radius: 50px;
            font-size: 1.5rem;
            line-height: 2rem;
            color: white;
            min-width: 150px;
            max-width: 200px;
        }

        .code_text {
            margin: auto;
            min-width: 150px;
            max-width: 200px;
            text-align: center;
            font-size: 1.5rem;
            line-height: 2rem;
        }

        .header {
            text-align: center;
            text-transform: uppercase;
            background: #8bc34a;
            color: white;
            padding: 4px;
        }

        .header h1 {
            line-height: 2.5rem;

        }

        .header h4 {

            line-height: 2rem;
        }

        footer {
            margin-top: 12px;
            text-align: center;
            text-transform: uppercase;
            background: #8bc34a;
            color: white;
            padding: 4px;

        }

        p {
            line-height: 2rem;
            padding: 0 8px;
        }
    </style>
</head>

<body>
    <div class='body'>
        <div class='header'>
            <h1>Công ty linh kiện điện tử</h1>
            <h4>Xác thực tài khoản " + acc.username + @"</h4>
        </div>
        <p>Chào bạn " + acc.fullname + @",</p>
        <p>Đây là mã xác nhận quên mật khẩu của bạn. Vui lòng không cung cấp cho người khác.</p>
        <h4 class='code_text'>Mã xác nhận</h4>
        <div class='code'>
            <span>" + Session["code"] + @"</span>
        </div>

        <p>Nếu không phải bạn? Vui lòng bỏ qua email này.</p>
        <p>Đã có tài khoản?<a href='https://linhkien.com/dang-nhap'>Đăng nhập tại đây</a></p>

        <p>Xin cảm ơn,</p>
        <p>nonbaohiemviettin@gmail.com</p>
        <footer class='footer'>
            <p>Cảm ơn bạn đã đăng kí tài khoản trên <a href='https://linhkien.com'>nonbaohiem.ml</a></p>
        </footer>
    </div>
</body>

</html>";
                #endregion
                if (Libary.Instances.sendMail(acc.email,"Quên mật khẩu", body))
                {
                    Session["acc"] = acc;
                    return Json(new
                    {
                        status = 1,
                        message = "Mời bạn check email."
                    });
                }
            }
            catch (Exception ex)
            {
            }
            return Json(new
            {
                status = -1,
                message = "Lỗi hệ thống."
            });

        }
        [HttpPost]
        public JsonResult SendAgain()
        {
            try
            {
                var acc = (Session["acc"] as accounts);
                #region mã xác nhận email
                Session["code"] = Libary.Instances.randCode();
                string body = @"<!DOCTYPE html>
<html lang='en'>

<head>
    <meta charset='UTF-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Document</title>
    <style>
        * {
            padding: 0;
            margin: 0;
            box-sizing: border-box;
        }

        body {
            padding: 16px;
        }

        .body {
            border: 1px solid #ccc;
            width: 100%;
            margin: auto;
        }

        .code {
            text-align: center;
            margin: 0 auto;
            background: #8bc34a;
            border-radius: 50px;
            font-size: 1.5rem;
            line-height: 2rem;
            color: white;
            min-width: 150px;
            max-width: 200px;
        }

        .code_text {
            margin: auto;
            min-width: 150px;
            max-width: 200px;
            text-align: center;
            font-size: 1.5rem;
            line-height: 2rem;
        }

        .header {
            text-align: center;
            text-transform: uppercase;
            background: #8bc34a;
            color: white;
            padding: 4px;
        }

        .header h1 {
            line-height: 2.5rem;

        }

        .header h4 {

            line-height: 2rem;
        }

        footer {
            margin-top: 12px;
            text-align: center;
            text-transform: uppercase;
            background: #8bc34a;
            color: white;
            padding: 4px;

        }

        p {
            line-height: 2rem;
            padding: 0 8px;
        }
    </style>
</head>

<body>
    <div class='body'>
        <div class='header'>
            <h1>Công ty linh kiện điện tử</h1>
            <h4>Xác thực tài khoản " + acc.username + @"</h4>
        </div>
        <p>Chào bạn " + acc.fullname + @",</p>
        <p>Đây là mã xác nhận của bạn. Vui lòng không cung cấp cho người khác.</p>
        <h4 class='code_text'>Mã xác nhận</h4>
        <div class='code'>
            <span>" + Session["code"] + @"</span>
        </div>

        <p>Nếu không phải bạn? Vui lòng bỏ qua email này.</p>
        <p>Đã có tài khoản?<a href='https://linhkien.com/dang-nhap'>Đăng nhập tại đây</a></p>

        <p>Xin cảm ơn,</p>
        <p>nonbaohiemviettin@gmail.com</p>
        <footer class='footer'>
            <p>Cảm ơn bạn đã đăng kí tài khoản trên <a href='https://linhkien.com'>nonbaohiem.ml</a></p>
        </footer>
    </div>
</body>

</html>";
                #endregion

                Libary.Instances.sendMail(acc.email,"Gửi lại mã", body);
                return Json(new
                {
                    status = 1,
                    message = "Mời bạn check email."
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    status = -1,
                    message = "Lỗi hệ thống."
                });

            }
        }
        [HttpPost]
        public JsonResult CodeForget(string code)
        {
            if (!Session["code"].ToString().Equals(code))
                return Json(new {
                    status=0,
                    message= "Mã xác nhận không chính xác."
                });
            return Json(new
            {
                status = 1,
                message = "Mời bạn đổi mật khẩu."

            });
        }
        [HttpPost]
        public JsonResult ChangePasswordEmail(string passNew)
        {
           
            try
            {
                var acc = Session["acc"] as accounts;
                acc = db.accounts.Find(acc.id);
                acc.password = Libary.Instances.EncodeMD5(passNew);
                db.Entry(acc).State = EntityState.Modified;
                db.SaveChanges();
                Session.Clear();
                Session.Abandon();
                return Json(new
                {
                    status = 1,
                    message = "Đổi mật khẩu thành công."
                });
            }
            catch (Exception ex)
            {

            }
            return Json(new
            {
                status = -1,
                message = "Đổi mật khẩu thất bại."
            });
        }
        public ActionResult Index()
        {
            if (Session["account_client"] != null)
                return Redirect("/");
            else
            return View();
        }      
        [HttpPost]
        public JsonResult Login(string username, string password)
        {
            password = Libary.Instances.EncodeMD5(password);
            accounts acc = db.accounts.SingleOrDefault(x => x.username.Equals(username) && x.password.Equals(password));
            if (acc == null)
                return Json(new
                {
                    status = 0,
                    message = "Sai tài khoản hoặc mật khẩu."
                });
            if (acc.status == false)
            {
                return Json(new
                {
                    status = -1,
                    message = "Tài khoản bị khoá."
                });
            }
            Session["account_client"] = acc;
            return Json(new
            {
                status = 1,
            });
        }
    }
}