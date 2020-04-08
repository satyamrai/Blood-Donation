using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Blood_Donation.Models;
using Microsoft.Owin.Logging;
using WebGrease.Activities;

namespace Blood_Donation.Controllers
{
    //[Authorize]
    public class DonorResgistrationsController : Controller
    {
        private DonorRegistrationContext db = new DonorRegistrationContext();
       

        // GET: DonorResgistrations
        public ActionResult Index(string SearchTerm)
        {
            if (!String.IsNullOrEmpty(SearchTerm))
            {                
                return View(db.DonorResgistrations.Where(x=>x.Name==SearchTerm).ToList());
            }
            return View(db.DonorResgistrations.ToList());
        }


        // GET: DonorResgistrations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonorResgistration donorResgistration = db.DonorResgistrations.Find(id);
            if (donorResgistration == null)
            {
                return HttpNotFound();
            }
            return View(donorResgistration);
        }

        // GET: DonorResgistrations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonorResgistrations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "donorID,Name,Mobile,Email,Blood,Address,HospitalName")] DonorResgistration donorResgistration)
        {
            if (ModelState.IsValid)
            {
                db.DonorResgistrations.Add(donorResgistration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(donorResgistration);
        }

        // GET: DonorResgistrations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonorResgistration donorResgistration = db.DonorResgistrations.Find(id);
            if (donorResgistration == null)
            {
                return HttpNotFound();
            }
            return View(donorResgistration);
        }

        // POST: DonorResgistrations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "donorID,Name,Mobile,Email,Blood,Address,HospitalName")] DonorResgistration donorResgistration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donorResgistration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(donorResgistration);
        }

        // GET: DonorResgistrations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonorResgistration donorResgistration = db.DonorResgistrations.Find(id);
            if (donorResgistration == null)
            {
                return HttpNotFound();
            }
            return View(donorResgistration);
        }

        // POST: DonorResgistrations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DonorResgistration donorResgistration = db.DonorResgistrations.Find(id);
            db.DonorResgistrations.Remove(donorResgistration);
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
