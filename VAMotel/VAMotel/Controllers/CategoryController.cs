using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VAMotel.Controllers
{
    public class CategoryController : Controller
    {
        public Motel db = new Motel();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        // GET: Category/Detail/id
        public ActionResult Detail(int id)
        {
            DanhMuc category = db.DanhMucs.Find(id);
            ViewBag.Category = category;

            List<BaiViet> posts;
            if (Request.Params["price_from"] != null && Request.Params["price_to"] != null)
            {
                int fromPrice = int.Parse(Request.Params["price_from"]) * 1000000;
                int toPrice = int.Parse(Request.Params["price_to"]) * 1000000;
                posts = db.BaiViets.Where(x => x.ma_danh_muc == id && x.gia_ca >= fromPrice && x.gia_ca <= toPrice).Take(10).ToList();
            }
            else
            {
                posts = category.BaiViets.Where(x=>x.ma_danh_muc == id).Take(10).ToList();
            }
            return View(posts);
        }
    }
}