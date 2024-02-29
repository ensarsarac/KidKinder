﻿using KidKinderProject.Context;
using KidKinderProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinderProject.Controllers
{
    public class AdminBranchController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Branches.ToList();
            return View(values);
        }
        public ActionResult CreateBranch()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult CreateBranch(Branch model)
        {
            context.Branches.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult RemoveBranch(int id)
        {
            var value = context.Branches.Find(id);
            context.Branches.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateBranch(int id)
        {
            var value = context.Branches.Find(id);            
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateBranch(Branch model)
        {
            var value = context.Branches.Find(model.BranchID);
            value.BranchName = model.BranchName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}