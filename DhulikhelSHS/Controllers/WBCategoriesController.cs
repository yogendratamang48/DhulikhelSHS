using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DhulikhelSHS.Models;

namespace DhulikhelSHS.Controllers
{
    [Authorize]
    public class WBCategoriesController : Controller
    {
        

        private DhulikhelDBEntities db = new DhulikhelDBEntities();

        // GET: WBCategories
        public ActionResult Index()
        {
            return View(db.WBCategories.ToList());
        }

        // GET: WBCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WBCategory wBCategory = db.WBCategories.Find(id);
            if (wBCategory == null)
            {
                return HttpNotFound();
            }
            return View(wBCategory);
        }

        // GET: WBCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WBCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryID,CategoryName,CategoryDesc")] WBCategory wBCategory)
        {
            if (ModelState.IsValid)
            {
                db.WBCategories.Add(wBCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wBCategory);
        }

        // GET: WBCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WBCategory wBCategory = db.WBCategories.Find(id);
            if (wBCategory == null)
            {
                return HttpNotFound();
            }
            return View(wBCategory);
        }

        // POST: WBCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryID,CategoryName,CategoryDesc")] WBCategory wBCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wBCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wBCategory);
        }

        // GET: WBCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WBCategory wBCategory = db.WBCategories.Find(id);
            if (wBCategory == null)
            {
                return HttpNotFound();
            }
            return View(wBCategory);
        }

        // POST: WBCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WBCategory wBCategory = db.WBCategories.Find(id);
            db.WBCategories.Remove(wBCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
