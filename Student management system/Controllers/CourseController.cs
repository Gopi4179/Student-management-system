using Student_management_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_management_system.Controllers
{
    public class CourseController : Controller
    {
        cs db = new cs();
        public ActionResult Index()
        {

            return View(db.courses.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost][ActionName("Create")]
        public ActionResult create()
        {
            Course cc = new Course();
            TryUpdateModel(cc);
            db.courses.Add(cc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
        public ActionResult Details(int? id)
        {
          
            Course cc = db.courses.Find(id);
            return View(cc);
        }
        [HttpGet]
        public ActionResult Update(int? id)
        {
            Course cc = db.courses.Find(id);
            return View(cc);
        }
        [HttpPost]
        [ActionName("Update")]
        public ActionResult UPdate(int? id)
        {
            Course cc = db.courses.Find(id);
            UpdateModel(cc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Course cc = db.courses.Find(id);
            return View(cc);
        }
        [HttpPost][ActionName("Delete")]
        public ActionResult deleted(int id)
        {
            Course cc = db.courses.Find(id);
            db.courses.Remove(cc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}