using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
      
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(Userİnfo model)
        { if (ModelState.IsValid)
            {
                Repostory.CreateUser(model);
                ViewBag.UserCount = Repostory.users.Where(i => i.wiilattend == true).Count();

                return View("Thanks", model);
            }
        else
            {
                return View(model);
            }
           
        }

        public IActionResult List()
        {
            var user = Repostory.users;
            return View(user);
        }
        public IActionResult Detays(int id )
        {
           var x= Repostory.users.FirstOrDefault(i => i.Id==id);
            return View(x);
        }
    }
}
