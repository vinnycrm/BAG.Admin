using System.Collections.Generic;
using System.Web.Mvc;
using BAG.Models;
using BAG.BusinessLogic;
using System.Web;
using System.IO;
using System.Linq;
using System;
using System.Web.UI.WebControls;

namespace Admin.Controllers
{
    public class GiftItemsController : Controller
    {
        // GET: GiftItems
        public ActionResult Index()
        {
            ItemsBLL obj = new ItemsBLL();
            A_ADM_ITEM_MASTER[] items = obj.GetAllItemsDetails();
            if(items != null)
            {
                return View(items);
            }
                return View();
        }

        public ActionResult AddItems( )
        {
            return View();
        }

        public ActionResult AddNewItem(Admin_Items item, HttpPostedFileBase imgFile)
        {
            string Images = "";
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
                item.Media_Id_Img = string.IsNullOrEmpty(Images) ? "/img/default_product.png" : "/images/" + Images;
                item.Created_by = Convert.ToString(Session["AdminId"]);
                item.Updated_by = Convert.ToString(Session["AdminId"]);
                ItemsBLL obj = new ItemsBLL();
                bool res = obj.InsertNewItem(item);
                return RedirectToAction("Index", "GiftItems");
        }

        public ActionResult ItemDetails(string id)
        {
            ItemsBLL obj = new ItemsBLL();
            A_ADM_ITEM_MASTER item = obj.GetSingleItemDetails(id);
            return View(item);
        }

        public ActionResult BlockMe(string id)
        {
            ItemsBLL obj = new ItemsBLL();
            bool status = obj.BlockThisItem(id);
            return RedirectToAction("Index", "GiftItems");
        }

        public ActionResult UnBlockMe(string id)
        {
            ItemsBLL obj = new ItemsBLL();
            bool status = obj.UnBlockThisItem(id);
            return RedirectToAction("Index", "GiftItems");
        }

        public ActionResult EditItem(string id)
        {
            ItemsBLL ItemBLL = new ItemsBLL();
            A_ADM_ITEM_MASTER Item = ItemBLL.GetSingleItemDetails(id);
            return View(Item);
        }

        public ActionResult UpdateItem(A_ADM_ITEM_MASTER item, HttpPostedFileBase newImg)
        {
            ItemsBLL ItemBLL = new ItemsBLL();
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
                item.Item_PicUrl = string.IsNullOrEmpty(Images) ? "/img/default_product.png" : "/images/" + Images;
            }
                        
            item.Update_By = Convert.ToString(Session["AdminId"]);
            bool status = ItemBLL.UpdateItem(item);
            return RedirectToAction("Index", "GiftItems");
        }
    }
}