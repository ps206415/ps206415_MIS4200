﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ps206415_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Driven student at Ohio University";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Patricia Schneider";

            return View();
        }
    }
}