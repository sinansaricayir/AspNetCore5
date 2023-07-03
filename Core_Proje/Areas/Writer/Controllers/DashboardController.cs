using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    [Route("Writer/[controller]/[action]")]

    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var userInformations = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.fullName = userInformations.Name + " " + userInformations.Surname;

            //statistics
            using var c = new Context();
            ViewBag.v1 = c.WriterMessages.Where(x=>x.Reciever == userInformations.Email).Count();
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = c.Users.Count();
            ViewBag.v4 = c.WriterMessages.Where(x => x.Sender == userInformations.Email).Count();

            //weather api key
            string apiKey = "cfe678ae68a34c2c54a4da1485841460";
            string city = "ankara";
            string url = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&mode=xml&lang=tr&&units=metric&appid=" + apiKey;
            XDocument document = XDocument.Load(url);
            ViewBag.api = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
