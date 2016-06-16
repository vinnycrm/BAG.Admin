using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class VendorsController : Controller
    {
        // GET: Vendors
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VendorsProfile()
        {
            return View();
        }
        public ActionResult AddVendors()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Category()
        {
            return View();
        }
        public ActionResult EditCategory()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
        public ActionResult EditProducts()
        {
            return View();
        }
    }
}