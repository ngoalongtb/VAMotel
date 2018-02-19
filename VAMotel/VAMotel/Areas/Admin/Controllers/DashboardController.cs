using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VAMotel.Areas.Admin.Models;
using VAMotel.Controllers;

namespace VAMotel.Areas.Admin.Controllers
{
    public class DashboardController : AdminController
    {
        public Motel db = new Motel();
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            DashboardModel model = new DashboardModel();
            model.NumberOfAccounts = db.TaiKhoans.Count();
            model.NumberOfCategories = db.DanhMucs.Count();
            model.NumberOfPosts = db.BaiViets.Count();
            model.NumberOfGroups = db.KhuTroes.Count();
            return View(model);
        }
    }
}