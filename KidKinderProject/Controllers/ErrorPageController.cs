using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    [AllowAnonymous]
    public class ErrorPageController : Controller
    {
        // GET: ErrorPage
        public ActionResult NotFound404()
        {
            return View();
        }
    }
}