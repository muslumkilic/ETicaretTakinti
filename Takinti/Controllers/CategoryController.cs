using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Takinti.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

            // slug dan gelen parametreye göre kategöri gösterilecek
        public ActionResult Index(string slug="")
        {
            return View();
        }
    }
}