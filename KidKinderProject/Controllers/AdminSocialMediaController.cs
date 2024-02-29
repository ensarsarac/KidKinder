using KidKinderProject.Context;
using KidKinderProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class AdminSocialMediaController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia(SocialMedia model)
        {
            context.SocialMedias.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult RemoveSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia model)
        {
            var value = context.SocialMedias.Find(model.SocialMediaId);
            value.Platform = model.Platform;
            value.Icon = model.Icon;
            value.Url = model.Url;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}