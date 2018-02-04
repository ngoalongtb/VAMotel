using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VAMotel.Controllers
{
    public class HomeController : Controller
    {
        public Motel db = new Motel();
        // GET: Home
        public ActionResult Index()
        {
            List<BaiViet> posts;
            if (Request.Params["price_from"] != null && Request.Params["price_to"] != null)
            {
                int fromPrice = int.Parse(Request.Params["price_from"])* 1000000;
                int toPrice = int.Parse(Request.Params["price_to"]) * 1000000;
                posts = db.BaiViets.Where(x => x.gia_ca >= fromPrice && x.gia_ca <= toPrice).Take(10).ToList();
            } else
            {
                posts = db.BaiViets.Take(10).ToList();
            }
            return View(posts);
        }
    }
}