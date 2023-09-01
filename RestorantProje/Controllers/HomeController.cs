using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using Repository.Entities;
using RestorantProje.Models;
using Service.Interfaces;
using System.Diagnostics;

namespace RestorantProje.Controllers
{

    public class HomeController : Controller
    {
        IAboutService _aboutService;
        IMenuService _menuService;
        IHizmetService _hizmetService;
        ITeamService _teamService;
        ITestimonialService _testimonialService;
        IBookingService _bookingService;
        IContactService _contactService;
        public HomeController(IAboutService aboutService, IMenuService menuService, IHizmetService hizmetService, ITeamService teamService, ITestimonialService testimonialService, IBookingService bookingService, IContactService contactService)
        {
            _aboutService = aboutService;
            _menuService = menuService;
            _hizmetService = hizmetService;
            _teamService = teamService;
            _testimonialService = testimonialService;
            _bookingService = bookingService;
            _contactService = contactService;
        }

        public IActionResult Kurumsal()
        {

            return View(_aboutService.GetList());
        }


        public IActionResult Anasayfa()
        {

            return View();
        }

        public IActionResult Menu()
        {
            var data = _menuService.GetList();
            return View(data);
        }

        public IActionResult Hizmet()
        {
            var data = _hizmetService.GetList();
            return View(data);
        }

        public IActionResult Team()
        {
            var data = _teamService.GetList();
            return View(data);
        }

        public IActionResult Testimonial()
        {
          var data=_testimonialService.GetList();
            return View(data);
        }
        [HttpGet]
        public IActionResult CreateBooking()
        {
            return View();
        }

        [HttpPost]
     //   [ValidateAntiForgeryToken]
        public IActionResult CreateBooking(Booking booking)
        {
                _bookingService.Add(booking);
                return View(booking);
        }

        [HttpGet]
        public IActionResult CreateContact()
        {     
            return View();

        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            _contactService.Add(contact);
            return View(contact);
           
        }
      
    }
}