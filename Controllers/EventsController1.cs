﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
