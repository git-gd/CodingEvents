using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        static private List<string> Events = new List<string>();
        // GET: /Events
        [HttpGet]
        public IActionResult Index()
        {
            Events.Add("Grocery Shopping");
            Events.Add("Traffic Jam");
            Events.Add("Work");

            ViewBag.events = Events;

            return View();
        }

        // GET: /Events/Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
