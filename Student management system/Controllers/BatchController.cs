using Student_management_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_management_system.Controllers
{
    public class BatchController : Controller
    {
        cs db = new cs();
        public ActionResult Index()
        {
            return View(db.Batchdb.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost][ActionName("Create")]
        public ActionResult create()
        {
            Batch bd = new Batch();
            TryUpdateModel(bd);
            db.Batchdb.Add(bd);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Batch bd = db.Batchdb.Find(id);
            return View(bd);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Batch bd = db.Batchdb.Find(id);
            return View(bd);
        }
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult edit(int id)
        {
            Batch bd = db.Batchdb.Find(id);
            TryUpdateModel(bd);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Batch bd = db.Batchdb.Find(id);
            return View(bd);
        }
        [HttpPost][ActionName("Delete")]
        public ActionResult delete(int id)
        {
            Batch bd = db.Batchdb.Find(id);
            db.Batchdb.Remove(bd);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}