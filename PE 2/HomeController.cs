﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PE_02.Controllers
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
        public ActionResult Bai1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
         public ActionResult Bai2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Bai3()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Bai4()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Bai5()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Bai6()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}