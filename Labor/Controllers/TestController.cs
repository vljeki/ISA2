﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Labor.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello world!";
        }

        public ActionResult GetView()
        {
            return View("MyView");
        }
    }
}