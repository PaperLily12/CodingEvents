using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        static private Dictionary<string, string> events = new Dictionary<string, string>
        {
            { "Halloween party", "Come eat candy and carve pumpkins!" },
            {"Pi day", "Fun math activities on March 14" },
            {"Art fair", "See a variety of art from many artists." }
        };
        
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.events = events;
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("Events/Add")]
        public IActionResult NewEvent(string eventName, string eventDescription)
        {
            events.Add(eventName, eventDescription);
            return Redirect("/Events");
        }
    }
}
