using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VAMotel.Controllers
{
    public class PartialController : Controller
    {
        public Motel db = new Motel();
        // GET: Partial
        public ActionResult Index()
        {
            return View();
        }
        // GET: Partial
        public ActionResult SideBarBottom()
        {
            List<BaiViet> posts = db.BaiViets.OrderByDescending(x => x.do_uu_tien).Take(7).ToList();
            return View(posts);
        }
        // GET: Partial
        public ActionResult Footer()
        {
            return View();
        }

        // GET: Partial
        public ActionResult Menu()
        {
            List<DanhMuc> categories = db.DanhMucs.Take(7).ToList();
            return View(categories);
        }

        public ActionResult HeaderTop()
        {
            bool authen = true;
            if (authen)
            {
                return View("HeaderTopAuthen");
            }
            else
            {
                return View("HeaderTopNotAuthen");
            }
        }
    }
}