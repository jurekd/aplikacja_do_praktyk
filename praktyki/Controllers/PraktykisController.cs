using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using praktyki.Models;

namespace praktyki.Controllers
{
    public class PraktykiController : Controller
    {
        private PraktykiContext db = new PraktykiContext();

        // GET: Praktykis
        public async Task<ActionResult> Index()
        {
            return View(await db.Praktyki.ToListAsync());
        }

        // GET: Praktykis/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Praktyki praktyki = await db.Praktyki.FindAsync(id);
            if (praktyki == null)
            {
                return HttpNotFound();
            }
            return View(praktyki);
        }

        // GET: Praktykis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Praktykis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nazwa,LiczbaMiejc,Opis,Tagi,Wymagania,Kontakt")] Praktyki praktyki)
        {
            if (ModelState.IsValid)
            {
                db.Praktyki.Add(praktyki);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(praktyki);
        }

        // GET: Praktykis/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Praktyki praktyki = await db.Praktyki.FindAsync(id);
            if (praktyki == null)
            {
                return HttpNotFound();
            }
            return View(praktyki);
        }

        // POST: Praktykis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Nazwa,LiczbaMiejc,Opis,Tagi,Wymagania,Kontakt")] Praktyki praktyki)
        {
            if (ModelState.IsValid)
            {
                db.Entry(praktyki).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(praktyki);
        }

        // GET: Praktykis/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Praktyki praktyki = await db.Praktyki.FindAsync(id);
            if (praktyki == null)
            {
                return HttpNotFound();
            }
            return View(praktyki);
        }

        // POST: Praktykis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Praktyki praktyki = await db.Praktyki.FindAsync(id);
            db.Praktyki.Remove(praktyki);
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
