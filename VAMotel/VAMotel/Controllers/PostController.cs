using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VAMotel.Controllers
{
    public class PostController : Controller
    {
        public Motel db = new Motel();
        // GET: Post
        public ActionResult Index()
        {
            return View();
        }

        // GET: Post/Detail/Id
        public ActionResult Detail(int id)
        {
            BaiViet post = db.BaiViets.Find(id);
            return View(post);
        }
    }
}