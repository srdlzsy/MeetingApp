
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var saat = DateAndTime.Now.Hour;
            ViewData["user"] = "serdal";
            ViewBag.selamlama = saat > 12 ? "iyi günler" : "günaydýn";
           int kullanýcý= ViewBag.UserCount = Repostory.users.Where(i => i.wiilattend == true).Count();

            var meetingÝnfo = new MeetingÝnfo() {
            Id = 1,
            Location = "abc sokak ankara",
            NumberOfPeople = kullanýcý,
            Date = DateAndTime.Now
            };

            return View(meetingÝnfo);
        }


        public IActionResult Privacy()
        {
            return View();
        }

    }



}

