using KidKinderProject.Context;
using KidKinderProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class AdminServiceController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Services.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateService(Service model)
        {
            context.Services.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult RemoveService(int id)
        {
            var value = context.Services.Find(id);
            context.Services.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateService(int id)
        {
            var value = context.Services.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateService(Service model)
        {
            var value = context.Services.Find(model.ServiceId);
            value.Title = model.Title;
            value.Description = model.Description;
            value.IconUrl = model.IconUrl;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}