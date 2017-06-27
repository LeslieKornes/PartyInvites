using System;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            DateTime EventTime = new DateTime(2017, 7, 6);
            TimeSpan Duration = EventTime - DateTime.Now;
            string TimeTillEvent = Duration.ToString();
            ViewBag.EventTime = EventTime;
            ViewBag.TimeTillEvent = TimeTillEvent;
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid) { 
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
