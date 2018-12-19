using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CHDWebApp.DAL;
using CHDWebApp.Models;

namespace CHDWebApp.Controllers
{
    public class PickListTablesController : Controller
    {
        private CHDWebApplicationContext db = new CHDWebApplicationContext();

        // GET: PickListTables
        public ActionResult Index()
        {
            return View(db.PickListTables.ToList());
        }

        // GET: PickListTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickListTable pickListTable = db.PickListTables.Find(id);
            if (pickListTable == null)
            {
                return HttpNotFound();
            }
            return View(pickListTable);
        }

        // GET: PickListTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PickListTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PickId,PickType,PickValue,NationalCodes")] PickListTable pickListTable)
        {
            if (ModelState.IsValid)
            {
                db.PickListTables.Add(pickListTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pickListTable);
        }

        // GET: PickListTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickListTable pickListTable = db.PickListTables.Find(id);
            if (pickListTable == null)
            {
                return HttpNotFound();
            }
            return View(pickListTable);
        }

        // POST: PickListTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PickId,PickType,PickValue,NationalCodes")] PickListTable pickListTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pickListTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pickListTable);
        }

        // GET: PickListTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickListTable pickListTable = db.PickListTables.Find(id);
            if (pickListTable == null)
            {
                return HttpNotFound();
            }
            return View(pickListTable);
        }

        // POST: PickListTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PickListTable pickListTable = db.PickListTables.Find(id);
            db.PickListTables.Remove(pickListTable);
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
