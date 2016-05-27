using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAG.Models;
using BAG.BusinessLogic;


namespace Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult LoginProcess(Admin_Login u)
        {
            try
            {
                AccountsBLL obj = new AccountsBLL();
                U_USR_Lgn obj1 = new U_USR_Lgn();
                obj1.Email_ID = u.EmailId;
                obj1.Pwd = u.Password;
                obj1.Created_by = u.UserName;
                U_ADMIN_lOGIN_Ref status = obj.LoginPro(obj1);
                
                if (status != null)
                {
                    Session["AdminId"] = status.UserId;
                    Session["AdminName"] = status.UserName;
                    ModelState.Clear();
                    return Content("Success", "text/html");
                }
                else
                {
                    return Content("Invalid User", "text/html");
                }
            }
            catch
            {
              return Content("Invalid Password", "text/html");
            }
        }

        
        [Admin.FilterConfig.SessionAuthorize]
        public ActionResult DashBoard()
        {
            //Displays DashBoard
            return View();
        }

        [Admin.FilterConfig.SessionAuthorize]
        public ActionResult Eventdescription()
        {
            return View();
        }

        public ActionResult Events()
        {
            return View();
        }

        public ActionResult Additems()
        {
            return View();
        }

        public ActionResult EditProfile()
        {
            return View();
        }

        public ActionResult Notifications()
        {
            return View();
        }

        public ActionResult paymentstatus()
        {
            return View();
        }

        public ActionResult subadmin()
        {
            return View();
        }

        public ActionResult paymentrevert()
        {
            return View();
        }

        public ActionResult Editsubadmin()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();
            return RedirectToAction("Index", "Home");
        }
    }
}