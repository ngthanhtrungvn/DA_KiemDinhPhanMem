using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Do_An_KDCLPM.Models;
using System.Configuration;
using System.Net.Mail;

namespace Do_An_KDCLPM.Controllers
{
    public class CartController : Controller
    {

        public const string cartSession = "cartSession";
        private QL_LINHKIENDIENTU_WEBEntities db = new QL_LINHKIENDIENTU_WEBEntities();
        public ActionResult Index()
        {
            var cart = Session[cartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }
        [HttpPost]
        public JsonResult DeleteItem(int ProductId)
        {
            var cart = Session[cartSession];
            var p = db.products.Find(ProductId);
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(x => x.Product.id == ProductId))
                {
                    list.RemoveAll(r => r.Product.id == ProductId);
                    Session[cartSession] = list;
                    return Json(new
                    {
                        status = 1,
                        sumQuantity = list.Sum(x => x.Quantity),
                        sumMoney = Libary.Instances.convertVND(list.Sum(x => x.Quantity * (x.Product.promationprice > 0 ? x.Product.promationprice : x.Product.price)).ToString()),
                        message = "Xoá sản phẩm thành công."
                    }
                    );
                }
            }
            return Json(new
            {
                status = 0,
                message = "Có lỗi trong quá trình xoá sản phẩm."
            });

        }
        [HttpPost]
        public JsonResult AddItem(int ProductId, int Quantity)
        {
            if (Session["account_client"] == null)
                return Json(new { status = -1, message = "Mời bạn đăng nhập" });
            else
                try
                {
                    var cart = Session[cartSession];
                    var p = db.products.Find(ProductId);
                    if (Quantity > p.quantity)
                        return Json(new
                        {
                            status = -3,
                            message = "Không đủ hàng"
                        });
                    //tim kiem san pham trong db, Id=1
                    if (cart != null)
                    {//gio da co sp
                        var list = (List<CartItem>)cart;
                        if (list.Exists(x => x.Product.id == ProductId))
                        {
                            foreach (var item in list)
                            {
                                if (item.Product.id == ProductId)
                                {
                                    if ((item.Quantity + Quantity) > p.quantity)
                                        return Json(new
                                        {
                                            status = -3,
                                            message = "Không đủ hàng"
                                        });
                                    item.Quantity += Quantity;
                                    return Json(new
                                    {
                                        status = 1,
                                        sumQuantity = list.Sum(x => x.Quantity),
                                        message = "Thêm thành công"
                                    });
                                }

                            }
                        }
                        else
                        {
                            var item = new CartItem();
                            item.Product = p;
                            item.Quantity = Quantity;
                            list.Add(item);
                            Session[cartSession] = list; //save
                            return Json(new
                            {
                                status = 1,

                                sumQuantity = list.Sum(x => x.Quantity),
                                message = "Thêm thành công"
                            });
                        }

                    }
                    else
                    { //gio hang moi
                        var item = new CartItem();
                        item.Product = p;
                        item.Quantity = Quantity;
                        var list = new List<CartItem>();
                        list.Add(item);
                        Session[cartSession] = list;//save 
                        return Json(new
                        {
                            status = 1,
                            sumQuantity = Quantity,
                            message = "Thêm thành công"
                        });
                    }
                }
                catch (Exception ex)
                {
                }
            return Json(new { status = -2, message = "Thêm thất bại" });

        }
        [HttpPost]
        public JsonResult UpdateItem(int ProductId, int Quantity)
        {
            var cart = Session[cartSession];
            var p = db.products.Find(ProductId);
            if (Quantity > p.quantity)
                return Json(new
                {
                    status = -3,
                    message = "Không đủ hàng"
                });
            decimal? subtotal = 0;
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(x => x.Product.id == ProductId))
                {
                    if (Quantity <= 0)
                        list.RemoveAll(r => r.Product.id == ProductId);
                    else
                        foreach (var item in list)
                        {
                            if (item.Product.id == ProductId)
                            {
                                if (Quantity > p.quantity)
                                    return Json(new
                                    {
                                        status = -3,
                                        message = "Không đủ hàng"
                                    });
                                item.Quantity = Quantity;
                                subtotal = Quantity * (item.Product.promationprice > 0 ? item.Product.promationprice : item.Product.price);
                            }
                        }
                }

