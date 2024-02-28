using KidKinderProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class DashboardController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            ViewBag.ResimCizimCount = context.Teachers.Where(x => x.BranchID == (context.Branches.Where(y => y.BranchName == "Resim Çizim").Select(y => y.BranchID).FirstOrDefault())).Count();

            ViewBag.AvgPrice = context.Classrooms.Average(x => x.Price).ToString("0.00");
            return View();
        }
    }
}