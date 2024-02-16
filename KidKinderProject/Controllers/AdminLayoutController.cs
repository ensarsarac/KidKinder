using KidKinderProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _AdminHeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult _AdminLoaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult _AdminNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult _AdminNotificationPartial()
        {
            return PartialView(context.Notifications.ToList());
        }
        public PartialViewResult _AdminSideBarPartial()
        {
            return PartialView();
        }
        public PartialViewResult _AdminScriptPartial()
        {
            return PartialView();
        }
        public PartialViewResult _AdminSamplePagePartial()
        {
            return PartialView();
        }
        public PartialViewResult _AdminNavbarProfileHeaderPartial()
        {
            return PartialView();
        }
    }
}