                Session[cartSession] = list;
                return Json(new
                {
                    status = 1,
                    sumQuantity = list.Sum(x => x.Quantity),
                    sumMoney = Libary.Instances.convertVND(list.Sum(x => x.Quantity * (x.Product.promationprice > 0 ? x.Product.promationprice : x.Product.price)).ToString()),
                    total = Libary.Instances.convertVND(subtotal.ToString())
                });
            }
            return Json(new { status = 0, message = "Có lỗi xảy ra" });


        }

        public ActionResult Checkout()
        {
            return View();
        }
        [HttpPost]

        public JsonResult Pay(orders order)
        {
            order.createdate = DateTime.Parse(DateTime.Now.ToShortDateString());
            order.idaccount = (Session["account_client"] as accounts).id;
            var cart = Session[cartSession] as List<CartItem>;

            #region body mail
            string body = @"<!DOCTYPE html>
<html lang='en'>
<head>
  <meta charset='UTF-8'>
  <meta http-equiv='X-UA-Compatible' content='IE=edge'>
  <meta name='viewport' content='width=device-width, initial-scale=1.0'>
  <title>Document</title>
  <style>
    body {
      padding: 4px;
      margin: 0;
      box-sizing: border-box;
      font-size: 1.2rem;

    }

    .container {
      border: 1px solid #ccc;

    }

    .table {
      border-top:1px solid #ccc;
      
    }

    .row {
      display: flex;
      justify-content: space-between;
    }

    .row>span {
      width: 20%;
      text-align: center;
    }

    .row span:nth-child(4) {
      width: 10%;

    }

    .row span:nth-child(2) {
      width: 30%;

    }

    .thead span {
      border-bottom: 3px solid #D19C97;
      line-height: 3rem;
    }

    .tbody .row>span {
      display: flex;
      line-height: 1.5rem;
      justify-content: center;
      align-items: center;
    }

    .border_right-none {
      border-right: none !important;
    }

    .row>span {
      border-right: 1px solid #ccc;
    }

    img {
      width: 100%;
    }

    .tbody .row>span>span {
      margin: auto;
    }

    .tbody .row {
      border-bottom: 1px solid #ccc;
    }
    

    .footer {
      padding: 8px;
    display: flex;
    }
    .footer_text{
      font-weight: 600;
      margin-right:auto ;
    }
    .header{
      padding: 4px;
      background: #D19C97;
    }
    .header h1,.header h3,.header h5,.header p{
      text-transform: uppercase;
      padding: 0;
      margin: 0;
      text-align: center;
      color: white;
      margin-bottom: 4px;
    }
    .header_detail{
          color: white;
          display: flex;
          flex-wrap: wrap;
        }
        .header_detail > div{
          width: 50%;
          text-align: center;
        }
  </style>
</head>

<body>
  <div class='container'>
    <div class='header'>
      <h1 >CÔNG TY LINH KIỆN ĐIỆN TỬ</h1>
      <h3>Thông tin đơn hàng</h3>
      <h5 style='margin:0'>Ngày đặt: " + DateTime.Now.ToString() + @"</h5>
      <div class='header_detail'>
        <div>
          <span>Họ tên:</span>
          <span>" + order.fullname + @"</span>
        </div>
        <div>
          <span>Email:</span>
          <span>" + order.email + @"</span>
        </div>       
      </div>
         <div class='header_detail'>        
        <div>
          <span>Số điện thoại:</span>
          <span>" + order.phone + @"</span>
        </div>
        <div>
          <span>Địa chỉ nhận hàng:</span>
          <span>" + order.address + @"</span>
        </div>
      </div>
    </div>
    <div class='table'>
      <div class='thead'>
        <div class='row'>
          <span>Ảnh</span>
          <span>Tên sản phẩm</span>
          <span>Giá</span>
          <span>Số lượng</span>
          <span class='border_right-none'>Thành tiền</span>
        </div>
      </div>
      <div class='tbody'>";
            #endregion
            db.orders.Add(order);
            db.SaveChanges();
            int idorder = db.orders.OrderByDescending(x => x.id).FirstOrDefault().id;
            var urlImage = string.Empty;
            foreach (var item in cart)
            {
                urlImage = "http://localhost:60710/" + item.Product.image.Replace(" ", "%20");
                orderdetails orderdetail = new orderdetails();
                orderdetail.idorder = idorder;
                orderdetail.idproduct = item.Product.id;
                orderdetail.quantity = item.Quantity;
                orderdetail.price = (item.Product.promationprice > 0 ? item.Product.promationprice : item.Product.price);
                orderdetail.subtotal = orderdetail.price * orderdetail.quantity;
                #region body mail
                body += @"
                        <div class='row'>
                  <span><img
                      src='" + urlImage + @"'
                      alt='Error'></span>
                  <span><span>" + item.Product.name + @"</span></span>
                  <span><span>" + Libary.Instances.convertVND(orderdetail.price.ToString()) + @"</span></span>
                  <span><span>" + item.Quantity + @"</span></span>
                  <span class='border_right-none'><span>" + Libary.Instances.convertVND((orderdetail.price * orderdetail.quantity).ToString()) + @"</span></span>
                </div>";
                #endregion
                db.orderdetails.Add(orderdetail);
                db.SaveChanges();
            }
            #region body mail
            body += String.Format(@"</div>
    </div>
    <div class='footer'>
      <span class='footer_text'>
        Tổng sản phẩm
      </span>
      <span>
        {0}
      </span>
    </div>
    <div class='footer'>
      <span class='footer_text'>
        Tổng tiền
      </span>
      <span>
       {1}
      </span>
    </div>
    <div class='header'>
      <p>Xin cảm ơn quý khách đã ủng hộ shop.</p>
      <p style='margin:0;'>Hẹn gặp lại quý khách.</p>
      
    </div>
  </div>

</body>

</html>", cart.Sum(x => x.Quantity), Libary.Instances.convertVND(cart.Sum(x => x.Quantity * (x.Product.promationprice > 0 ? x.Product.promationprice : x.Product.price)).ToString()));
            #endregion
            Session[cartSession] = null;
            Libary.Instances.sendMail(order.email, "Thông tin đơn hàng " + idorder, body);

            return Json(new
            {
                status = 1
            });


        }
    }
}