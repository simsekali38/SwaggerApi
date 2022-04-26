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
    public class RestaurantController : ControllerBase
    {
        ApplicationDbContext _context;

        public RestaurantController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<RestaurantController>
        [HttpGet]
        public IEnumerable<RestaurantModel> Get()
        {
            return _context.Restaurants.Where(x => x.IsActive == true);
        }

        // GET api/<RestaurantController>/5
        [HttpGet("{id}")]
        public RestaurantModel Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(s => s.RestaurantID == id);
        }

        // POST api/<RestaurantController>
        [HttpPost]
        public void Post([FromBody] RestaurantModel model)
        {
            if (model != null)
            {
                _context.Restaurants.Add(model);
                _context.SaveChanges();
            }
        }

        // PUT api/<RestaurantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RestaurantModel value)
        {
            var data = _context.Restaurants.FirstOrDefault(s => s.RestaurantID == id);
            if (data != null)
            {
                _context.Entry<RestaurantModel>(data).CurrentValues.SetValues(value);
                _context.SaveChanges();
            }

        }

        // DELETE api/<RestaurantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var data = _context.Restaurants.FirstOrDefault(s => s.RestaurantID == id);
            if (data != null)
            {
                _context.Restaurants.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
