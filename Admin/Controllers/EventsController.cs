using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAG.BusinessLogic;
using BAG.Models;
using System.IO;

namespace Admin.Controllers
{
    public class EventsController : Controller
    {
        public ActionResult Index()
        {
            EventsBLL obj = new EventsBLL();
            U_EVNT_MASTER[] Events = obj.GetAllEventsDetails();
            return View(Events);
        }

        public ActionResult EventDetails(string id)
        {
            EventsBLL obj = new EventsBLL();
            Events eve = obj.GetEventDetails(id);
            EventsWishList[] eveWlist = obj.GetEventWishListDetails(id);
            EventsGroup data = new EventsGroup();
            data.eventDetails = eve;
            data.eventWishList = eveWlist;
            return View(data);
        }

        public ActionResult EventProfile(string id)
        {
            EventsBLL obj = new EventsBLL();
            Events eve = obj.GetEventDetails(id);
            EventsWishList[] eveWlist = obj.GetEventWishListDetails(id);
            EventsGroup data = new EventsGroup();
            data.eventDetails = eve;
            data.eventWishList = eveWlist;
            return View(data);
        }
        
        public ActionResult UpdateEvent(EventsGroup eveg, HttpPostedFileBase newImg)
        {
            EventsBLL eveBLL = new EventsBLL();
            Events eve = new Events();
            eve.Event_id = eveg.eventDetails.Event_id;
            eve.Event_Name = eveg.eventDetails.Event_Name;
            eve.Event_Location = eveg.eventDetails.Event_Location;
            eve.Event_Status = eveg.eventDetails.Event_Status;
            eve.Event_StartDate = eveg.eventDetails.Event_StartDate;
            eve.Event_EndDate = eveg.eventDetails.Event_EndDate;
            eve.Event_Desc = eveg.eventDetails.Event_Desc;

            string Images = "";
            if (!string.IsNullOrEmpty(Convert.ToString(newImg)))
            {
                if (Request.Files.Count > 0)
                {
                    int i = 0;
                    HttpPostedFileBase files = Request.Files[i];
                    if (files.ContentLength > 0)
                    {
                        string filestoragename = Guid.NewGuid().ToString() + ".jpeg";
                        string directory = Server.MapPath("~/images/");
                        string path = Path.Combine(directory, filestoragename);
                        files.SaveAs(path);
                        Images = filestoragename;
                    }
                }
                eve.Event_PicUrl = string.IsNullOrEmpty(Images) ? "/img/default_event.png" : "/images/" + Images;
            }
            eve.Event_Update_by = Convert.ToString(Session["AdminId"]);

            int status = eveBLL.UpdateEventDetails(eve);
            return RedirectToAction("Index", "Events");
        }
    }
}