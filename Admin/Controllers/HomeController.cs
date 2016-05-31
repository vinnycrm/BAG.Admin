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
                    Session["AdminPic"] = status.ProfilePic;
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
            DashboardGroup details = new DashboardGroup();
            DashboardTotals tempTotal = new DashboardTotals();
            MembersBLL memBLL = new MembersBLL();
            EventsBLL eveBLL = new EventsBLL();
            ItemsBLL iteBLL = new ItemsBLL();

            List<DashboardEvents> eves = new List<DashboardEvents>();
            List<DashboardVendors> vends = new List<DashboardVendors>();
            tempTotal.TotalMembers = memBLL.MembersCount();
            tempTotal.TotalEvents = eveBLL.EventsCount();
            tempTotal.TotalItems = iteBLL.ItemsCount();
            tempTotal.TotalVendors = "0000";

            vends.Add(new DashboardVendors("1", "Shop1", "Vendor1", DateTime.Now));
            vends.Add(new DashboardVendors("2", "Shop2", "Vendor2", DateTime.Now));
            vends.Add(new DashboardVendors("3", "Shop3", "Vendor3", DateTime.Now));
            vends.Add(new DashboardVendors("4", "Shop4", "Vendor4", DateTime.Now));
            vends.Add(new DashboardVendors("5", "Shop1", "Vendor5", DateTime.Now));

            details.Totals = tempTotal;
            details.Members = memBLL.Recent5Members();
            details.Events = eveBLL.Recent5Events();
            details.Items = iteBLL.Recent5Items();
            details.Vendors = vends.ToArray();
            return View(details);
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