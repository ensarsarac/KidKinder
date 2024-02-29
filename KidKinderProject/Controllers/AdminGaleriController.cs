using KidKinderProject.Context;
using KidKinderProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class AdminGaleriController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View(context.Galleries.ToList());
        }
        public ActionResult CreateImage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateImage(Gallery model)
        {
            model.Status = false;
            context.Galleries.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ImageChangeStatusTrue(int id)
        {
            var value = context.Galleries.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ImageChangeStatusFalse(int id)
        {
            var value = context.Galleries.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateImage(int id)
        {            
            var value = context.Galleries.Find(id);           
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateImage(Gallery model)
        {
            var value = context.Galleries.Find(model.GalleryId);
            value.Path = model.Path;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}