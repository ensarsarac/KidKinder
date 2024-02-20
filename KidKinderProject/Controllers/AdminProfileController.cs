using KidKinderProject.Context;
using KidKinderProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class AdminProfileController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var onlineUser = context.Admins.Where(x => x.Username == User.Identity.Name).FirstOrDefault();
            AdminViewModel model = new AdminViewModel()
            {
                AdminId=onlineUser.AdminId,
                Username = onlineUser.Username,
                ImageUrl=onlineUser.ImageUrl,
                Password=onlineUser.Password,
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(AdminViewModel model)
        {
            var onlineUser = context.Admins.Where(x => x.AdminId == model.AdminId).FirstOrDefault();
            if(model.ImageUrl != null)
            {
                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string exp = Path.GetExtension(Request.Files[0].FileName);
                string filePath = "~/AdminImages/" + fileName+exp;
                Request.Files[0].SaveAs(Server.MapPath(filePath));
                onlineUser.ImageUrl = "/AdminImages/" + fileName+exp;
            }
            onlineUser.Username = model.Username;
            onlineUser.Password = model.Password;
            context.SaveChanges();
            return RedirectToAction("SignOut", "AdminLogin");
        }


    }
}