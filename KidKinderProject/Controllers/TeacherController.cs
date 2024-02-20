using KidKinderProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    [AllowAnonymous]
    public class TeacherController : Controller
    {
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _AllTeacherPartial()
        {
            return PartialView(db.Teachers.ToList());
        }
    }
}