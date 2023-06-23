using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyimler Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyimler Listesi";
            var values = experienceManager.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Deneyimler Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyimler Ekle";

            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            ViewBag.v1 = "Deneyimler Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyimler Ekle";

            ExperienceValidator validations = new ExperienceValidator();
            ValidationResult results = validations.Validate(experience);

            if (results.IsValid)
            {
                experienceManager.TAdd(experience);
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

        public IActionResult DeleteExperience(int id)
        {
            var experience = experienceManager.TGetById(id);
            experienceManager.TDelete(experience);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Deneyimler Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyimler Düzenle";

            var experince = experienceManager.TGetById(id);

            return View(experince);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            ViewBag.v1 = "Deneyimler Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyimler Düzenle";

            ExperienceValidator validation = new ExperienceValidator();
            ValidationResult results = validation.Validate(experience);

            if (results.IsValid)
            {
                experienceManager.TUpdate(experience);
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
