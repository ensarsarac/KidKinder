using KidKinderProject.Context;
using KidKinderProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class AdminStatisticController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult CategoryChart()
        {
            return Json(ChartList(), JsonRequestBehavior.AllowGet);
        }
       public List<ChartViewModel> ChartList()
        {
            List<ChartViewModel> list = new List<ChartViewModel>();
            list.Add(new ChartViewModel() { CategoryCount = 1, CategoryName = "C#" });
            list.Add(new ChartViewModel() { CategoryCount = 2, CategoryName = "Asp.Net" });
            list.Add(new ChartViewModel() { CategoryCount = 3, CategoryName = "Asp.Net Core" });
            list.Add(new ChartViewModel() { CategoryCount = 4, CategoryName = "Flutter" });
            list.Add(new ChartViewModel() { CategoryCount = 5, CategoryName = "Java" });
            return list;
        }
    }
}