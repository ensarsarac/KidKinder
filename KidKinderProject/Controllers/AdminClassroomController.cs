using KidKinderProject.Context;
using KidKinderProject.Entities;
using KidKinderProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class AdminClassroomController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult ClassroomList()
        {
            return View(context.Classrooms.ToList());
        }
        public ActionResult CreateClassroom()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateClassroom(CreateClassroomViewModel createClassroomViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(createClassroomViewModel);
            }
            var value = new Classroom()
            {
                Description=createClassroomViewModel.Description,
                AgeOfKids=createClassroomViewModel.AgeOfKids,
                TotalSeats=createClassroomViewModel.TotalSeats,
                ClassTime=createClassroomViewModel.ClassTime,
                ImageUrl=createClassroomViewModel.ImageUrl,
                Price=createClassroomViewModel.Price,
                Title=createClassroomViewModel.Title
            };
            context.Classrooms.Add(value);
            context.SaveChanges();
            return RedirectToAction("ClassroomList");
        }
        public ActionResult RemoveClassroom(int id)
        {
            context.Classrooms.Remove(context.Classrooms.Find(id));
            context.SaveChanges();
            return RedirectToAction("ClassroomList");
        }
        public ActionResult UpdateClassroom(int id)
        {
            var value = context.Classrooms.Find(id);
            var model = new UpdateClassroomViewModel()
            {
                TotalSeats=value.TotalSeats,
                AgeOfKids=value.AgeOfKids,
                Title = value.Title,
                Description = value.Description,
                ClassTime = value.ClassTime,
                Price = value.Price,
                ImageUrl = value.ImageUrl,
                ClassroomId = value.ClassroomId,
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateClassroom(UpdateClassroomViewModel model)
        {
            var value = context.Classrooms.Find(model.ClassroomId);
            value.ClassTime = model.ClassTime;
            value.Description = model.Description;
            value.AgeOfKids = model.AgeOfKids;
            value.ImageUrl = model.ImageUrl;
            value.Title = model.Title;
            value.Price = model.Price;
            value.TotalSeats = model.TotalSeats;
            context.SaveChanges();
            return RedirectToAction("ClassroomList");
        }
    }
}