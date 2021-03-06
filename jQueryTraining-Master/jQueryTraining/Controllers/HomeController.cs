﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQueryTraining.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            Models.IndexModel model = new Models.IndexModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Models.IndexModel postModel) {
            postModel.FormPostMessage = "Your form posted";
            return View(postModel);
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}