﻿using HW1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var myData = new HomeViewModel
            {
                PhoneCount = 10,
                UserCount = 15,
                LastAcessDate = DateTime.Now
            };

            return View(myData);
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

        public ActionResult FAQ()
        {
            return View();
        }
    }
}