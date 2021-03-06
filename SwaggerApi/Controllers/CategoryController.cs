using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerApi.DbContext;
using SwaggerApi.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwaggerApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<CategoryModel> Get()
        {
            return _context.Categories.Where(x => x.IsActive == true);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public CategoryModel Get(int id)
        {
            return _context.Categories.FirstOrDefault(s => s.CategoryID == id);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] CategoryModel model)
        {
            if (model != null)
            {
                _context.Categories.Add(model);
                _context.SaveChanges();
            }
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CategoryModel value)
        {
            var data = _context.Categories.FirstOrDefault(s => s.CategoryID == id);
            if (data != null)
            {
                _context.Entry<CategoryModel>(data).CurrentValues.SetValues(value);
                _context.SaveChanges();
            }
          
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var data = _context.Categories.FirstOrDefault(s => s.CategoryID == id);
            if (data != null)
            {
                _context.Categories.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
