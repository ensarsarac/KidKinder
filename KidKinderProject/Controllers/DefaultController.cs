using KidKinderProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class DefaultController : Controller
    {
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _FeaturePartial()
        {
            var value = db.Features.FirstOrDefault();
            return PartialView(value);
        }
    }
}