using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class ToDoList : ViewComponent
    {
        ToDoManager toDoManager = new ToDoManager(new EfToDoDal());
        public IViewComponentResult Invoke()
        {
            var todolist = toDoManager.TGetList();
            return View(todolist);
        }
    }
}
