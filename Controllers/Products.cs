using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStore.Controllers
{
    public class Products : Controller
    {
        // GET: Products
        public ActionResult Mugs()
        {
            return View();

        }
    }
}