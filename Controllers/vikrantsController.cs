using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using college.Models;

namespace college.Controllers
{
    public class vikrantsController : Controller
    {
        private rahul db = new rahul();

        // GET: vikrants
        public async Task<ActionResult> Index()
        {
            return View(await db.vikrants.ToListAsync());
        }

        // GET: vikrants/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vikrant vikrant = await db.vikrants.FindAsync(id);
            if (vikrant == null)
            {
                return HttpNotFound();
            }
            return View(vikrant);
        }

        // GET: vikrants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vikrants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,name,Address,Gender,Age,Contact")] vikrant vikrant)
        {
            if (ModelState.IsValid)
            {
                db.vikrants.Add(vikrant);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(vikrant);
        }

        // GET: vikrants/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vikrant vikrant = await db.vikrants.FindAsync(id);
            if (vikrant == null)
            {
                return HttpNotFound();
            }
            return View(vikrant);
        }

        // POST: vikrants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,name,Address,Gender,Age,Contact")] vikrant vikrant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vikrant).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(vikrant);
        }

        // GET: vikrants/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vikrant vikrant = await db.vikrants.FindAsync(id);
            if (vikrant == null)
            {
                return HttpNotFound();
            }
            return View(vikrant);
        }

        // POST: vikrants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            vikrant vikrant = await db.vikrants.FindAsync(id);
            db.vikrants.Remove(vikrant);
            await db.SaveChangesAsync();
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
