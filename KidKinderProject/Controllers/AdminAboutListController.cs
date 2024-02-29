using KidKinderProject.Context;
using KidKinderProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class AdminAboutListController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.AboutLists.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAboutList()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAboutList(AboutList model)
        {
            context.AboutLists.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult RemoveAboutList(int id)
        {
            var value = context.AboutLists.Find(id);
            context.AboutLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateAboutList(int id)
        {
            var value = context.AboutLists.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAboutList(AboutList model)
        {
            var value = context.AboutLists.Find(model.AboutListId);
            value.Description = model.Description;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}