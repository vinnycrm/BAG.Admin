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
    public class CouponController : Controller
    {
        // GET: Coupon
        public ActionResult Index()
        {
            CouponsBLL obj = new CouponsBLL();
            A_ADM_Coupon_Ref[] Coupons = obj.GetAllCouponsDetails();
            if (Coupons != null)
            {
                return View(Coupons);
            }
            return View();
        }

        public ActionResult CouponDetails(string id)
        {
            CouponsBLL cuBLL = new CouponsBLL();
            Coupons cup = cuBLL.GetCouponDetails(id);
            return View(cup);
        }

        public ActionResult CreateCoupon()
        {
            return View();
        }

        public ActionResult EditCupons(string id)
        {
            CouponsBLL couBLL = new CouponsBLL();
            Coupons cou = couBLL.GetCouponDetails(id);
            return View(cou);
        }

        public ActionResult CreateNewCoupon(Coupons cou, HttpPostedFileBase CupImg)
        {
            string Images = "";
            if (Request.Files.Count > 0)
            {
                int i = 0;
                HttpPostedFileBase files = Request.Files[i];
                if (files.ContentLength > 0)
                {
                    string filestoragename = Guid.NewGuid().ToString() + ".jpeg"; // + imgFile.FileName.Replace(" ", "");
                    string directory = Server.MapPath("~/images/");
                    string path = Path.Combine(directory, filestoragename);
                    files.SaveAs(path);
                    Images = filestoragename;
                }
            }

            cou.Coupon_PicUrl = string.IsNullOrEmpty(Images) ? "/img/no-image.gif" : "/images/" + Images;
            cou.Create_By = Convert.ToString((Session["AdminId"]));
            cou.Update_By = Convert.ToString((Session["AdminId"]));
            CouponsBLL obj = new CouponsBLL();
            bool res = obj.InsertNewCoupon(cou);
            return RedirectToAction("Index", "Coupon");
        }

        public ActionResult BlockMe(string id)
        {
            CouponsBLL couBLL = new CouponsBLL();
            bool status = couBLL.BlockThisCoupon(id);
            return RedirectToAction("Index", "Coupon");
        }

        public ActionResult UnBlockMe(string id)
        {
            CouponsBLL couBLL = new CouponsBLL();
            bool status = couBLL.UnBlockThisCoupon(id);
            return RedirectToAction("Index", "Coupon");
        }

        public ActionResult UpdateCoupon(Coupons cou, HttpPostedFileBase Coupon_PicUrl)
        {
            CouponsBLL couBLL = new CouponsBLL();
            string Images = "";
            if (!string.IsNullOrEmpty(Convert.ToString(Coupon_PicUrl)))
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
                cou.Coupon_PicUrl = string.IsNullOrEmpty(Images) ? "/img/no-image.gif" : "/images/" + Images;
            }
            cou.Create_By = Convert.ToString(Session["AdminId"]);
            cou.Update_By = Convert.ToString(Session["AdminId"]);
            bool status = couBLL.UpdateCoupon(cou);
            return RedirectToAction("Index", "Coupon");
        }
    }
}