﻿using ASP.NET.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        
        public ActionResult Index()
        {
            return View();
        }
    }
}