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
            var values = db.Galleries.Where(x => x.Status == true).Take(6).ToList();
            return PartialView(values);
        }
    }
}