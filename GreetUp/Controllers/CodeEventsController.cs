using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GreetUp.Models;

namespace GreetUp.Controllers
{
    public class CodeEventsController : Controller
    {
        private GreetUpContext db = new GreetUpContext();

        // GET: CodeEvents
        public ActionResult Index()
        {
            return View(db.CodeEvents.ToList());
        }

        // GET: CodeEvents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeEvent codeEvent = db.CodeEvents.Find(id);
            if (codeEvent == null)
            {
                return HttpNotFound();
            }
            return View(codeEvent);
        }

        // GET: CodeEvents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CodeEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EventName,EventDate")] CodeEvent codeEvent)
        {
            if (ModelState.IsValid)
            {
                db.CodeEvents.Add(codeEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(codeEvent);
        }

        // GET: CodeEvents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeEvent codeEvent = db.CodeEvents.Find(id);
            if (codeEvent == null)
            {
                return HttpNotFound();
            }
            return View(codeEvent);
        }

        // POST: CodeEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EventName,EventDate")] CodeEvent codeEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(codeEvent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(codeEvent);
        }

        // GET: CodeEvents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeEvent codeEvent = db.CodeEvents.Find(id);
            if (codeEvent == null)
            {
                return HttpNotFound();
            }
            return View(codeEvent);
        }

        // POST: CodeEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CodeEvent codeEvent = db.CodeEvents.Find(id);
            db.CodeEvents.Remove(codeEvent);
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
