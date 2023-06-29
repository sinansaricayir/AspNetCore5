using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.ViewComponents
{
    public class Account : ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public Account(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var profile = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.profileImage = profile.ImageUrl;
            return View();
        }
    }
}
