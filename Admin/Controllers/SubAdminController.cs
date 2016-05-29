using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAG.Models;
using BAG.BusinessLogic;
using System.IO;

namespace Admin.Controllers
{
    public class SubAdminController : Controller
    {
        // GET: SubAdmin
        public ActionResult Index()
        {
            MembersBLL obj = new MembersBLL();
            U_ADMIN_Members[] Subadmin = obj.GetAllSubAdminDetails();
            return View(Subadmin);
        }

        public ActionResult Editsubadmin( string id)
        {
            MembersBLL memBLL = new MembersBLL();
            SubAdmin data = memBLL.GetSingleSubAdminDetails(id);
            return View(data);
        }

        public ActionResult Block(string id)
        {
            MembersBLL obj = new MembersBLL();
            bool status = obj.BlockThisMember(id);
            return RedirectToAction("Index", "SubAdmin");
        }

        public ActionResult Unblock(string id)
        {
            MembersBLL obj = new MembersBLL();
            bool status = obj.UnBlockThisMember(id);
            return RedirectToAction("Index", "SubAdmin");
        }

        public ActionResult AddSubAdmin()
        {
            return View();
        }

        public ActionResult SubAdminProfile(string id)
        {
            MembersBLL memBLL = new MembersBLL();
            SubAdmin data = memBLL.GetSingleSubAdminDetails(id);
            return View(data);
        }

        public ActionResult UpdateSubAdmin(SubAdmin usr, HttpPostedFileBase newImg)
        {
            MembersBLL memBLL = new MembersBLL();
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
                usr.Media_File_Location = string.IsNullOrEmpty(Images) ? "/img/default_ProfilePicture.jpg" : "/images/" + Images;
            }

            usr.Updated_by = Convert.ToString(Session["AdminId"]);
            usr.Created_by = Convert.ToString(Session["AdminId"]);
            bool status = memBLL.UpdateSubAdmin(usr);
            return RedirectToAction("Index", "SubAdmin");
        }

        public ActionResult CreateSubAdmin(A_ModelGroupsList subAdmin, HttpPostedFileBase imgFile)
        {
            MembersBLL obj = new MembersBLL();
            string Images = "";
            if (!string.IsNullOrEmpty(Convert.ToString(imgFile)))
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
                subAdmin.MasterData.Media_Id_Img = string.IsNullOrEmpty(Images) ? "/img/default_ProfilePicture.jpg" : "/images/" + Images;
            }
            subAdmin.MasterData.Created_by = Convert.ToString(Session["AdminId"]);
            subAdmin.MasterData.Updated_by = Convert.ToString(Session["AdminId"]);
            bool state = obj.NewSubAdmin(subAdmin);
            return RedirectToAction("Index", "SubAdmin");

        }
    }
}