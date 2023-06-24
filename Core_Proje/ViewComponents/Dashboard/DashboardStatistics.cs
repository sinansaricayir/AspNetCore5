using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class DashboardStatistics : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.hizmet = c.Services.Count();
            ViewBag.referans = c.Testimonials.Count();
            ViewBag.deneyim = c.Experiences.Count();

            return View();
        }
    }
}
