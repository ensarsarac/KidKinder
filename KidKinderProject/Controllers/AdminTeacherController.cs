using KidKinderProject.Context;
using KidKinderProject.Entities;
using KidKinderProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class AdminTeacherController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult TeacherList()
        {
            return View(context.Teachers.ToList());
        }
        public ActionResult CreateTeacher()
        {
            return View();
        }        
        [HttpPost]
        public ActionResult CreateTeacher(CreateTeacherViewModel teacher)
        {
           
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Form bilgilerini eksiksiz doldurun");
                return View(teacher);
            }
            var newTeacher = new Teacher()
            {
                Name = teacher.Name,
                FacebookUrl = teacher.FacebookUrl,
                ImageUrl = teacher.ImageUrl,
                LinkedinUrl = teacher.LinkedinUrl,
                Title = teacher.Title,
                TwitterUrl = teacher.TwitterUrl
            };
            context.Teachers.Add(newTeacher);
            context.SaveChanges();
            return RedirectToAction("TeacherList", "AdminTeacher");
        }

        public ActionResult RemoveTeacher(int id)
        {
            context.Teachers.Remove(context.Teachers.Find(id));
            context.SaveChanges();
            return RedirectToAction("TeacherList", "AdminTeacher");
        }

        [HttpGet]
        public ActionResult UpdateTeacher(int id)
        {
            var value=context.Teachers.Find(id);
            var teacher = new UpdateTeacherViewModel()
            {
                TeacherId = id,
                FacebookUrl = value.FacebookUrl,
                ImageUrl = value.ImageUrl,
                LinkedinUrl = value.LinkedinUrl,
                Name = value.Name,
                Title = value.Title,
                TwitterUrl = value.TwitterUrl,
            };
            return View(teacher);
        }
        [HttpPost]
        public ActionResult UpdateTeacher(UpdateTeacherViewModel model)
        {
            var value = context.Teachers.Find(model.TeacherId);
            value.Title = model.Title;
            value.Name = model.Name;
            value.ImageUrl = model.ImageUrl;
            value.FacebookUrl = model.FacebookUrl;
            value.TwitterUrl = model.TwitterUrl;
            value.LinkedinUrl = model.LinkedinUrl;
            context.SaveChanges();
            return RedirectToAction("TeacherList", "AdminTeacher");
        }
    }
}