using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VAMotel.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        public ActionResult Index()
        {
            return View();
        }
        // GET: Partial
        public ActionResult SideBarBottom()
        {
            return View();
        }
        // GET: Partial
        public ActionResult Footer()
        {
            return View();
        }
    }
}