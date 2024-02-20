using KidKinderProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    [AllowAnonymous]
    public class GalleryController : Controller
    {
        
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _GalleryPartial()
        {
            return PartialView(db.Galleries.ToList());
        }
    }
}