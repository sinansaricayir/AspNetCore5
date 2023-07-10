using Core_Proje_Api.DAL.ApiContext;
using Core_Proje_Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            using var c = new Context();
            var categories = c.Categories.ToList();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            using var c = new Context();
            var category = c.Categories.Find(id);
            if (category != null)
            {
                return Ok(category);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            using var c = new Context();
            c.Categories.Add(category);
            c.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            using var c = new Context();
            var category = c.Categories.Find(id);
            if (category != null)
            {
                c.Remove(category);
                c.SaveChanges();
                return Ok("Kategori başarıyla silindi!");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            using var c = new Context();
            var value = c.Find<Category>(category.CategoryID);

            if (value != null)
            {
                value.CategoryName = category.CategoryName;
                c.Update(value);
                c.SaveChanges();
                return Ok("Kategori başarıyla güncellendi!");
            }
            else
            {
                return NotFound();
            }

        }

    }
}
