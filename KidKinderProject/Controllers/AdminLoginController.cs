using KidKinderProject.Context;
using KidKinderProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KidKinderProject.Controllers
{
    [AllowAnonymous]
    public class AdminLoginController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var adminInfo = context.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if(adminInfo != null)
            {
                FormsAuthentication.SetAuthCookie(admin.Username, false);
                Session["Username"] = adminInfo.Username.ToString();
                return RedirectToAction("Index", "AdminDashboard");
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı!!");
                return View(admin);
            }
        }
    
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "AdminLogin");
        }
    }
}