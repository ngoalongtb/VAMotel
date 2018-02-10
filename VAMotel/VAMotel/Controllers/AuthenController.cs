using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VAMotel.Controllers
{

    //extends BaseController
    public class AuthenController : BaseController
    {
        public Motel db = new Motel();
        //no view
        public ActionResult Logout()
        {
            Session.Remove("LoginAccount");
            return RedirectToAction("Index");
        }

        public ActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangeProfile(TaiKhoan taiKhoan)
        {
            TaiKhoan loginAccount = (TaiKhoan)Session["LoginAccount"];

            TaiKhoan _account = db.TaiKhoans.Find(loginAccount.tai_khoan);

            _account.ten = taiKhoan.ten;
            _account.ten_hien_thi = taiKhoan.ten_hien_thi;
            _account.so_dien_thoai = taiKhoan.so_dien_thoai;

            if (Request.Files.Count > 0 && Request.Files[0].FileName.Trim() != "")
            {
                string[] _arr = Request.Files[0].FileName.Split('.');
                string type = _arr[_arr.Length - 1];

                taiKhoan.hinh_anh = taiKhoan.tai_khoan + "." + type;
                Request.Files[0].SaveAs(Server.MapPath("~/Public/upload/account/") + taiKhoan.hinh_anh);
            }

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public string ChangePassword(string oldPassword, string password)
        {
            TaiKhoan loginAccount = (TaiKhoan)Session["LoginAccount"];

            TaiKhoan _account = db.TaiKhoans.Find(loginAccount.tai_khoan);
            if (_account.mat_khau == oldPassword)
            {
                _account.mat_khau = password;
                db.SaveChanges();
                return "true";
            }
            else return "false";
        }

        public ActionResult UploadPost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadPost(BaiViet post)
        {
            return RedirectToAction("Home");
        }
    }
}