using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.FeatureStatistics
{
    public class FeatureStatistics : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.skill = c.Skills.Count();
            ViewBag.unreadMessages = c.Messages.Where(x => x.Status == false).Count();
            ViewBag.readMessages = c.Messages.Where(x => x.Status == true).Count();
            ViewBag.projects = c.Portfolios.Count();

            return View();
        }
    }
}
