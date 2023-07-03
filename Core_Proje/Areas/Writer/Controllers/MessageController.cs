using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    [Route("Writer/[controller]/[action]/{id?}")]
    public class MessageController : Controller
    {
        UserManager<WriterUser> _userManager;

        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> ReceiverMessage()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var messages = writerMessageManager.GetListReceiverMessage(user.Email);
            return View(messages);
        }

        public async Task<IActionResult> SenderMessage()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var messages = writerMessageManager.GetListSenderMessage(user.Email);
            return View(messages);
        }

        public IActionResult WriterMessageDetail(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetById(id);
            return View(writerMessage);
        }

        [HttpGet]
        public IActionResult AddMessage()
        {
            using var c = new Context();

            //uzun yol
            //var emails = new List<string>();
            //foreach(var item in c.Users)
            //{
            //    var mail = item.Email;
            //    emails.Add(mail);
            //}

            var emails = c.Users.Select(x => x.Email).ToList();
            ViewBag.emails = emails;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMessage(WriterMessage p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p.SenderName = user.Name + " " + user.Surname;
            p.Sender = user.Email;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            using var c = new Context();
            p.RecieverName = c.Users.Where(x => x.Email == p.Reciever).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writerMessageManager.TAdd(p);

            return RedirectToAction("SenderMessage");
        }
    }
}
