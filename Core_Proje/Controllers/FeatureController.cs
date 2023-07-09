using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]

    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Öne Çıkanlar Listesi";
            ViewBag.v2 = "Öne Çıkanlar";
            ViewBag.v3 = "Öne Çıkanlar Listesi";

            var feature = featureManager.TGetById(1);

            return View(feature);
        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            ViewBag.v1 = "Öne Çıkanlar Listesi";
            ViewBag.v2 = "Öne Çıkanlar";
            ViewBag.v3 = "Öne Çıkanlar Listesi";

            FeatureValidator validations = new FeatureValidator();
            ValidationResult results = validations.Validate(feature);

            if (results.IsValid)
            {
                featureManager.TUpdate(feature);
                return RedirectToAction("Index", "Default");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
