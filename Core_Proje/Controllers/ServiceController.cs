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

    public class ServiceController : Controller
    {

        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmetler Listesi";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmetler Listesi";
            var services = serviceManager.TGetList();
            return View(services);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.v1 = "Hizmet Ekle";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmetler Ekle";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddService(Service service, IFormFile Picture)
        {
            ViewBag.v1 = "Hizmet Ekle";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmet Ekle";

            if (Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(Picture.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/serviceImage/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await Picture.CopyToAsync(stream);
                service.ImageUrl = imageName;
            }

            ServiceValidator validations = new ServiceValidator();
            ValidationResult results = validations.Validate(service);

            if (results.IsValid)
            {
                serviceManager.TAdd(service);
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

        public IActionResult DeleteService(int id)
        {
            var service = serviceManager.TGetById(id);
            serviceManager.TDelete(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.v1 = "Hizmet Düzenle";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmet Düzenle";

            var service = serviceManager.TGetById(id);

            return View(service);
        }


        [HttpPost]
        public async Task<IActionResult> EditService(Service service, IFormFile Picture)
        {
            ViewBag.v1 = "Hizmet Düzenle";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmet Düzenle";

            if (Picture != null && Picture.Length > 0)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(Picture.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/serviceImage/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await Picture.CopyToAsync(stream);
                service.ImageUrl = imageName;
            }
            else
            {
                var oldFile =serviceManager.TGetById(service.ServiceID);
                service.ImageUrl = oldFile.ImageUrl;
            }

            ServiceValidator validations = new ServiceValidator();
            ValidationResult results = validations.Validate(service);

            if (results.IsValid)
            {
                serviceManager.TUpdate(service);
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
