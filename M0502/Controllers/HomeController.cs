﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M0502.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var VM = new Models.VielModelComments();
            var Comments = VM.Comments.Take(5);
            return View(Comments);
        }
    }
}