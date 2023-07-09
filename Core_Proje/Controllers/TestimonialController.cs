using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]

    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Referanslar Listesi";
            ViewBag.v2 = "Referanslar";
            ViewBag.v3 = "Referanslar Listesi";
            var values = testimonialManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            ViewBag.v1 = "Referans Ekle";
            ViewBag.v2 = "Referanslar";
            ViewBag.v3 = "Referanslar Ekle";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTestimonial(Testimonial testimonial, IFormFile Picture)
        {
            ViewBag.v1 = "Referans Ekle";
            ViewBag.v2 = "Referanslar";
            ViewBag.v3 = "Referanslar Ekle";

            if (Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(Picture.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/testimonialImage/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await Picture.CopyToAsync(stream);
                testimonial.ImageUrl = imageName;
            }

            testimonialManager.TAdd(testimonial);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            ViewBag.v1 = "Referans Düzenle";
            ViewBag.v2 = "Referanslar";
            ViewBag.v3 = "Referanslar Düzenle";
            var testimonail = testimonialManager.TGetById(id);
            return View(testimonail);
        }

        [HttpPost]
        public async Task<IActionResult> EditTestimonial(Testimonial testimonial, IFormFile Picture)
        {
            ViewBag.v1 = "Referans Düzenle";
            ViewBag.v2 = "Referanslar";
            ViewBag.v3 = "Referanslar Düzenle";

            if (Picture != null && Picture.Length > 0)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(Picture.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/testimonialImage/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await Picture.CopyToAsync(stream);
                testimonial.ImageUrl = imageName;
            }
            else
            {
                var oldFile = testimonialManager.TGetById(testimonial.TestimonialID);
                testimonial.ImageUrl = oldFile.ImageUrl;
            }

            testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteTestimonail(int id)
        {
            var testimonail = testimonialManager.TGetById(id);
            testimonialManager.TDelete(testimonail);
            return RedirectToAction("Index");
        }
    }
}
