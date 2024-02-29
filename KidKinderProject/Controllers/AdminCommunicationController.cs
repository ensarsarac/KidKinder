using KidKinderProject.Context;
using KidKinderProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class AdminCommunicationController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Communications.FirstOrDefault();
            return View(values);
        }

        public ActionResult UpdateCommunication(int id)
        {
            var value = context.Communications.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCommunication(Communication model)
        {
            var value = context.Communications.Find(model.CommunicationId);
            value.Description = model.Description;
            value.Address = model.Address;
            value.PhoneNumber = model.PhoneNumber;
            value.Email = model.Email;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}