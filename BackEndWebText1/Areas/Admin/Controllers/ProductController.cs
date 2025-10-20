using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEndWebText1.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
        public ActionResult LocalProduct()
        {
            return View();
        }
        public ActionResult SortProduct()
        {
            return View();
        }
        public ActionResult ManageShoppingCart()
        {
            return View();
        }
        public ActionResult Payments()
        {
            return View();
        }
        public ActionResult OrderConfirm()
        {
            return View();
        }
        public ActionResult OrderHistory()
        {
            return View();
        }
        public ActionResult Account()
        {
            return View();
        }
    }
}