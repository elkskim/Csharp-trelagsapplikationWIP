﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Deceptive, descriptive.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is where Contacts could be.";

            return View();
        }

        public ActionResult Sale()
        {
            return View();
        }
    }
}