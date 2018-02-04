using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VAMotel.Controllers
{
    public class PageController : Controller
    {
        public Motel db = new Motel();
        // GET: Page
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Login(string username, string password)
        {
            int result = db.TaiKhoans.Where(x => x.tai_khoan == username.Trim() && x.mat_khau == password.Trim()).Count();
            if (result == 1)
            {
                TaiKhoan account = db.TaiKhoans.Find(username);
                account.mat_khau = "";
                Session["LoginAccount"] = account;

                if (account.loai_tai_khoan == 0)
                {
                    return "admin";
                } else if (account.loai_tai_khoan == 1)
                {
                    return "boss";
                }
                else return "normal";

            } else
            {
                return "false";
            }
        }

        [HttpPost]
        public ActionResult Register()
        {
            return View();
        }
    }
}