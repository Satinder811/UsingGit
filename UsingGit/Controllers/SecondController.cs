﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsingGit.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult Index()
        {
            Console.WriteLine("This is controller");
            return View();
        }
    }
}