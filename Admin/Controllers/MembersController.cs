using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAG.Models;
using BAG.BusinessLogic;
namespace Admin.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult Index()
        {
            MembersBLL obj = new MembersBLL();
            U_ADMIN_Members[] membs = obj.GetAllMembersDetails();
            return View(membs);
        }

        public ActionResult Block(string id)
        {
            MembersBLL obj = new MembersBLL();
            bool status = obj.BlockThisMember(id);
            return RedirectToAction("Index", "Members");
        }

        public ActionResult Unblock(string id)
        {
            MembersBLL obj = new MembersBLL();
            bool status = obj.UnBlockThisMember(id);
            return RedirectToAction("Index", "Members");
        }

        public ActionResult MemberDetails(string id)
        {
            MembersBLL obj = new MembersBLL();
            GroupsBLL obj1 = new GroupsBLL();
            GroupsGroup cmd = new GroupsGroup();
            cmd.personalInfo = obj.GetSingleMemberDetails(id);
            cmd.HisGroups = obj1.getHisGroupsDetails(id);
            cmd.JoinedGroups = obj1.getJoinedGroupsDetails(id);
            cmd.HisContacts = obj.GetMemberContactsDetails(id);
            return View(cmd);
        }

        public ActionResult EditMember(string id)
        {
            MembersBLL obj = new MembersBLL();
            GroupsGroup cmd = new GroupsGroup();
            cmd.personalInfo = obj.GetSingleMemberDetails(id);
            return View(cmd);
        }

        public ActionResult UpdateMember(GroupsGroup memb)
        {
            MembersBLL MembBLL = new MembersBLL();
            memb.personalInfo.Updated_By = Convert.ToString(Session["AdminId"]);
            bool status = MembBLL.UpdateMemberDetails(memb.personalInfo);
            return RedirectToAction("Index", "Members");
        }
    }
}