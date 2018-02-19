using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using VAMotel.Controllers;

namespace VAMotel.Areas.Admin.Controllers
{
    public class GroupsController : BaseController
    {
        private Motel db = new Motel();

        // GET: Admin/Groups
        public ActionResult Index()
        {
            TaiKhoan loginAccount = Session["LoginAccount"] as TaiKhoan;
            var khuTroes = db.KhuTroes.Where(x=> x.TaiKhoan.tai_khoan == loginAccount.tai_khoan);
            return View(khuTroes.ToList());
        }

        // GET: Admin/Groups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhuTro khuTro = db.KhuTroes.Find(id);
            if (khuTro == null)
            {
                return HttpNotFound();
            }
            return View(khuTro);
        }

        // GET: Admin/Groups/Create
        public ActionResult Create()
        {
            ViewBag.chu_tro = new SelectList(db.TaiKhoans, "tai_khoan", "mat_khau");
            return View();
        }

        // POST: Admin/Groups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma,da_xoa,dia_chi,chu_tro")] KhuTro khuTro)
        {
            if (ModelState.IsValid)
            {
                TaiKhoan loginAccount = Session["LoginAccount"] as TaiKhoan;
                khuTro.chu_tro = loginAccount.tai_khoan;
                db.KhuTroes.Add(khuTro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.chu_tro = new SelectList(db.TaiKhoans, "tai_khoan", "mat_khau", khuTro.chu_tro);
            return View(khuTro);
        }

        // GET: Admin/Groups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhuTro khuTro = db.KhuTroes.Find(id);
            if (khuTro == null)
            {
                return HttpNotFound();
            }
            ViewBag.chu_tro = new SelectList(db.TaiKhoans, "tai_khoan", "mat_khau", khuTro.chu_tro);
            return View(khuTro);
        }

        // POST: Admin/Groups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma,da_xoa,dia_chi,chu_tro")] KhuTro khuTro)
        {
            if (ModelState.IsValid)
            {
                TaiKhoan loginAccount = Session["LoginAccount"] as TaiKhoan;
                khuTro.chu_tro = loginAccount.tai_khoan;
                db.Entry(khuTro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.chu_tro = new SelectList(db.TaiKhoans, "tai_khoan", "mat_khau", khuTro.chu_tro);
            return View(khuTro);
        }

        // GET: Admin/Groups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhuTro khuTro = db.KhuTroes.Find(id);
            if (khuTro == null)
            {
                return HttpNotFound();
            }
            return View(khuTro);
        }

        // POST: Admin/Groups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KhuTro khuTro = db.KhuTroes.Find(id);
            db.KhuTroes.Remove(khuTro);
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
