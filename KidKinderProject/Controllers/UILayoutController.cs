using KidKinderProject.Context;
using KidKinderProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    [AllowAnonymous]
    public class UILayoutController : Controller
    {
        KidKinderContext db = new KidKinderContext();
        public PartialViewResult _HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult _NavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult _HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult _FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult _ScriptsPartial()
        {
            return PartialView();
        }
        public PartialViewResult _FeaturePartial()
        {
            var value = db.Features.FirstOrDefault();
            return PartialView(value);
        }
        public PartialViewResult _ServicePartial()
        {
            var values = db.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult _AboutPartial()
        {
            var value = db.Abouts.FirstOrDefault();
            return PartialView(value);
        }
        public PartialViewResult _AboutListPartial()
        {
            var values = db.AboutLists.ToList();
            return PartialView(values);
        }
        public PartialViewResult _ClassRoomPartial()
        {
            var values = db.Classrooms.ToList();
            return PartialView(values);
        }
        public PartialViewResult _BookASeatPartial()
        {

            return PartialView();
        }
        public PartialViewResult _BookASeatNowPartial()
        {
            ViewBag.ClassRoom = new SelectList(db.Classrooms.ToList(), "ClassroomId", "Title");
            return PartialView();
        }
        public PartialViewResult _TeachersPartial()
        {
            var values = db.Teachers.Take(4).ToList();
            return PartialView(values);
        }

        public PartialViewResult _TestimonialPartial()
        {
            var values = db.Testimonials.ToList();
            return PartialView(values);
        }
        public PartialViewResult _CommunicationPartial()
        {
            var value = db.Communications.FirstOrDefault();
            return PartialView(value);
        }
        public PartialViewResult _MailSubscribePartial()
        {

            return PartialView();
        }
        public PartialViewResult _SocialMediaPartial()
        {
            var values = db.SocialMedias.ToList();
            return PartialView(values);
        }
        [HttpPost]
        public ActionResult BookNow(BookASeat bookASeat)
        {
            db.BookASeats.Add(bookASeat);
            db.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
        [HttpPost]
        public ActionResult MailSubscribe(MailSubscribe mailSubscribe)
        {
            db.MailSubscribes.Add(mailSubscribe);
            db.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
    }
}