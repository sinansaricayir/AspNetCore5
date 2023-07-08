using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Sosyal Medya Listesi";
            ViewBag.v2 = "Sosyal Medya";
            ViewBag.v3 = "Hakkımızda Listesi";
            var socials = socialMediaManager.TGetList();
            return View(socials);
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            ViewBag.v1 = "Sosyal Medya Ekle";
            ViewBag.v2 = "Sosyal Medya";
            ViewBag.v3 = "Sosyal Medya Ekle";
            return View();
        }

        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            socialMedia.Status = true;
            socialMediaManager.TAdd(socialMedia);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var social = socialMediaManager.TGetById(id);
            return View(social);
        }

        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia socialMedia)
        {
            socialMediaManager.TUpdate(socialMedia);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var social = socialMediaManager.TGetById(id);
            socialMediaManager.TDelete(social);
            return RedirectToAction("Index");
        }
    }
}
