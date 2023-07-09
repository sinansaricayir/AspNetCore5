using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "İletişim Mesaj Listesi";
            ViewBag.v2 = "İletişim Mesaj";
            ViewBag.v3 = "İletişim Mesaj Listesi";
            var values = messageManager.TGetList();
            return View(values);
        }


        public IActionResult ShowMessage(int id)
        {
            ViewBag.v1 = "İletişim Mesaj Detayı";
            ViewBag.v2 = "İletişim Mesaj";
            ViewBag.v3 = "İletişim Mesaj Detayı";
            var message = messageManager.TGetById(id);
            return View(message);
        }

        public IActionResult DeleteMessage(int id)
        {
            var message = messageManager.TGetById(id);
            messageManager.TDelete(message);
            return RedirectToAction("Index");

        }
    }
}
