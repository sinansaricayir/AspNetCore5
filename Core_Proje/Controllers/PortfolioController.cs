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
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            portfolioManager.TAdd(portfolio);
            return RedirectToAction("Index");
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
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            portfolioManager.TUpdate(portfolio);
            return RedirectToAction("Index");
        }
    }
}
