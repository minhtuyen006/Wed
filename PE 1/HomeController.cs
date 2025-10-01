using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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
        public ActionResult Lab01acau1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Lab01acau23()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Lab01b1cau12345()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Lab01b2cau1234()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult home()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult regist()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult repass()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult PEdevelopment()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}