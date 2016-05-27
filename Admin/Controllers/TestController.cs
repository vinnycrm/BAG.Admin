using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Admin.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        // POST : Test/LoginProcess
        [HttpPost]
        public ActionResult LoginProcess(string fullName,String email)
        {
            if (!string.IsNullOrEmpty(fullName) & !string.IsNullOrEmpty(email))
            {
                //Do to Something here
                //return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Test");
        }
    }
}