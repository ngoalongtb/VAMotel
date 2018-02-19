using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.EF;

namespace VAMotel.Areas.Admin.Controllers
{
    public class RoomsController : Controller
    {
        private Motel db = new Motel();

        // GET: Admin/Rooms
        public ActionResult Index()
        {
            int groupId = int.Parse(Request.Params["groupId"]);
            ViewBag.GroupId = groupId;
            var phongTroes = db.PhongTroes.Where(x=>x.ma_khu_tro == groupId);
            return View(phongTroes.ToList());
        }

        // GET: Admin/Rooms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhongTro phongTro = db.PhongTroes.Find(id);
            if (phongTro == null)
            {
                return HttpNotFound();
            }
            return View(phongTro);
        }

        // GET: Admin/Rooms/Create/GroupId
        public ActionResult Create(int? id)
        {
            ViewBag.ma_khu_tro = id;
            return View();
        }

        // POST: Admin/Rooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma,so_phong,ma_khu_tro,nguoi_thue,cmtnd")] PhongTro phongTro)
        {
            if (ModelState.IsValid)
            {
                db.PhongTroes.Add(phongTro);
                db.SaveChanges();
                return RedirectToRoute("/Admin/Rooms/Index?groupId=" + phongTro.ma_khu_tro);
            }

            ViewBag.ma_khu_tro = new SelectList(db.KhuTroes, "ma", "dia_chi", phongTro.ma_khu_tro);
            return View(phongTro);
        }

        // GET: Admin/Rooms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhongTro phongTro = db.PhongTroes.Find(id);
            if (phongTro == null)
            {
                return HttpNotFound();
            }
            ViewBag.ma_khu_tro = new SelectList(db.KhuTroes, "ma", "dia_chi", phongTro.ma_khu_tro);
            return View(phongTro);
        }

        // POST: Admin/Rooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma,so_phong,ma_khu_tro,nguoi_thue,cmtnd")] PhongTro phongTro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phongTro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToRoute("/Admin/Rooms/Index?groupId=" + phongTro.ma_khu_tro);
            }
            ViewBag.ma_khu_tro = new SelectList(db.KhuTroes, "ma", "dia_chi", phongTro.ma_khu_tro);
            return View(phongTro);
        }

        // GET: Admin/Rooms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhongTro phongTro = db.PhongTroes.Find(id);
            if (phongTro == null)
            {
                return HttpNotFound();
            }
            return View(phongTro);
        }

        // POST: Admin/Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhongTro phongTro = db.PhongTroes.Find(id);
            db.PhongTroes.Remove(phongTro);
            db.SaveChanges();
            return RedirectToRoute("/Admin/Rooms/Index?groupId=" + phongTro.ma_khu_tro);
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
