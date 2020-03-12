﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        

        public ActionResult Designs()
        {
            ViewBag.Message = "Designs Page";
            return View();
        }

        public ActionResult Cart()
        {
            ViewBag.Message = "Designs Page";
            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Products Page";
            return View();
        }
    }
}