using Core_Proje_Api.DAL.ApiContext;
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

    }
}
