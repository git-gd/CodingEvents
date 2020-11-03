using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        // STATIC - this means every copy of Events will be the same
        // if more than one web browser opens the website the single STATIC List<string> Events will be shared across all browsers
        //static private List<string> Events = new List<string>();

        // 13.10.2-1 Change the List into a Dictionary of Name and Description - Dictionary<string,string>
        static private Dictionary<string, string> Events = new Dictionary<string, string>();

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
        public IActionResult NewEvent(string name, string description)
        {
            // add the string passed as name to our Events list
            if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(description)) Events.Add(name, description);

            // redirect to the Events page view to show our updated Events list
            return Redirect("/Events");
        }
    }
}
