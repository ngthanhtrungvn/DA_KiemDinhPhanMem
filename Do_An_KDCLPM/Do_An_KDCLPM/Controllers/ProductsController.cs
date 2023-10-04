using Do_An_KDCLPM.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Do_An_KDCLPM.Controllers
{
    public class ProductsController : Controller
    {
        QL_LINHKIENDIENTU_WEBEntities db = new QL_LINHKIENDIENTU_WEBEntities();
        int pageSize = 10;
        void ViewBagNoti(List<products> temp, int check, int page)
        {
            if (temp.Count() > 0)
            {
                int last = int.Parse(Math.Ceiling((double)temp.Count() / pageSize).ToString());
                ViewBag.last = last;
                ViewBag.noti = "Showing " + page + "-" + last + " of " + temp.Count() + " results";
                ViewBag.check = check;
            }
        }
        public ActionResult Index(string alias, int page = 1)
        {
            var temp = db.products.Where(x => x.category.alias.Equals(alias)).OrderByDescending(x => x.id).ToList();
            var products = temp.ToPagedList(page, pageSize);
            var category = db.category.SingleOrDefault(x => x.alias.Equals(alias));
            ViewBag.alias = category.name;
            ViewBagNoti(temp, 0, page);
            return View(products);
        }
        public ActionResult Detail(string alias)
        {
            var productdetail = new productdetail();
            productdetail.product = db.products.SingleOrDefault(x => x.alias.Equals(alias));
            productdetail.lstProducts_Categories = db.products.Where(x => x.category.name.Equals(productdetail.product.category.name)).ToList();
            return View(productdetail);
        }
        public ActionResult Search(int page = 1)
        {
            try
            {
                string keyword = Request["tukhoa"].ToString().ToLower();
                var temp = db.products.Where(x => (x.category.name.ToLower().Contains(keyword)                
                || x.name.ToLower().Contains(keyword)               
                || x.id.ToString().ToLower().Equals(keyword)
                )).OrderByDescending(x => x.id).ToList();
                var products = temp.ToPagedList(page, pageSize);
                ViewBag.alias = "Tìm kiếm: " + keyword;
                ViewBagNoti(temp, 2, page);
                return View("Index", products);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

        }
    }
}