using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VAMotel.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login()
        {
            // add session
            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult Register()
        {
            return View();
        }
    }
}