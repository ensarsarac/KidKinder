using KidKinderProject.Context;
using KidKinderProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class AdminMailSubscribeController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.MailSubscribes.ToList();
            return View(values);
        }
        public ActionResult CreateMailSubscribe()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateMailSubscribe(MailSubscribe teacher)
        {            
            context.MailSubscribes.Add(teacher);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RemoveMailSubscribe(int id)
        {
            context.MailSubscribes.Remove(context.MailSubscribes.Find(id));
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateMailSubscribe(int id)
        {
            var value = context.MailSubscribes.Find(id);            
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateMailSubscribe(MailSubscribe model)
        {
            var value = context.MailSubscribes.Find(model.MailSubscribeId);
            value.Email = model.Email;
            value.NameSurname = model.NameSurname;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}