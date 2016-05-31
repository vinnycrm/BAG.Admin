using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAG.Models;
namespace Admin.Controllers
{
    public class TicketsController : Controller
    {
        // GET: Tickets
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RiseTicket()
        {
            return View();
        }
        public string AddTicket(Admin_Tickets newTicket)
        {
            return "";
        }

        public ActionResult TicketDetails()
        {
            return View();
        }
    }
}