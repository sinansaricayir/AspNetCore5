using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Listesi";

            var values = portfolioManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Proje Ekle";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Ekle";

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddPortfolio(Portfolio portfolio, IFormFile Picture1, IFormFile Picture2)
        {
            ViewBag.v1 = "Proje Ekle";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Ekle";

            List<IFormFile> Picture = new List<IFormFile>();
            Picture.Add(Picture1);
            Picture.Add(Picture2);

            List<string> imagePaths = new List<string>();

            foreach (var item in Picture)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(item.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/projectImage/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await item.CopyToAsync(stream);
                imagePaths.Add(imageName);
            }
            portfolio.ImageUrl = imagePaths[0];
            portfolio.ImageUrl2 = imagePaths[1];


            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(portfolio);

            if (results.IsValid)
            {
                portfolioManager.TAdd(portfolio);
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

        public IActionResult DeletePortfolio(int id)
        {
            var portfolio = portfolioManager.TGetById(id);
            portfolioManager.TDelete(portfolio);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.v1 = "Proje Düzenle";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Düzenle";

            var portfolio = portfolioManager.TGetById(id);
            return View(portfolio);
        }

        [HttpPost]
        public async Task<IActionResult> EditPortfolio(Portfolio portfolio, IFormFile Picture1, IFormFile Picture2)
        {
            ViewBag.v1 = "Proje Düzenle";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Düzenle";

            if (Picture1 != null && Picture2 != null)
            {
                List<IFormFile> Picture = new List<IFormFile>();
                Picture.Add(Picture1);
                Picture.Add(Picture2);

                List<string> imagePaths = new List<string>();

                foreach (var item in Picture)
                {
                    var resource = Directory.GetCurrentDirectory();
                    var extension = Path.GetExtension(item.FileName);
                    var imageName = Guid.NewGuid() + extension;
                    var saveLocation = resource + "/wwwroot/projectImage/" + imageName;
                    var stream = new FileStream(saveLocation, FileMode.Create);
                    await item.CopyToAsync(stream);
                    imagePaths.Add(imageName);
                }
                portfolio.ImageUrl = imagePaths[0];
                portfolio.ImageUrl2 = imagePaths[1];
            }
            else
            {
                var oldFile = portfolioManager.TGetById(portfolio.PortfolioID);
                portfolio.ImageUrl = oldFile.ImageUrl;
                portfolio.ImageUrl2 = oldFile.ImageUrl2;
            }

            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(portfolio);

            if (results.IsValid)
            {
                portfolioManager.TUpdate(portfolio);
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
