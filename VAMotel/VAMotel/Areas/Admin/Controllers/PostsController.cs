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
    public class PostsController : Controller
    {
        private Motel db = new Motel();

        // GET: Admin/Posts
        public ActionResult Index()
        {
            var baiViets = db.BaiViets.Include(b => b.DanhMuc).Include(b => b.TaiKhoan);
            return View(baiViets.ToList());
        }

        // GET: Admin/Posts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaiViet baiViet = db.BaiViets.Find(id);
            if (baiViet == null)
            {
                return HttpNotFound();
            }
            return View(baiViet);
        }

        // GET: Admin/Posts/Create
        public ActionResult Create()
        {
            ViewBag.ma_danh_muc = new SelectList(db.DanhMucs, "ma", "ten");
            return View();
        }

        // POST: Admin/Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "ma,tieu_de,hinh_anh,noi_dung,ngay_tao,nguoi_tao,dia_chi,dien_tich,gia_ca,do_uu_tien,ma_danh_muc")] BaiViet baiViet)
        {
            if (ModelState.IsValid)
            {
                baiViet.noi_dung = HttpUtility.HtmlDecode(baiViet.noi_dung.Replace(System.Environment.NewLine, ""));
                baiViet.ngay_tao = DateTime.Now;
                baiViet = db.BaiViets.Add(baiViet);
                db.SaveChanges();

                if (Request.Files.Count > 0 && Request.Files[0].FileName.Trim() != "")
                {
                    string[] _arr = Request.Files[0].FileName.Split('.');
                    string type = _arr[_arr.Length - 1];

                    baiViet.hinh_anh = baiViet.ma + "." + type;
                    Request.Files[0].SaveAs(Server.MapPath("~/Public/upload/post/") + baiViet.hinh_anh);
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ma_danh_muc = new SelectList(db.DanhMucs, "ma", "ten", baiViet.ma_danh_muc);
            return View(baiViet);
        }

        // GET: Admin/Posts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaiViet baiViet = db.BaiViets.Find(id);
            if (baiViet == null)
            {
                return HttpNotFound();
            }
            ViewBag.ma_danh_muc = new SelectList(db.DanhMucs, "ma", "ten", baiViet.ma_danh_muc);
            ViewBag.nguoi_tao = new SelectList(db.TaiKhoans, "tai_khoan", "mat_khau", baiViet.nguoi_tao);
            return View(baiViet);
        }

        // POST: Admin/Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "ma,tieu_de,hinh_anh,noi_dung,ngay_tao,nguoi_tao,dia_chi,dien_tich,gia_ca,do_uu_tien,ma_danh_muc")] BaiViet baiViet)
        {
            if (ModelState.IsValid)
            {
                baiViet.noi_dung = HttpUtility.HtmlDecode(baiViet.noi_dung.Replace(System.Environment.NewLine, ""));
                if (Request.Files.Count > 0 && Request.Files[0].FileName.Trim() != "")
                {
                    string[] _arr = Request.Files[0].FileName.Split('.');
                    string type = _arr[_arr.Length - 1];

                    baiViet.hinh_anh = baiViet.ma + "." + type;
                    Request.Files[0].SaveAs(Server.MapPath("~/Public/upload/post/") + baiViet.hinh_anh);
                }

                db.Entry(baiViet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ma_danh_muc = new SelectList(db.DanhMucs, "ma", "ten", baiViet.ma_danh_muc);
            ViewBag.nguoi_tao = new SelectList(db.TaiKhoans, "tai_khoan", "mat_khau", baiViet.nguoi_tao);
            return View(baiViet);
        }

        // GET: Admin/Posts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaiViet baiViet = db.BaiViets.Find(id);
            if (baiViet == null)
            {
                return HttpNotFound();
            }
            return View(baiViet);
        }

        // POST: Admin/Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BaiViet baiViet = db.BaiViets.Find(id);
            db.BaiViets.Remove(baiViet);
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
