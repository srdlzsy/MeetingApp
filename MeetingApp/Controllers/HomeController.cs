
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
            ViewBag.selamlama = saat > 12 ? "iyi g�nler" : "g�nayd�n";
           int kullan�c�= ViewBag.UserCount = Repostory.users.Where(i => i.wiilattend == true).Count();

            var meeting�nfo = new Meeting�nfo() {
            Id = 1,
            Location = "abc sokak ankara",
            NumberOfPeople = kullan�c�,
            Date = DateAndTime.Now
            };

            return View(meeting�nfo);
        }


        public IActionResult Privacy()
        {
            return View();
        }

    }



}

