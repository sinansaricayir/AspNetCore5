using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkımızda Listesi";
            ViewBag.v2 = "Hakkımızda";
            ViewBag.v3 = "Hakkımızda Listesi";

            var about = aboutManager.TGetList().FirstOrDefault();

            return View(about);
        }

        [HttpPost]
        public async Task<IActionResult> Index(About about, IFormFile Picture)
        {
            ViewBag.v1 = "Hakkımızda Listesi";
            ViewBag.v2 = "Hakkımızda";
            ViewBag.v3 = "Hakkımızda Listesi";

            if (Picture != null && Picture.Length > 0)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(Picture.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/aboutImage/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await Picture.CopyToAsync(stream);
                about.ImageUrl = imageName;
            }
            else
            {
                var oldFile = aboutManager.TGetById(about.AboutID);
                about.ImageUrl = oldFile.ImageUrl;
            }

            AboutValidator validations = new AboutValidator();
            ValidationResult results = validations.Validate(about);

            if (results.IsValid)
            {
                aboutManager.TUpdate(about);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
