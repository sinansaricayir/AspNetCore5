using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class WriterUserController : Controller
    {
        WriterUserManager writerUserManager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Yazar - Admin Listesi";
            ViewBag.v2 = "Yazar - Admin Sayfası";
            ViewBag.v3 = "Yazar - Admin Listesi";
            return View();
        }

        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(writerUserManager.TGetList());
            return Json(values);
        }

        public IActionResult GetById(int id)
        {
            var values = JsonConvert.SerializeObject(writerUserManager.TGetById(id));
            //Birşey döndürmesini istemezsek return NoContent()
            return Json(values);
        }


    }
}
