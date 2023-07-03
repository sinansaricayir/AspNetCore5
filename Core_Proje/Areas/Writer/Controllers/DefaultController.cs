using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    [Route("Writer/[controller]/[action]")]

    public class DefaultController : Controller
    {

        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var announcements = announcementManager.TGetList();
            return View(announcements);
        }

        public IActionResult AnnouncementDetail(int id)
        {
            var announcement = announcementManager.TGetById(id);
            return View(announcement);
        }
    }
}
