using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAG.Models;

namespace Admin.Controllers
{
    public class PaymentsController : Controller
    {
        // GET: Payments
        public ActionResult Index()
        {
            var trans = new List<Admin_Transactions>();
            trans.Add(new Admin_Transactions { Id = 1, TransactionId = 1234, EventName = "Event1", WishList = "WishList1", ItemId = 10, ItemName = "Mobile",   Amount=8000,    ContributorName = "vinay1", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 2, TransactionId = 1235, EventName = "Event1", WishList = "WishList1", ItemId = 11, ItemName = "Computer", Amount = 12000, ContributorName = "vinay2", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 3, TransactionId = 1236, EventName = "Event1", WishList = "WishList1", ItemId = 10, ItemName = "Mobile", Amount = 8000, ContributorName = "vinay1", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 4, TransactionId = 1237, EventName = "Event1", WishList = "WishList1", ItemId = 11, ItemName = "Computer", Amount = 12000, ContributorName = "vinay2", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 5, TransactionId = 1238, EventName = "Event1", WishList = "WishList1", ItemId = 10, ItemName = "Mobile", Amount = 8000, ContributorName = "vinay1", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 6, TransactionId = 1239, EventName = "Event1", WishList = "WishList1", ItemId = 11, ItemName = "Computer", Amount = 12000, ContributorName = "vinay2", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 7, TransactionId = 1240, EventName = "Event1", WishList = "WishList1", ItemId = 10, ItemName = "Mobile", Amount = 8000, ContributorName = "vinay1", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 8, TransactionId = 1241, EventName = "Event1", WishList = "WishList1", ItemId = 11, ItemName = "Computer", Amount = 12000, ContributorName = "vinay2", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 9, TransactionId = 1242, EventName = "Event1", WishList = "WishList1", ItemId = 10, ItemName = "Mobile", Amount = 8000, ContributorName = "vinay1", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 10, TransactionId = 1243, EventName = "Event1", WishList = "WishList1", ItemId = 11, ItemName = "Computer", Amount = 12000, ContributorName = "vinay2", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 11, TransactionId = 1244, EventName = "Event1", WishList = "WishList1", ItemId = 10, ItemName = "Mobile", Amount = 8000, ContributorName = "vinay1", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 12, TransactionId = 1245, EventName = "Event1", WishList = "WishList1", ItemId = 11, ItemName = "Computer", Amount = 12000, ContributorName = "vinay2", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 13, TransactionId = 1246, EventName = "Event1", WishList = "WishList1", ItemId = 10, ItemName = "Mobile", Amount = 8000, ContributorName = "vinay1", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 14, TransactionId = 1247, EventName = "Event1", WishList = "WishList1", ItemId = 11, ItemName = "Computer", Amount = 12000, ContributorName = "vinay2", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 15, TransactionId = 1248, EventName = "Event1", WishList = "WishList1", ItemId = 10, ItemName = "Mobile", Amount = 8000, ContributorName = "vinay1", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 16, TransactionId = 1249, EventName = "Event1", WishList = "WishList1", ItemId = 11, ItemName = "Computer", Amount = 12000, ContributorName = "vinay2", Status = "0" });
            trans.Add(new Admin_Transactions { Id = 17, TransactionId = 1250, EventName = "Event1", WishList = "WishList1", ItemId = 10, ItemName = "Mobile", Amount = 8000, ContributorName = "vinay1", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 19, TransactionId = 1252, EventName = "Event1", WishList = "WishList1", ItemId = 10, ItemName = "Mobile", Amount = 8000, ContributorName = "vinay1", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 20, TransactionId = 1253, EventName = "Event1", WishList = "WishList1", ItemId = 11, ItemName = "Computer", Amount = 12000, ContributorName = "vinay2", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 18, TransactionId = 1251, EventName = "Event1", WishList = "WishList1", ItemId = 11, ItemName = "Computer", Amount = 12000, ContributorName = "vinay2", Status = "0" });
            trans.Add(new Admin_Transactions { Id = 21, TransactionId = 1254, EventName = "Event1", WishList = "WishList1", ItemId = 10, ItemName = "Mobile", Amount = 8000, ContributorName = "vinay1", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 22, TransactionId = 1255, EventName = "Event1", WishList = "WishList1", ItemId = 11, ItemName = "Computer", Amount = 12000, ContributorName = "vinay2", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 23, TransactionId = 1256, EventName = "Event1", WishList = "WishList1", ItemId = 10, ItemName = "Mobile", Amount = 8000, ContributorName = "vinay1", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 24, TransactionId = 1257, EventName = "Event1", WishList = "WishList1", ItemId = 11, ItemName = "Computer", Amount = 12000, ContributorName = "vinay2", Status = "1" });
            trans.Add(new Admin_Transactions { Id = 25, TransactionId = 1258, EventName = "Event1", WishList = "WishList1", ItemId = 10, ItemName = "Mobile", Amount = 8000, ContributorName = "vinay1", Status = "0" });
            trans.Add(new Admin_Transactions { Id = 26, TransactionId = 1259, EventName = "Event1", WishList = "WishList1", ItemId = 11, ItemName = "Computer", Amount = 12000, ContributorName = "vinay2", Status = "1" });
            return View(trans);
        }
    }
}