using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using E_Commerce_Web_Application.Entity;

namespace E_Commerce_Web_Application.Controllers
{
    [Authorize(Roles = "admin")]
    public class MainCategoryController : Controller
    {
        private DataContext db = new DataContext();

        // GET: MainCategory
        public ActionResult Index()
        {
            return View(db.MainCategories.ToList());
        }

        // GET: MainCategory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainCategory mainCategory = db.MainCategories.Find(id);
            if (mainCategory == null)
            {
                return HttpNotFound();
            }
            return View(mainCategory);
        }

        // GET: MainCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MainCategory/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MainCategoryName,Description")] MainCategory mainCategory)
        {
            if (ModelState.IsValid)
            {
                db.MainCategories.Add(mainCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mainCategory);
        }

        // GET: MainCategory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainCategory mainCategory = db.MainCategories.Find(id);
            if (mainCategory == null)
            {
                return HttpNotFound();
            }
            return View(mainCategory);
        }

        // POST: MainCategory/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MainCategoryName,Description")] MainCategory mainCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mainCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mainCategory);
        }

        // GET: MainCategory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainCategory mainCategory = db.MainCategories.Find(id);
            if (mainCategory == null)
            {
                return HttpNotFound();
            }
            return View(mainCategory);
        }

        // POST: MainCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MainCategory mainCategory = db.MainCategories.Find(id);
            db.MainCategories.Remove(mainCategory);
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
