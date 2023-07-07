using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialNewHead()
        {
            return PartialView();
        }  
        
        public PartialViewResult PartialNewNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialNewSidebar()
        {
            return PartialView();
        } 
        
        public PartialViewResult PartialNewScript()
        {
            return PartialView();
        }
    }
}
