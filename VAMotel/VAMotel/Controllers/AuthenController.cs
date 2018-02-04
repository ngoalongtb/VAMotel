using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VAMotel.Controllers
{

    //extends BaseController
    public class AuthenController : Controller
    {
        //no view
        public ActionResult Logout()
        {
            return RedirectToAction("Home");
        }

        public ActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangeProfile()
        {
            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult ChangePassword()
        {
            return RedirectToAction("Home");
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