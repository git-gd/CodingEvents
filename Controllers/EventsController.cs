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
            ViewBag.events = Events;

            return View();
        }

        // GET: /Events/Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // POST: /Events/Add
        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(string name)
        {
            // add the string passed as name to our Events list
            Events.Add(name);

            // redirect to the Events page view to show our updated Events list
            return Redirect("/Events");
        }
    }
}
