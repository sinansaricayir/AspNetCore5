﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
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
            var message = writerMessageManager.TGetById(id);
            return View(message);
        }

    }
}
