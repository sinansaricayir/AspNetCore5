using BusinessLayer.Concrete;
using Core_Proje.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class NavbarMessageList : ViewComponent
    {


        public IViewComponentResult Invoke()
        {
            using var context = new Context();
            List<WriterMessageImageUrl> MessageData = new List<WriterMessageImageUrl>();
            var email = "sinansaricayir@gmail.com";
            var admin = context.Users.FirstOrDefault(x => x.Email == email);
            var message = context.WriterMessages.Where(x => x.Reciever == admin.Email).ToList();

            if (admin != null)
            {
                if (message != null)
                {
                    foreach (var item in message)
                    {
                        var img = context.Users.FirstOrDefault(x => x.Email == item.Sender);
                        MessageData.Add(new WriterMessageImageUrl()
                        {
                            Id = item.WriterMessageID,
                            Date = item.Date,
                            SenderName = item.SenderName,
                            MessageContent = item.MessageContent,
                            ImageUrl = img.ImageUrl,
                        });
                    }
                }
            }

            return View(MessageData);
        }
    }
}
