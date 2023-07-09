using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Yazar Admin Mesaj Sayfası";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Yazar Admin Mesaj Sayfası";
            return View();
        }

        public IActionResult ReceiverMessage()
        {
            ViewBag.v1 = "Yazar Admin Gelen Mesaj Sayfası";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Yazar Admin Gelen Mesaj Sayfası";
            string admin = "sinansaricayir@gmail.com";
            var messages = writerMessageManager.GetListReceiverMessage(admin);
            return View(messages);
        }

        public IActionResult SenderMessage()
        {
            ViewBag.v1 = "Yazar Admin Giden Mesaj Sayfası";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Yazar Admin Giden Mesaj Sayfası";
            string admin = "sinansaricayir@gmail.com";
            var messages = writerMessageManager.GetListSenderMessage(admin);
            return View(messages);
        }

        public IActionResult MessageDetail(int id)
        {
            ViewBag.v1 = "Yazar Admin Mesaj Detayı";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Yazar Admin Mesaj Detayı";
            var message = writerMessageManager.TGetById(id);
            return View(message);
        }

        [HttpGet]
        public IActionResult AddMessage()
        {
            ViewBag.v1 = "Yazar Admin Mesaj";
            ViewBag.v2 = "Mesajlar";
            ViewBag.v3 = "Mesaj Gönder";
            return View();
        }


        [HttpPost]
        public IActionResult AddMessage(WriterMessage message)
        {
            using var c = new Context();
            var recieverName = c.Users.Where(x => x.Email == message.Reciever).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            message.Sender = "sinansaricayir@gmail.com";
            message.SenderName = "Sinan Sarıçayır";
            message.RecieverName = recieverName;
            message.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            writerMessageManager.TAdd(message);
            return RedirectToAction("SenderMessage");
        }
    }
}
