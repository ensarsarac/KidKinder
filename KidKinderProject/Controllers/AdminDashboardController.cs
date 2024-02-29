using KidKinderProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class AdminDashboardController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            ViewBag.ResimCizimCount = context.Teachers.Where(x => x.BranchID == (context.Branches.Where(y => y.BranchName == "Resim Çizim").Select(y => y.BranchID).FirstOrDefault())).Count();

            ViewBag.AvgPrice = context.Classrooms.Average(x => x.Price).ToString("0.00");
            ViewBag.TotalService = context.Services.Count();
            var values = context.Teachers.GroupBy(x => x.BranchID).Select(x => new
            {
                Key = x.Key,
                Count = x.Count()
            }).OrderByDescending(x => x.Count).FirstOrDefault();

            ViewBag.MaxBranch = context.Branches.Where(x => x.BranchID == values.Key).Select(x => x.BranchName).FirstOrDefault();
           var maxbranch = context.Branches.Where(x => x.BranchID == values.Key).Select(x => x.BranchName).FirstOrDefault();
            ViewBag.MaxBranchTeacher = context.Teachers.Where(x => x.BranchID == (context.Branches.Where(y => y.BranchName == maxbranch.ToString()).Select(y => y.BranchID).FirstOrDefault())).Count();
            ViewBag.TotalBranch = context.Branches.Count();
            ViewBag.LastClassroom = context.Classrooms.OrderByDescending(x => x.ClassroomId).Select(x => x.Title).FirstOrDefault();
            ViewBag.TotalMessage = context.Contacts.Count();
            ViewBag.AdminCount = context.Admins.Count();
            ViewBag.RezCount = context.BookASeats.Count();
            return View();
        }
        public PartialViewResult _DashboardTeacherPartial()
        {
            
            return PartialView(context.Teachers.ToList());
        }
        public PartialViewResult _DashboardSocialMediaPartial()
        {

            return PartialView(context.SocialMedias.ToList());
        }
        public PartialViewResult _DashboardClassroomPartial()
        {

            return PartialView(context.Classrooms.ToList());
        }
    }
}